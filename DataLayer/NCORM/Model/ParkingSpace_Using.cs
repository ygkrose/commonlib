using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///車位使用明細
/// </summary>
public class ParkingSpace_Using : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ParkingSpace_Id { get; set; }

///<summary>
///使用者Id
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///使用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///使用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///車牌號碼
///[varchar(10), nullable(True)]
///</summary>
public string Plate { get; set; }

///<summary>
///停車證號碼
///[varchar(10), nullable(True)]
///</summary>
public string ParkingLicenseNo { get; set; }

///<summary>
///遙控器號碼
///[varchar(20), nullable(True)]
///</summary>
public string RemoteControlNo { get; set; }

///<summary>
///車型
///[varchar(10), nullable(True)]
///</summary>
public string CarTerm { get; set; }

///<summary>
///顏色
///[varchar(10), nullable(True)]
///</summary>
public string CarColor { get; set; }

///<summary>
///廠牌
///[varchar(20), nullable(True)]
///</summary>
public string CarBrand { get; set; }

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
