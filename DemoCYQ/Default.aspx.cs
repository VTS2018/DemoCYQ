using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CYQ.Data;
using CYQ.Data.Table;
using CYQ.Entity.VTSData;

namespace DemoCYQ
{
    public partial class _Default : System.Web.UI.Page
    {
        #region 页面加载
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Insert1();
            }
        }
        #endregion

        #region 试一试======================================
        //绑定列表
        public void Demo1()
        {
            using (MAction action = new MAction(TableNames.Category))
            {
                action.Select().Bind(GridView1);
            }
        }
        #endregion

        #region 1：单行数据操作=============================
        //示例1：直传ID
        public void Demo2()
        {

            using (MAction action = new MAction(TableNames.Category))
            {
                if (action.Fill(1))//取id=249的值
                {
                    //控件ID约定方式为“三个任意字母前缀”+字段名：如labUserName,UserName为表的字段名。 
                    //对UI操作：SetTo与GetFrom
                    action.SetTo(labTemplate);
                    action.SetTo(txtTemplate);
                    //对非UI操作：Set 与 Get
                    string Template = action.Get<string>(Category.Template);
                    litTemplate.Text = Template;
                }
            }
        }

        //示例2：传where条件
        public void Demo3()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                if (action.Fill("CategoryID=1 or Name='精品福利1'"))
                {
                    action.SetTo(litName);
                }
            }
        }

        //示例3：where条件附带order by
        public void Demo4()
        {
            //示例3：where条件附带order by
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                //查询ID>888的结果中取ID最大的的单行数据
                if (action.Fill("CategoryID>16 order by CategoryID desc"))
                {
                    action.SetTo(litName);
                }
            }
        }

        //示例4：[MDataRow]行数据转实体
        public void Demo5()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                //查询ID>888的结果中取ID最大的的单行数据
                if (action.Fill("18"))
                {
                    //CategoryDescription为实体类。
                    CategoryDescriptionInfo info = action.Data.ToEntity<CategoryDescriptionInfo>();
                    Response.Write(info.Name);
                }
            }
        }
        #endregion

        #region 2：GetCount 取统计总数======================
        public void Demo6()
        {
            using (MAction action = new MAction(TableNames.Category))
            {
                int count = action.GetCount("CategoryID>0");
                labTemplate.Text = count.ToString();
            }
        }
        #endregion

        #region 3：Exists 是否存在指定条件的数据（*）=======
        public void Demo7()
        {
            using (MAction action = new MAction(TableNames.Category))
            {
                bool userExists = action.Exists("CategoryID=-1");
                labTemplate.Text = (userExists == true) ? "存在" : "不存在";
            }
        }
        #endregion

        #region 4：Select 多数据查询========================
        public void Demo8()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                //查询所有数据
                MDataTable tabme = action.Select();
                foreach (MDataRow item in tabme.Rows)
                {
                    Response.Write(item[1].Value + "<br />");
                }
                Response.Write("<hr />");
            }

            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                //查询指定条件的所有数据并降序排列
                MDataTable tabme = action.Select("CategoryID>10 order by CategoryID desc");
                foreach (MDataRow item in tabme.Rows)
                {
                    Response.Write(item[1].Value + "<br />");
                }
            }

            int count;//返回的记录总数
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                action.Select(1, 10, "CategoryID>10 order by CategoryID asc", out count).Bind(GridView1);

                //查询id>10的10条记录[第1页,每页10条数据,结果按usename排序]
                labTemplate.Text = count.ToString();
            }
        }
        #endregion

        #region 5.绑定GridView/DataList/Repeater============
        public void Demo9()
        {
            //绑定所有
            using (MAction action = new MAction(TableNames.Category))
            {
                action.Select().Bind(GridView1);
            }

            /*
            using (MAction action = new MAction(TableNames.m_category))
            {
                if (action.Fill(1))
                {
                    action.GetFrom(txttitle);
                    action.Data["title"].Value = txttitle.Text;
                    action.GetFrom(txttitle, "自定一个分类");//将自定义值赋给数据行，忽略控件的值。

                    //这里是本节要说的取值与赋值操作
                }
            }
            using (MAction action = new MAction(TableNames.m_category))
            {
                //action.Bind(ddltitle);
                action.Bind(ddltitle, "id>317");//按条件查询数据并绑定下拉列表，文本域为UserName,值域为ID
            }

            using (MAction action = new MAction(TableNames.m_category))
            {
                action.Bind(ddltitle, "id>10", CYQ.Entity.BaseDB.m_category.title, CYQ.Entity.BaseDB.m_category.id);//按条件查询数据并绑定下拉列表，文本域为NickName,值域为ID
            }*/
        }

        public void BingDataPager1()
        {
            int count;
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                action.Select(Pager.PageIndex, Pager.PageSize, "CategoryID>10 order by CategoryID desc", out count).Bind(GridView1);
            }
            Pager.Count = count;//设置记录总数
            Pager.BindName = "BindData";//绑定方法名称，需要为Public
        }
        #endregion

        #region 五：视图方式================================
        #endregion

        #region 六：多表查询：自定义构造多表SQL语句=========
        public void Demo10()
        {
            //既可以用表又可以用自定一个SQL语句
            string strSQL = "(select * from CategoryDescription Inner join Category on CategoryDescription.CategoryID=Category.CategoryID) v";
            int count;
            using (MAction action = new MAction(strSQL))
            {
                action.Select(Pager.PageIndex, Pager.PageSize, "CategoryID>0 order by CategoryID desc", out count).Bind(GridView1);
            }
            Pager.Count = count;           //设置记录总数
            Pager.BindName = "BindData";   //绑定方法名称，需要为Public
        }
        #endregion

        #region 第三篇：取值与赋值的相关操作================
        //1：GetFrom 从控件中取值设置到行中
        //public void GetFrom(Control ct)
        //public void GetFrom(Control ct, object value)

        //2：SetTo 将数据行中的数据设置到控件
        //public void SetTo(Control ct)
        //public void SetTo(Control ct, object value)
        //public void SetTo(Control ct, object value, bool isControlEnabled)

        public void Set1()
        {
            using (MAction action = new MAction(TableNames.Category))
            {
                if (action.Fill("33"))
                {
                    //给控件赋值，数据来源于数据行。
                    action.SetTo(labTemplate);
                    action.SetTo(txtTemplate);
                    action.SetTo(litTemplate);

                    //给控件赋值，数据来源于自定义值
                    action.SetTo(litTemplate, "路过秋天");

                    //给控件赋值，同时设置控件Enable属性
                    action.SetTo(txtTemplate, null, false);
                }
            }
        }


        //二：非UI操作

        //1：Get 从行中获取数据
        //原生方法：public T Get<T>(object key)
        public void Get1()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                if (action.Fill("33"))
                {
                    string name = action.Get<string>(CategoryDescription.Name);
                    name = action.Data["Name"].Value.ToString();
                    Response.Write(name);
                }
            }
        }

        //2：Set 从变量中设置值到行中
        //原生方法：public void Set(object key,object value)
        public void Get2()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                if (action.Fill("33"))
                {
                    action.Set(CategoryDescription.Name, "路过秋天");
                    //action.Data["Name"].Value = "路过秋天";
                }
            }
        }

        //三：UI操作：DrowDownList等列表控件的UI操作
        //方法原型：
        //public MAction Bind((object control)
        //public MAction Bind(string control, string where)
        //public MAction Bind((object control, string where, object text, object value)
        public void Bind1()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                //Bug:必须要一个ID列
                //action.Bind(ddlTableName);

                //action.Bind(ddlTableName,"ID>=10");

                //控件 查询条件 文本域 值域
                action.Bind(ddlTableName, "CategoryID>=10", CategoryDescription.Name, CategoryDescription.CategoryID);
            }
        }
        #endregion

        #region 第四篇 MAction增删查改======================
        //方法原型：
        //public bool Insert()
        //public bool Insert(bool autoSetValue)
        //public bool Insert(bool autoSetValue, InsertOption option)
        public void Insert1()
        {
            using (MAction action = new MAction(TableNames.CategoryDescription))
            {
                #region 增加操作
                ////非UI型设值
                //action.Set(CategoryDescription.Name, "路过秋天1");

                ////UI型设值
                ////action.GetFrom(txttitle);

                //if (action.Insert())
                //{
                //    //Bug:默认需要ID列
                //    //取回插入后的主键ID
                //    int id = action.Get<int>(CategoryDescription.CategoryID);
                //    Response.Write(id);
                //}

                //第二种
                //action.Set(CategoryDescription.Name, "路过秋天");//非UI型设值 
                //action.GetFrom(txtUserName)//UI型设值

                //action.SetAutoPrefix("txt");//设置控件前缀，可设置多个
                //action.Insert(true);//除了已赋值的，其它表字段，自动从Request["txt字段"]中取值。 
                #endregion

                #region 删除操作
                //Bug:-1时也返回true
                //action.Set(CategoryDescription.CategoryID, -1);
                //bool bl = action.Delete();


                //bool bl = action.Delete("CategoryID<=6 or Name='路过秋天'");
                //Response.Write(bl); 
                #endregion

                #region 更新操作
                action.Set(CategoryDescription.Name,"新名字");
                bool bl = action.Update("CategoryID=7");
                Response.Write(bl);
                #endregion
            }
        }
        #endregion
    }
}