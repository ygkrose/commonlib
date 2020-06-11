using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓關聯表
/// </summary>
public class CompanyCommunity : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓類型
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string CommunityType { get; set; }

///<summary>
///總戶數
///[smallint(6), nullable(False)]
///</summary>
[Required]
public Int16 HouseQty { get; set; }

///<summary>
///總車位數
///[smallint(6), nullable(True)]
///</summary>
public Int16 CarQty { get; set; }

///<summary>
///地上樓層數
///[smallint(6), nullable(True)]
///</summary>
public Int16 GroundFloor { get; set; }

///<summary>
///地下樓層數
///[smallint(6), nullable(True)]
///</summary>
public Int16 BasementFloor { get; set; }

///<summary>
///車道類型
///[varchar(20), nullable(True)]
///</summary>
public string Lane { get; set; }

///<summary>
///使用執照年月
///[date, nullable(True)]
///</summary>
public DateTime? LicenseDate { get; set; }

///<summary>
///門禁類型
///[varchar(30), nullable(True)]
///</summary>
public string AccessControl { get; set; }

///<summary>
///管轄分局
///[varchar(30), nullable(True)]
///</summary>
public string PoliceStation { get; set; }

///<summary>
///瓦斯公司
///[char(36), nullable(True)]
///</summary>
public Guid? gasCompany_Id { get; set; }

///<summary>
///備註
///[varchar(300), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
