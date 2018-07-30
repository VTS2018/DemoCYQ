using System;
using System.Web;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Web.UI.HtmlControls;
using System.Data;

namespace DemoCYQ
{
    public partial class Pager : System.Web.UI.UserControl
    {
        private int _PageSize;
        public int PageSize
        {
            get
            {
                if (_PageSize == 0)
                {
                    _PageSize = 1;
                }
                return _PageSize;
            }
            set
            {
                _PageSize = value;
            }
        }
        private int _Count;
        public int Count
        {
            get
            {

                return _Count;
            }
            set
            {
                _Count = value;
            }
        }
        /// <summary>
        /// 该方法名称修饰符为public
        /// </summary>
        public string BindName
        {
            get
            {
                return hfBindName.Value;
            }

            set
            {
                hfBindName.Value = value;
            }
        }
        private int _PageIndex;
        public int PageIndex
        {
            get
            {
                if (_PageIndex == 0)
                {
                    _PageIndex = 1;
                }
                return _PageIndex;
            }
            set
            {
                _PageIndex = value;
            }
        }

        private void Page_Load(object sender, System.EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindPager();
            }
        }

        protected void BindPageNum(int pageCount)
        {
            int start = 1, end = 10;
            if (pageCount < end)//页数小于10
            {
                end = pageCount;
            }
            else
            {
                start = (PageIndex > 5) ? PageIndex - 5 : start;
                int result = (start + 9) - pageCount;//是否超过最后面的页数
                if (result > 0)
                {
                    end = pageCount;
                    start -= result;//超过后,补差
                }
                else
                {
                    end = start + 9;
                }
            }
            ReBindNum(start, end);
        }
        protected void ClickEvent(object sender, EventArgs e)
        {
            ReBindData(((LinkButton)sender).CommandArgument.ToString());
        }
        protected void rptNum_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            ReBindData(e.CommandArgument.ToString());
        }
        private void ReBindData(string pageIndex)
        {
            PageIndex = int.Parse(pageIndex);
            object obj = base.Parent is HtmlForm ? this.Page : base.Parent;
            MethodInfo mi = obj.GetType().GetMethod(BindName);
            mi.Invoke(obj, null);
            BindPager();
        }
        private void ReBindNum(int start, int end)
        {
            int[] rows = new int[end - start + 1];
            int index = 0;
            for (int i = start; i <= end; i++)
            {
                rows[index] = i;
                index++;
            }
            rptNum.DataSource = rows;
            rptNum.DataBind();
        }
        public void BindPager()
        {
            int pageCount = (Count % PageSize) == 0 ? Count / PageSize : Count / PageSize + 1;//页数
            SetButtonEnable(pageCount);
            BindPageNum(pageCount);
        }
        private void SetButtonEnable(int pageCount)
        {
            lbtnFirstLink.Enabled = PageIndex != 1;
            lbtnPrevPage.Enabled = PageIndex != 1;
            lbtnNextPage.Enabled = PageIndex != pageCount;
            lbtnLastPage.Enabled = PageIndex != pageCount;
            lbtnFirstLink.CommandArgument = "1";
            lbtnPrevPage.CommandArgument = (PageIndex - 1).ToString();
            lbtnNextPage.CommandArgument = (PageIndex + 1).ToString();
            lbtnLastPage.CommandArgument = pageCount.ToString();
        }
    }
}