using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///會議管理
/// </summary>
public class Meeting : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///會議日期時間起
///[datetime, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///會議日期時間訖
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///會議類別(區權會、管委會)
///[varchar(20), nullable(True)]
///</summary>
public string MeetingTerm { get; set; }

///<summary>
///會議地點
///[varchar(30), nullable(True)]
///</summary>
public string Place { get; set; }

///<summary>
///會議名稱
///[varchar(50), nullable(True)]
///</summary>
public string Title { get; set; }

///<summary>
///會議主席
///[varchar(20), nullable(True)]
///</summary>
public string Chief { get; set; }

///<summary>
///承辦人員
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///應出席人數
///[int(11), nullable(True)]
///</summary>
public Int32? AttendQty { get; set; }

///<summary>
///會議主旨
///[varchar(150), nullable(True)]
///</summary>
public string Subject { get; set; }

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
