using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓營建資料關聯表
/// </summary>
public class BuildingConstruction : TableBase
{



///<summary>
///基地面積
///[double, nullable(True)]
///</summary>
public Double? BaseArea { get; set; }

///<summary>
///樓地板面積
///[double, nullable(True)]
///</summary>
public Double? FloorArea { get; set; }

///<summary>
///地上樓層
///[int(11), nullable(True)]
///</summary>
public Int32? AbovegroundFloor { get; set; }

///<summary>
///地下樓層
///[int(11), nullable(True)]
///</summary>
public Int32? UndergroundFloor { get; set; }

///<summary>
///總建平方公尺
///[double, nullable(True)]
///</summary>
public Double? BuildArea { get; set; }

///<summary>
///總地平方公尺
///[double, nullable(True)]
///</summary>
public Double? LandArea { get; set; }

///<summary>
///總汽車位平方公尺
///[double, nullable(True)]
///</summary>
public Double? CarParkingSpaceArea { get; set; }

///<summary>
///總汽車位數
///[int(11), nullable(True)]
///</summary>
public Int32? CarParkingSpaceQty { get; set; }

///<summary>
///總機車位平方公尺
///[double, nullable(True)]
///</summary>
public Double? ScooterParkingSpaceArea { get; set; }

///<summary>
///總機車位數
///[int(11), nullable(True)]
///</summary>
public Int32? ScooterParkingSpaceQty { get; set; }

///<summary>
///總公設平方公尺
///[double, nullable(True)]
///</summary>
public Double? PublicArea { get; set; }

///<summary>
///公設比%
///[double, nullable(True)]
///</summary>
public Double? PublicRatio { get; set; }

///<summary>
///游泳池數
///[int(11), nullable(True)]
///</summary>
public Int32? SwimmingPoolQty { get; set; }

///<summary>
///建築結構
///[varchar(20), nullable(True)]
///</summary>
public string Code_BuildingStructure { get; set; }

///<summary>
///竣工日期
///[date, nullable(True)]
///</summary>
public DateTime? ConpletionDate { get; set; }

///<summary>
///使用執照號碼
///[varchar(20), nullable(True)]
///</summary>
public string UseLicenseCode { get; set; }

///<summary>
///使照用途
///[varchar(20), nullable(True)]
///</summary>
public string UseLicenseUsage { get; set; }

///<summary>
///使照核發日期
///[date, nullable(True)]
///</summary>
public DateTime? UseLicenseDate { get; set; }

///<summary>
///起造人
///[varchar(15), nullable(True)]
///</summary>
public string Applicant { get; set; }

///<summary>
///營造廠
///[varchar(20), nullable(True)]
///</summary>
public string Constructer { get; set; }

///<summary>
///設計人
///[varchar(15), nullable(True)]
///</summary>
public string Designer { get; set; }

///<summary>
///事務所
///[varchar(15), nullable(True)]
///</summary>
public string DesignOffice { get; set; }

///<summary>
///房屋每坪租金
///[int(11), nullable(True)]
///</summary>
public Int32? HouseRentPricePerPing { get; set; }

///<summary>
///車位每位租金
///[int(11), nullable(True)]
///</summary>
public Int32? ParkingSpaceRentPrice { get; set; }

///<summary>
///每坪管理費
///[int(11), nullable(True)]
///</summary>
public Int32? ManagementFeePerPing { get; set; }

///<summary>
///建造執照號碼
///[varchar(20), nullable(True)]
///</summary>
public string BuildLicenseCode { get; set; }

///<summary>
///標準樓板高度
///[varchar(10), nullable(True)]
///</summary>
public string StandardFloorHeight { get; set; }

///<summary>
///一樓樓板高度
///[varchar(10), nullable(True)]
///</summary>
public string GroundFloorHeight { get; set; }
}
}
