using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號屬性管理
/// </summary>
public class House_Feature : TableBase
{



///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///戶號屬性類別
///[varchar(25), nullable(False)]
///</summary>
[Required]
public string Code_HouseFeature { get; set; }

///<summary>
///屬性名稱
///[varchar(80), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///屬性值
///[varchar(50), nullable(True)]
///</summary>
public string PropertyValue { get; set; }

///<summary>
///描述
///[varchar(20), nullable(True)]
///</summary>
public string Description { get; set; }
}
}
