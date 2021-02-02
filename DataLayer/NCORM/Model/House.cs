using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號管理
/// </summary>
public class House : TableBase
{



///<summary>
///分戶時該欄位需有值
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///棟別Id
///[char(36), nullable(True)]
///</summary>
public Guid? Arch_Id { get; set; }

///<summary>
///戶號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///戶號名稱
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///房屋類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_HouseType { get; set; }

///<summary>
///樓層
///[int(11), nullable(True)]
///</summary>
public Int32? Floor { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///使用狀況
///[varchar(20), nullable(True)]
///</summary>
public string Code_HouseUsingStatus { get; set; }

///<summary>
///房屋代理人
///[char(36), nullable(True)]
///</summary>
public Guid? agentCustomer_Id { get; set; }

///<summary>
///資產ID
///[char(36), nullable(True)]
///</summary>
public Guid? Property_Id { get; set; }

///<summary>
///專有m2
///[double, nullable(True)]
///</summary>
public Double? ProprietaryArea { get; set; }

///<summary>
///總建坪
///[double, nullable(True)]
///</summary>
public Double? BuildingAreaPing { get; set; }

///<summary>
///總建m2
///[double, nullable(True)]
///</summary>
public Double? BuildingArea { get; set; }

///<summary>
///分戶有效起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime SegmentStartDate { get; set; }

///<summary>
///分戶有效訖日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime SegmentEndDate { get; set; }

///<summary>
///權狀可租坪
///[double, nullable(True)]
///</summary>
public Double? RentableAreaPing { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///實景導覽
///[char(36), nullable(True)]
///</summary>
public Guid? panoramaFile_Id { get; set; }

///<summary>
///BIM元件
///[varchar(50), nullable(True)]
///</summary>
public string BimCode { get; set; }

///<summary>
///BIM連結網址
///[varchar(200), nullable(True)]
///</summary>
public string BimUrl { get; set; }
}
}
