using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///區權會出席管理
/// </summary>
public class Meeting_Attendance : TableBase
{



///<summary>
///會議管理ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Meeting_Id { get; set; }

///<summary>
///序號
///[varchar(4), nullable(False)]
///</summary>
[Required]
public string Order { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///所有權人
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Client_Id { get; set; }

///<summary>
///本人/委託出席
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string AttendTerm { get; set; }

///<summary>
///出席人姓名
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///委託關係
///[varchar(20), nullable(True)]
///</summary>
public string RepresentRelationship { get; set; }

///<summary>
///委託書上傳
///[char(36), nullable(True)]
///</summary>
public Guid? representFile_Id { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///區分比例分子
///[int(11), nullable(True)]
///</summary>
public Int32? Numerator { get; set; }

///<summary>
///區分比例分母
///[int(11), nullable(True)]
///</summary>
public Int32? Denominator { get; set; }

///<summary>
///通知單條碼
///[varchar(50), nullable(True)]
///</summary>
public string QRCode { get; set; }

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
