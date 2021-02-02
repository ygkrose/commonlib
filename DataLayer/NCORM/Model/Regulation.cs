using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///規約辦法文件管理(規約辦法、住戶手冊)
/// </summary>
public class Regulation : TableBase
{



///<summary>
///標題
///[varchar(50), nullable(True)]
///</summary>
public string Title { get; set; }

///<summary>
///內文
///[varchar(500), nullable(True)]
///</summary>
public string Content { get; set; }

///<summary>
///主管機關
///[varchar(20), nullable(True)]
///</summary>
public string CompetentAuthority { get; set; }

///<summary>
///公告單位
///[varchar(20), nullable(True)]
///</summary>
public string Announcer { get; set; }

///<summary>
///最後修改依據
///[varchar(20), nullable(True)]
///</summary>
public string AccordingTo { get; set; }

///<summary>
///檔案上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }

///<summary>
///連結網址
///[varchar(50), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///不顯示(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsHidden { get; set; }

///<summary>
///公佈日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///html內文
///[text, nullable(True)]
///</summary>
public string HtmlContent { get; set; }

///<summary>
///程式類別(Regulation規約辦法、Manual住戶手冊)
///[varchar(20), nullable(True)]
///</summary>
public string Code_RegulationProg { get; set; }

///<summary>
///排序
///[varchar(5), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///置頂(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OnTop { get; set; }

///<summary>
///文件等級
///[char(1), nullable(True)]
///</summary>
public string DocRank { get; set; }

///<summary>
///審核人員
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///審核日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }

///<summary>
///公司ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///集團
///[char(36), nullable(True)]
///</summary>
public Guid? Group_Id { get; set; }

///<summary>
///資料維護部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///上架(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Released { get; set; }

///<summary>
///全體適用(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string ForAll { get; set; }
}
}
