using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///棟別
/// </summary>
public class Building : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///棟別代號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///棟別名稱
///[varchar(100), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///門牌
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///房屋類型
///[varchar(100), nullable(True)]
///</summary>
public string HouseType { get; set; }
}
}
