using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///不動產管理
/// </summary>
public class MainProperty : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓ID
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///不動產編號須唯一
///[varchar(20), nullable(True)]
///</summary>
public string PropertyNo { get; set; }

///<summary>
///不動產簡稱
///[varchar(20), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///不動產全銜
///[varchar(30), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///不動產型態(Land土地、Building建物、LandBuilding房地結合、地上權Superficies)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PropertyType { get; set; }

///<summary>
///權屬狀態(Part部份產權、Whole全部產權)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PropertyOwnership { get; set; }

///<summary>
///投資/自用(Invest投資、OwnUse自用、Both投資+自用)
///[varchar(20), nullable(True)]
///</summary>
public string Code_InvestOwnUse { get; set; }

///<summary>
///資金來源(PAR, NONPAR)
///[varchar(20), nullable(True)]
///</summary>
public string Code_FundSource { get; set; }

///<summary>
///土地使用分區(住宅區、商業區、文教區、行政區.....)
///[varchar(20), nullable(True)]
///</summary>
public string Code_LandUseType { get; set; }

///<summary>
///使用類別(辦公、住家、廠房、金融、商場、餐廳、其他)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PropertyUseType { get; set; }

///<summary>
///縣市
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///行政區
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///地號列表
///[varchar(25), nullable(True)]
///</summary>
public string LandNoList { get; set; }

///<summary>
///地址
///[varchar(150), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///交易日期
///[date, nullable(True)]
///</summary>
public DateTime? TradeDate { get; set; }

///<summary>
///取得日期
///[date, nullable(True)]
///</summary>
public DateTime? GainDate { get; set; }

///<summary>
///取得來源(Normal一般、Foreclosure法拍承受、Bidding法拍標購)
///[varchar(20), nullable(True)]
///</summary>
public string Code_GainSource { get; set; }

///<summary>
///持有樓層(文字敘述)
///[varchar(30), nullable(True)]
///</summary>
public string OwnFloor { get; set; }

///<summary>
///備註
///[varchar(30), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
