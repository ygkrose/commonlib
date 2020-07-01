using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號面積管理
/// </summary>
public class HouseArea : TableBase
{



///<summary>
///總地m2
///[double, nullable(True)]
///</summary>
public Double LandArea { get; set; }

///<summary>
///總地坪
///[double, nullable(True)]
///</summary>
public Double LandAreaPing { get; set; }

///<summary>
///總建m2
///[double, nullable(True)]
///</summary>
public Double BuildingArea { get; set; }

///<summary>
///總建坪
///[double, nullable(True)]
///</summary>
public Double BuildingAreaPing { get; set; }

///<summary>
///專有m2
///[double, nullable(True)]
///</summary>
public Double ProprietaryArea { get; set; }

///<summary>
///主建物m2
///[double, nullable(True)]
///</summary>
public Double MainBuildingArea { get; set; }

///<summary>
///附屬建物m2
///[double, nullable(True)]
///</summary>
public Double SubBuildingArea { get; set; }

///<summary>
///車位m2
///[double, nullable(True)]
///</summary>
public Double ParkingSpaceArea { get; set; }

///<summary>
///出租坪
///[double, nullable(True)]
///</summary>
public Double RentAreaPing { get; set; }

///<summary>
///公設比
///[double, nullable(True)]
///</summary>
public Double PublicAreaRatio { get; set; }
}
}
