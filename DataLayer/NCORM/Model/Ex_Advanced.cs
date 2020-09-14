using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///期初預收保證金轉入
/// </summary>
public class Ex_Advanced : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Ex_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///指定收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double? Amount { get; set; }
}
}
