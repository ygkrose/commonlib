using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///已讀紀錄檔
/// </summary>
public class ReadHistory : TableBase
{



///<summary>
///已讀時間
///[datetime, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///帳號
///[char(36), nullable(True)]
///</summary>
public Guid? User_Id { get; set; }

///<summary>
///員工
///[char(36), nullable(True)]
///</summary>
public Guid? Employee_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///來源TableName
///[varchar(50), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceTable_Id { get; set; }
}
}
