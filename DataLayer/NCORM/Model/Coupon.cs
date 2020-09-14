using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///優惠券歸屬紀錄
/// </summary>
public class Coupon : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///優惠方案Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CouponSetting_Id { get; set; }

///<summary>
///金額
///[int(11), nullable(True)]
///</summary>
public Int32? Amount { get; set; }

///<summary>
///有效起日
///[datetime, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///有效訖日
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///不與其他優惠券共用(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string IsUnique { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }

///<summary>
///預繳產生(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string IsAdvanced { get; set; }
}
}
