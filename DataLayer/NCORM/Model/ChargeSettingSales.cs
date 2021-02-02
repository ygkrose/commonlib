using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///產生下期收費(暫時不會用)
/// </summary>
public class ChargeSettingSales : TableBase
{



///<summary>
///公司
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///日期
///[datetime, nullable(True)]
///</summary>
public DateTime? SalesDate { get; set; }

///<summary>
///帳款年月
///[date, nullable(True)]
///</summary>
public DateTime? YearMonth { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

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
}
}
