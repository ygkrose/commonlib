using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號屬性管理
/// </summary>
public class House_Property : TableBase
{



///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///屬性代碼
///[varchar(25), nullable(False)]
///</summary>
[Required]
public string Code_HouseProperty { get; set; }

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
}
}
