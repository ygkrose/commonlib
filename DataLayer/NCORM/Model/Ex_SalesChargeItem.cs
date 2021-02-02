using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///期初未繳明細
/// </summary>
public class Ex_SalesChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? Ex_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///費用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///費用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
