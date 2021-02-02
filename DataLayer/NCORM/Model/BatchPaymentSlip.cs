using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///列印繳款單
/// </summary>
public class BatchPaymentSlip : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

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
///費用年月
///[date, nullable(False)]
///</summary>
[Required]
public DateTime YearMonth { get; set; }

///<summary>
///含前期未收(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string BeforeIncluded { get; set; }

///<summary>
///費用起日起
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///費用起日訖
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///繳費期限
///[date, nullable(True)]
///</summary>
public DateTime? LimitDate { get; set; }

///<summary>
///超商代收期限
///[date, nullable(True)]
///</summary>
public DateTime? CollectDate { get; set; }

///<summary>
///社區訊息片語
///[char(36), nullable(True)]
///</summary>
public Guid? companyPhrase_Id { get; set; }

///<summary>
///繳費單備註片語
///[char(36), nullable(True)]
///</summary>
public Guid? silpPhrase_Id { get; set; }

///<summary>
///列印代號
///[char(36), nullable(True)]
///</summary>
public Guid? SlipChargeItem_Id { get; set; }

///<summary>
///合約編號
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }

///<summary>
///加密否(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string IsEncrypt { get; set; }

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
}
}
