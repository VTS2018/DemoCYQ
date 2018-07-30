namespace CYQ.Entity.BaseDB
{
    public enum TableNames { m_temp, m_news, m_topic, m_type, m_tag, m_tagtype, m_website, m_movie, m_torrent_attach, m_category, m_fanhaocate, m_fanhao_bt, m_data }
    #region Ã¶¾Ù
    public enum m_temp { m_id, m_name, m_enname, m_type, m_pic, m_actor, m_note, m_des, m_topic, m_color, m_foldername, m_detailimg, m_lastedittime, m_addtime, m_publishtime, m_publishyear, m_publisharea, m_playdata, m_downdata, m_letter, m_keyword, m_director, m_recycle, m_score }
    public enum m_news { m_id, m_type, m_title, m_entitle, m_from, m_author, m_color, m_pic, m_keyword, m_outline, m_content, m_note, m_topic, m_letter, m_addtime, m_lastedittime, m_publishtime, m_recycle }
    public enum m_topic { m_id, m_name, m_enname, m_sort, m_pic, m_des, m_hide }
    public enum m_type { m_id, m_name, m_enname, m_note, m_sort, m_upid, m_hide, m_keyword, m_description, m_mtype, m_webid }
    public enum m_tag { m_id, m_name, m_enname, m_type, m_color, m_sort, m_hide, m_description }
    public enum m_tagtype { m_id, m_name, m_enname, m_description, m_sort }
    public enum m_website { m_id, m_name, m_url, m_sort, m_hide, m_description }
    public enum m_movie { m_id, m_name, m_enname, m_type, m_pic, m_actor, m_note, m_des, m_topic, m_color, m_foldername, m_detailimg, m_lastedittime, m_addtime, m_publishtime, m_publishyear, m_publisharea, m_playdata, m_downdata, m_letter, m_keyword, m_director, m_recycle, m_score, m_fanhaoname, m_fanhaoid, m_sort }
    public enum m_torrent_attach { id, cate, code, hash, magent, down_id, title, file_path, file_ext, file_size, filetype, down_num }
    public enum m_category { id, webid, title, parent_id, class_list, class_layer, sort_id, link_url, img_url, content, seo_title, seo_keywords, seo_description }
    public enum m_fanhaocate { f_id, f_name, f_pic, f_des, f_sort, f_addtime, f_pubtime, f_edittime, f_hidden, f_count }
    public enum m_fanhao_bt { mfid, m_id, b_id, f_hidden, f_sort }
    public enum m_data { m_id, m_name, m_enname, m_type, m_pic, m_actor, m_note, m_des, m_topic, m_color, m_foldername, m_detailimg, m_lastedittime, m_addtime, m_publishtime, m_publishyear, m_publisharea, m_playdata, m_downdata, m_letter, m_keyword, m_director, m_recycle, m_score }
    #endregion
}