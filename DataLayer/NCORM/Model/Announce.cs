using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///系統公告
/// </summary>
public class Announce : TableBase
{



///<summary>
///主旨
///[varchar(200), nullable(False)]
///</summary>
[Required]
public string TitleDesc { get; set; }

///<summary>
///張貼人名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string AnnouncerUser { get; set; }

///<summary>
///公告起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///公告訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///發佈類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_Announce { get; set; }

///<summary>
///置頂(0:否, 1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 OnTop { get; set; }

///<summary>
///必讀(0:否, 1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 MustRead { get; set; }

///<summary>
///發佈於登入頁面(0:否, 1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 OnLogin { get; set; }

///<summary>
///公告主文
///[text, nullable(True)]
///</summary>
public string Content { get; set; }

///<summary>
///對外連結
///[varchar(200), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///公告區域id
///[char(36), nullable(True)]
///</summary>
public Guid? targetRegion_Id { get; set; }

///<summary>
///公告大類
///[varchar(20), nullable(True)]
///</summary>
public string Code_Main { get; set; }

///<summary>
///公告小類
///[varchar(20), nullable(True)]
///</summary>
public string Code_Sub { get; set; }

///<summary>
///承辦人
///[varchar(50), nullable(True)]
///</summary>
public string ContactPerson { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///是否輪播(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsCarousel { get; set; }

///<summary>
///輪播檔案
///[char(36), nullable(True)]
///</summary>
public Guid? carouselFile_Id { get; set; }

///<summary>
///輪播開始時間
///[datetime, nullable(True)]
///</summary>
public DateTime? PushDate { get; set; }

///<summary>
///html內文
///[text, nullable(True)]
///</summary>
public string HtmlContent { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
