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
///特定項目(房屋租金、公證費、保證金)
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
}
}
