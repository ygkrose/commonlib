using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用項目
/// </summary>
public class ChargeItem : TableBase
{



///<summary>
///費用項目代號
///[varchar(25), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///費用項目名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///項目類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_Item { get; set; }

///<summary>
///是否補助(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 Subsidy { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///特定項目
///[varchar(20), nullable(True)]
///</summary>
public string Code_SpecialItem { get; set; }

///<summary>
///代扣稅率
///[float, nullable(True)]
///</summary>
public Single WithholdTaxRate { get; set; }

///<summary>
///稅率
///[float, nullable(True)]
///</summary>
public Single TaxRate { get; set; }

///<summary>
///課稅別
///[varchar(20), nullable(True)]
///</summary>
public string TaxType { get; set; }

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

///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }
}
}
