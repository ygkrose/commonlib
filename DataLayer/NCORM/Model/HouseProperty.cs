using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號屬性管理
/// </summary>
public class HouseProperty : TableBase
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
public string Code { get; set; }

///<summary>
///屬性名稱
///[varchar(80), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///屬性值
///[smallint(6), nullable(True)]
///</summary>
public Int16 PropertyValue { get; set; }
}
}
