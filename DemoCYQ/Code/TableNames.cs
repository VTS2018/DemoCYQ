namespace CYQ.Entity.main {
public enum TableNames{Category,sqlite_autoindex_Category_1,CategoryDescription,sqlite_autoindex_CategoryDescription_1,sqlite_autoindex_CategoryDescription_2,TagGroup,sqlite_autoindex_TagGroup_1,Tag,sqlite_autoindex_Tag_1,sqlite_autoindex_Tag_2,sqlite_autoindex_Tag_3,Post,sqlite_autoindex_Post_1,sqlite_autoindex_Post_2,PostMeta,sqlite_autoindex_PostMeta_1,PostToCategory,sqlite_autoindex_PostToCategory_1,PostImages,sqlite_autoindex_PostImages_1,TagRelationships,sqlite_autoindex_TagRelationships_1,sqlite_autoindex_TagRelationships_2,IndexFile,sqlite_autoindex_IndexFile_1}
 #region Ã¶¾Ù 
 public enum Category { CategoryID,ParentID,ClassPath,ClassLayer,DateAddtime,LastModified,Status,Color,SortOrder,Count,WebSiteID,ChannelID,EntityName,Template,AdsHtml}
 public enum sqlite_autoindex_Category_1 { }
 public enum CategoryDescription { CategoryID,Name,Slug,SmallImg,MiddleImg,BigImg,SeoTitle,SeoKeywords,SeoDescription,Description}
 public enum sqlite_autoindex_CategoryDescription_1 { }
 public enum sqlite_autoindex_CategoryDescription_2 { }
 public enum TagGroup { TagGroupID,Name,SortOrder,Status}
 public enum sqlite_autoindex_TagGroup_1 { }
 public enum Tag { TagID,Name,Slug,Description,Color,SortOrder,Count,CreateTime,TagGroupID}
 public enum sqlite_autoindex_Tag_1 { }
 public enum sqlite_autoindex_Tag_2 { }
 public enum sqlite_autoindex_Tag_3 { }
 public enum Post { PostID,CategoryID,UserID,Title,Slug,Summary,Content,CustomAttribute,Tag,TopStatus,CommentStatus,Recommend,ViewCount,CommentCount,UrlFormat,ImageUrl,PassWord,Template,Type,Status,SortOrder,CreateTime,UpdateTime,PublishTime,CustomUrl,SkipUrl,SeoTitle,SeoKeywords,SeoDescription,PreviousPostID,NextPostID}
 public enum sqlite_autoindex_Post_1 { }
 public enum sqlite_autoindex_Post_2 { }
 public enum PostMeta { MetaID,PostID,MetaKey,MetaValue}
 public enum sqlite_autoindex_PostMeta_1 { }
 public enum PostToCategory { PostID,CategoryID}
 public enum sqlite_autoindex_PostToCategory_1 { }
 public enum PostImages { PostID,FolderName,MainImg,DetailImg,Video,Ext1,Ext2,Ext3}
 public enum sqlite_autoindex_PostImages_1 { }
 public enum TagRelationships { TrID,EntityID,EntityName,TagID,SortOrder}
 public enum sqlite_autoindex_TagRelationships_1 { }
 public enum sqlite_autoindex_TagRelationships_2 { }
 public enum IndexFile { ID,EntityID,EntityName,DataBase,TableName,Guid}
 public enum sqlite_autoindex_IndexFile_1 { }
 #endregion
}