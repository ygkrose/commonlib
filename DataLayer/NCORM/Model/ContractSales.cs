using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///產生合約收費
/// </summary>
public class ContractSales : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime SalesDate { get; set; }

///<summary>
///收費起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///收費訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///簽約發票稅籍
///[char(36), nullable(True)]
///</summary>
public Guid? InvoiceUnit_Id { get; set; }

///<summary>
///合約類別
///[varchar(20), nullable(True)]
///</summary>
public string ContractType { get; set; }

///<summary>
///作業單位
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///客戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Customer_Id { get; set; }

///<summary>
///合約編號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Contract_Id { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

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
}
}
