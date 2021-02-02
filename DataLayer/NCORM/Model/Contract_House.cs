using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///承租標的
/// </summary>
public class Contract_House : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Contract_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///起日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///訖日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///承租坪
///[double, nullable(True)]
///</summary>
public Double? RentAreaPing { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
