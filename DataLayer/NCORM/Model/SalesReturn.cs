using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銷貨退回/折讓作業
/// </summary>
public class SalesReturn : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///日期
///[datetime, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///類別(折扣、折讓)
///[varchar(10), nullable(True)]
///</summary>
public string ReturnTerm { get; set; }

///<summary>
///指定收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///年月
///[date, nullable(True)]
///</summary>
public DateTime? YearMonth { get; set; }

///<summary>
///折讓原因
///[varchar(30), nullable(True)]
///</summary>
public string Code_ReturnReason { get; set; }

///<summary>
///折扣%
///[double, nullable(True)]
///</summary>
public Double? PayRate { get; set; }

///<summary>
///固定折扣金額
///[int(11), nullable(True)]
///</summary>
public Int32? DiscountAmount { get; set; }

///<summary>
///備註
///[varchar(200), nullable(True)]
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
