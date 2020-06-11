using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///規約辦法文件管理(規約辦法、住戶手冊、操作手冊)
/// </summary>
public class CompanyTerms : TableBase
{



///<summary>
///社區Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///類別
///[varchar(20), nullable(True)]
///</summary>
public string LawTerm { get; set; }

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
public Guid? uploadFile_Id { get; set; }

///<summary>
///連結網址
///[varchar(50), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///不顯示(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsHidden { get; set; }

///<summary>
///公佈日期
///[date, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///html內文
///[text, nullable(True)]
///</summary>
public string HtmlContent { get; set; }

///<summary>
///程式類別
///[varchar(20), nullable(True)]
///</summary>
public string ProgType { get; set; }
}
}
