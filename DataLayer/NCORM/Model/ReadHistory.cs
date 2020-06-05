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
///</summary>
public DateTime? Date { get; set; }

///<summary>
///帳號
///</summary>
public Guid? User_Id { get; set; }

///<summary>
///員工
///</summary>
public Guid? Employee_Id { get; set; }

///<summary>
///戶號
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///廠商
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///來源TableName
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源ID
///</summary>
public Guid? SourceTable_Id { get; set; }
}
}
