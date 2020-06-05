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
///張貼人Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid AnnouncerUser_Id { get; set; }

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
///[char(36), nullable(True)]
///</summary>
public Guid? AnnounceType { get; set; }

///<summary>
///發佈對象，對應到Organization_Id
///[char(36), nullable(True)]
///</summary>
public Guid? TargetOrg_Id { get; set; }

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
}
}
