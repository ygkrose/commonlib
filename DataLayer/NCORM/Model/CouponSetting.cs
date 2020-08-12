using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///優惠券設定
/// </summary>
public class CouponSetting : TableBase
{



///<summary>
///優惠方案名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

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
///折扣金額
///[int(11), nullable(True)]
///</summary>
public Int32? Discount { get; set; }

///<summary>
///優惠繳費%
///[float, nullable(True)]
///</summary>
public Single? PayRate { get; set; }

///<summary>
///繳費月數
///[int(11), nullable(True)]
///</summary>
public Int32? MonthQty { get; set; }

///<summary>
///有效起日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///有效訖日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///不與其他優惠券共用(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsUnique { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///新增人員Id
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///類別(早繳.年繳.會議.空屋.委員.其他)
///[varchar(30), nullable(True)]
///</summary>
public string CouponTerm { get; set; }
}
}
