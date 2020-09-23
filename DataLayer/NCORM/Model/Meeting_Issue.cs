using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///會議議題
/// </summary>
public class Meeting_Issue : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Meeting_Id { get; set; }

///<summary>
///項次
///[varchar(4), nullable(True)]
///</summary>
public string Order { get; set; }

///<summary>
///議題類別
///[varchar(20), nullable(True)]
///</summary>
public string IssueTerm { get; set; }

///<summary>
///議題
///[varchar(150), nullable(True)]
///</summary>
public string Issue { get; set; }

///<summary>
///議題說明
///[varchar(1550), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///決議
///[varchar(600), nullable(True)]
///</summary>
public string Resolution { get; set; }

///<summary>
///暫緩處理(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsHold { get; set; }

///<summary>
///預計完成日
///[date, nullable(True)]
///</summary>
public DateTime? ExpectedDate { get; set; }

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
