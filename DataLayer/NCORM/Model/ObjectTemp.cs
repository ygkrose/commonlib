using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///申請物件
/// </summary>
public class ObjectTemp : TableBase
{


///<summary>
///申請物件編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///門牌縣市行政區
///</summary>
[Required]
public Guid HouseRegion_Id { get; set; }

///<summary>
///路街
///</summary>
[Required]
public string Street { get; set; }

///<summary>
///地址
///</summary>
[Required]
public string Addr { get; set; }

///<summary>
///經度
///</summary>
[Required]
public Decimal Longitude { get; set; }

///<summary>
///緯度
///</summary>
[Required]
public Decimal Latitude { get; set; }

///<summary>
///建物縣市行政區
///</summary>
public Int32 BuildingRegion_Id { get; set; }

///<summary>
///地段
///</summary>
public string LandSection { get; set; }

///<summary>
///地號
///</summary>
public string LandNo { get; set; }

///<summary>
///建號
///</summary>
public string BuildingNo { get; set; }

///<summary>
///房屋稅籍編號
///</summary>
public string HouseTaxIdNo { get; set; }

///<summary>
///土地稅籍編號
///</summary>
public string LandTaxIdNo { get; set; }

///<summary>
///建物型態
///</summary>
public string BuildingType { get; set; }

///<summary>
///其他建物型態
///</summary>
public string OtherBuildingType { get; set; }

///<summary>
///建物完成日
///</summary>
public DateTime? BuildingDate { get; set; }

///<summary>
///座落樓層
///</summary>
public Boolean Floor { get; set; }

///<summary>
///總樓層
///</summary>
public Boolean TotalFloor { get; set; }

///<summary>
///格局
///</summary>
public string Pattern { get; set; }

///<summary>
///隔間_房
///</summary>
public Boolean Bedroom { get; set; }

///<summary>
///隔間_廳
///</summary>
public Boolean LivingRoom { get; set; }

///<summary>
///隔間_衛
///</summary>
public Boolean Bathroom { get; set; }

///<summary>
///隔間材質
///</summary>
public string CompartmentMaterial { get; set; }

///<summary>
///謄本面積m2
///</summary>
public Double RegisteredArea { get; set; }

///<summary>
///謄本面積坪
///</summary>
public Double RegisteredAreaPing { get; set; }

///<summary>
///實際使用m2
///</summary>
public Double UsingArea { get; set; }

///<summary>
///實際使用坪
///</summary>
public Double UsingAreaPing { get; set; }

///<summary>
///所屬大樓
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///建物主要用途
///</summary>
public string BuildingUsage { get; set; }

///<summary>
///建材
///</summary>
public string BuildingMaterial { get; set; }

///<summary>
///所有權人
///</summary>
public Guid? OwnerApply_Id { get; set; }

///<summary>
///A包租包管、B代租代管、C二者
///</summary>
public string Plan { get; set; }

///<summary>
///賦稅減免(0:否1:是)
///</summary>
public UInt64 IsTaxCutAgree { get; set; }

///<summary>
///1.自用 2.空屋 3.出租
///</summary>
public string UsingStatus { get; set; }

///<summary>
///委託時承租人
///</summary>
public string Rentor { get; set; }

///<summary>
///租期終止日
///</summary>
public DateTime? RentEndDate { get; set; }

///<summary>
///租金計算方式(依評定表計算、手動輸入市場租金)
///</summary>
public string EvaluateType { get; set; }

///<summary>
///市場租金
///</summary>
public Int32 MarketRent { get; set; }

///<summary>
///所在地租金上限
///</summary>
public Int32 MaxRent { get; set; }

///<summary>
///房東自願降價(0:否1:是)
///</summary>
public UInt64 IsReduceAgree { get; set; }

///<summary>
///待租租金
///</summary>
public Int32 ExpectedRent { get; set; }

///<summary>
///包租包管簽約租金
///</summary>
public Int32 RentA { get; set; }

///<summary>
///代租代管簽約租金
///</summary>
public Int32 RentB { get; set; }

///<summary>
///保證金月數
///</summary>
public Boolean DepositMonth { get; set; }

///<summary>
///保證金金額
///</summary>
public Int32 Deposit { get; set; }

///<summary>
///每月管理費金額
///</summary>
public Int32 MonthlyMgtFee { get; set; }

///<summary>
///每坪管理費金額
///</summary>
public Int32 MgtFeePerPing { get; set; }

///<summary>
///可否議價(0:否1:是)
///</summary>
public UInt64 IsBargainable { get; set; }

///<summary>
///含管理費(0:否1:是)
///</summary>
public UInt64 InclMgtFee { get; set; }

///<summary>
///含電費(0:否1:是)
///</summary>
public UInt64 InclElectricityFee { get; set; }

///<summary>
///含水費(0:否1:是)
///</summary>
public UInt64 InclWaterFee { get; set; }

///<summary>
///含瓦斯(0:否1:是)
///</summary>
public UInt64 InclGasFee { get; set; }

///<summary>
///含第四台(0:否1:是)
///</summary>
public UInt64 InclCatvFee { get; set; }

///<summary>
///含網路(0:否1:是)
///</summary>
public UInt64 InclInternetFee { get; set; }

///<summary>
///含車位(0:否1:是)
///</summary>
public UInt64 InclParkingFee { get; set; }

///<summary>
///含清潔費(0:否1:是)
///</summary>
public UInt64 InclCleaningFee { get; set; }

///<summary>
///可否炊煮(0:否1:是)
///</summary>
public UInt64 IsCookAllowed { get; set; }

///<summary>
///有無障礙設施(0:否1:是)
///</summary>
public UInt64 IsBarrierFree { get; set; }

///<summary>
///門禁管理方式(管理員、刷卡門禁、其他)
///</summary>
public string AccessControl { get; set; }

///<summary>
///其他門禁管理方式
///</summary>
public string OtherAccessControl { get; set; }

///<summary>
///估價師簽註日期
///</summary>
public DateTime? SignDate { get; set; }

///<summary>
///簽註意見
///</summary>
public string Opinion { get; set; }

///<summary>
///評定理由
///</summary>
public string Reason { get; set; }
}
}
