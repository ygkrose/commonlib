using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓屬性
/// </summary>
public class Building_Feature : TableBase
{



///<summary>
///大樓ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///屬性類別(水塔數,電梯數,管轄分局...)
///[varchar(30), nullable(True)]
///</summary>
public string Code_BuildingFeature { get; set; }

///<summary>
///描述
///[varchar(100), nullable(True)]
///</summary>
public string Description { get; set; }

///<summary>
///使用限制
///[varchar(100), nullable(True)]
///</summary>
public string LimitMemo { get; set; }

///<summary>
///數量
///[int(11), nullable(True)]
///</summary>
public Int32? Qty { get; set; }
}
}
