using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓物管聯絡資訊
/// </summary>
public class Building_Contact : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///職稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_BuildingContactType { get; set; }

///<summary>
///服務人員
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid WorkCode_Id { get; set; }

///<summary>
///備註
///[varchar(50), nullable(False)]
///</summary>
[Required]
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
