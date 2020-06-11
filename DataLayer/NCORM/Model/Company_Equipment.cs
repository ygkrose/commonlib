using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓設備
/// </summary>
public class Company_Equipment : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///排序
///[varchar(5), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///設備名稱
///[varchar(100), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///數量
///[smallint(4), nullable(True)]
///</summary>
public Int16 Qty { get; set; }
}
}
