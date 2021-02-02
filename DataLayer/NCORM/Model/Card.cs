using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///門禁卡管理
/// </summary>
public class Card : TableBase
{



///<summary>
///卡片編號
///[varchar(15), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///卡片型式
///[varchar(20), nullable(True)]
///</summary>
public string Code_CardForm { get; set; }

///<summary>
///使用類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_CardUsage { get; set; }

///<summary>
///卡片類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_CardType { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///使用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///使用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///執行停用時間
///[date, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///執行停用人員
///[date, nullable(True)]
///</summary>
public DateTime? stopUser_Id { get; set; }

///<summary>
///備註
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }

///<summary>
///組織ID
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }
}
}
