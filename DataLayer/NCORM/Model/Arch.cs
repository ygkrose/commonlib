using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///棟別
/// </summary>
public class Arch : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///棟別代號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///棟別名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///型態
///[varchar(50), nullable(True)]
///</summary>
public string Code_HouseType { get; set; }

///<summary>
///地址
///[varchar(250), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
