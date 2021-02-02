using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///資產管理
/// </summary>
public class Property : TableBase
{



///<summary>
///不動產ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid MainProperty_Id { get; set; }

///<summary>
///代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///樓層
///[int(11), nullable(True)]
///</summary>
public Int32? Floor { get; set; }

///<summary>
///地址
///[varchar(150), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///投資/自用(Invest投資、OwnUse自用、Both投資+自用)
///[varchar(20), nullable(True)]
///</summary>
public string Code_InvestOwnUse { get; set; }

///<summary>
///特殊註記屬性(彎管戶、機械層、凶宅…)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PropertyNoteType { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
