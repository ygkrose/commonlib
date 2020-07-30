using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///會計科目類別
/// </summary>
public class AccountingTerm : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///類別代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///類別名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///上階類別
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///借/貸
///[char(1), nullable(True)]
///</summary>
public string DC { get; set; }
}
}
