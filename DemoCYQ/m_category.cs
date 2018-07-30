using System;

namespace DemoCYQ.Entity
{
    /// <summary>
    /// m_category:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class m_category
    {
        public m_category() { }
        #region Model
        private int _id;
        private int _webid = 0;
        private string _title;
        private int _parent_id = 0;
        private string _class_list;
        private int _class_layer = 0;
        private int _sort_id = 0;
        private string _link_url;
        private string _img_url;
        private string _content;
        private string _seo_title;
        private string _seo_keywords;
        private string _seo_description;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int webid
        {
            set { _webid = value; }
            get { return _webid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int parent_id
        {
            set { _parent_id = value; }
            get { return _parent_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string class_list
        {
            set { _class_list = value; }
            get { return _class_list; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int class_layer
        {
            set { _class_layer = value; }
            get { return _class_layer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int sort_id
        {
            set { _sort_id = value; }
            get { return _sort_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string link_url
        {
            set { _link_url = value; }
            get { return _link_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string img_url
        {
            set { _img_url = value; }
            get { return _img_url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string seo_title
        {
            set { _seo_title = value; }
            get { return _seo_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string seo_keywords
        {
            set { _seo_keywords = value; }
            get { return _seo_keywords; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string seo_description
        {
            set { _seo_description = value; }
            get { return _seo_description; }
        }
        #endregion Model
    }
}

