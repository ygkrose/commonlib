using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///會計科目管理
/// </summary>
public class Accounting : TableBase
{



///<summary>
///公司Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///科目編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///科目名稱
///[varchar(100), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///上階科目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Pid { get; set; }

///<summary>
///彙總科目(0:否1:是)
///[bit(1), nullable(False)]
///</summary>
[Required]
public UInt64 IsSum { get; set; }

///<summary>
///借貸別(D:Debit C:Credit)
///[char(1), nullable(False)]
///</summary>
[Required]
public string DC { get; set; }

///<summary>
///停用(0:否1:是)
///[bit(1), nullable(False)]
///</summary>
[Required]
public UInt64 IsStop { get; set; }
}
}
