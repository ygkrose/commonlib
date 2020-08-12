using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///廠商法人資料
/// </summary>
public class SupplierLegal : TableBase
{



///<summary>
///統一編號
///[varchar(12), nullable(False)]
///</summary>
[Required]
public string GuiNo { get; set; }

///<summary>
///法人代表人
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Representative { get; set; }

///<summary>
///登記縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? registeredRegion_Id { get; set; }

///<summary>
///登記地址
///[varchar(200), nullable(True)]
///</summary>
public string RegisteredAddr { get; set; }

///<summary>
///開業日期
///[date, nullable(True)]
///</summary>
public DateTime? OpeningDate { get; set; }

///<summary>
///資本額
///[int(11), nullable(True)]
///</summary>
public Int32? Capital { get; set; }

///<summary>
///年營業額
///[int(11), nullable(True)]
///</summary>
public Int32? AnnualTurnover { get; set; }
}
}
