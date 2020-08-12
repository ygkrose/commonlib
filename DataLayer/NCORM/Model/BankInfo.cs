using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///全國銀行總行及分行資料表
/// </summary>
public class BankInfo : TableBase
{



///<summary>
///總行代號
///[char(3), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///分行代號
///[char(7), nullable(True)]
///</summary>
public string BranchCode { get; set; }

///<summary>
///名稱
///[varchar(120), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///住址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///是否啟用(0:否1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Enable { get; set; }
}
}
