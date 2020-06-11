using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///家庭成員房產身檔
/// </summary>
public class GRM_Apply_MemberHouse : TableBase
{



///<summary>
///Apply_Member_Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Member_Id { get; set; }

///<summary>
///持有者
///[varchar(50), nullable(True)]
///</summary>
public string Owner { get; set; }

///<summary>
///土地/房屋 (L/H)
///[char(1), nullable(True)]
///</summary>
public string LandOrHouse { get; set; }

///<summary>
///座落縣市
///[varchar(20), nullable(True)]
///</summary>
public string Region_Id { get; set; }

///<summary>
///地段
///[varchar(50), nullable(True)]
///</summary>
public string Section { get; set; }

///<summary>
///地號
///[varchar(50), nullable(True)]
///</summary>
public string LandNo { get; set; }

///<summary>
///建物建號
///[varchar(50), nullable(True)]
///</summary>
public string BuildingNo { get; set; }

///<summary>
///總面積
///[double, nullable(True)]
///</summary>
public Double TotalArea { get; set; }

///<summary>
///持分分子
///[double, nullable(True)]
///</summary>
public Double Numerator { get; set; }

///<summary>
///持分分母
///[double, nullable(True)]
///</summary>
public Double Denominator { get; set; }

///<summary>
///持分面積
///[double, nullable(True)]
///</summary>
public Double PossessArea { get; set; }

///<summary>
///路街
///[varchar(50), nullable(True)]
///</summary>
public string Street { get; set; }

///<summary>
///地址
///[varchar(100), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///設籍否(0:否,1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 Registered { get; set; }
}
}
