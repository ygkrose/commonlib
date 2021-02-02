using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///客戶地址管理
/// </summary>
public class Customer_Addr : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Customer_Id { get; set; }

///<summary>
///類別(contact聯絡.household戶籍.invoice發票.payment請款.register登記)
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code_AddrType { get; set; }

///<summary>
///縣市ID
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///郵遞區號
///[varchar(10), nullable(True)]
///</summary>
public string ZipCode { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///合約備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
