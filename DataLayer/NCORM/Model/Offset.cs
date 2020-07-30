using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///立帳單號資料
/// </summary>
public class Offset : TableBase
{



///<summary>
///未稅金額
///[double, nullable(False)]
///</summary>
[Required]
public Double UntaxedAmount { get; set; }

///<summary>
///稅金
///[double, nullable(True)]
///</summary>
public Double TaxAmount { get; set; }

///<summary>
///課稅別
///[varchar(10), nullable(True)]
///</summary>
public string TaxType { get; set; }

///<summary>
///費用年月
///[date, nullable(True)]
///</summary>
public DateTime? YearMonth { get; set; }

///<summary>
///費用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///費用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///合約編號
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///印單備註
///[varchar(100), nullable(True)]
///</summary>
public string SlipMemo { get; set; }

///<summary>
///稅傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? tTransCode_Id { get; set; }

///<summary>
///貸方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? cTransCode_Id { get; set; }

///<summary>
///借方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? dTransCode_Id { get; set; }

///<summary>
///收費項目ID
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }
}
}
