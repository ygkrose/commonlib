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
///優惠方案Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CouponSetting_Id { get; set; }

///<summary>
///使用的費用項目Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///應繳金額
///[int(11), nullable(True)]
///</summary>
public Int32? Amount { get; set; }

///<summary>
///折扣後金額
///[int(11), nullable(True)]
///</summary>
public Int32? DiscountAmount { get; set; }

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
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
