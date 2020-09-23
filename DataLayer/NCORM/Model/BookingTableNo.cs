using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///桌號管理
/// </summary>
public class BookingTableNo : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///代號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
