using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票身檔關聯表
/// </summary>
public class Voucher_EntryData : TableBase
{



///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///合約編號
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }

///<summary>
///來源表(立帳單、沖帳單、收入認列、費用認列)
///[varchar(20), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///對應沖帳頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }
}
}
