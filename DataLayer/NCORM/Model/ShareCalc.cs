using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用分攤計算
/// </summary>
public class ShareCalc : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///棟別
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///分攤類別(const、flex、overtime)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string ShareType { get; set; }

///<summary>
///分攤日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///費用年月
///[date, nullable(False)]
///</summary>
[Required]
public DateTime YearMonth { get; set; }

///<summary>
///抄表起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///抄表訖日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///登錄期限
///[date, nullable(True)]
///</summary>
public DateTime? LimitedDate { get; set; }

///<summary>
///下期抄表起日
///[date, nullable(True)]
///</summary>
public DateTime? NextStartDate { get; set; }

///<summary>
///下期抄表訖日
///[date, nullable(True)]
///</summary>
public DateTime? NextEndDate { get; set; }

///<summary>
///產生銷貨單(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsSales { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

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
