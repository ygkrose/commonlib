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
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///費用項目名稱
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///特定項目(房屋租金、公證費、保證金)
///</summary>
public string ItemType { get; set; }

///<summary>
///是否補助(0:否1:是)
///</summary>
public UInt64 Subsidy { get; set; }

///<summary>
///停用日期
///</summary>
public DateTime? StopDate { get; set; }
}
}
