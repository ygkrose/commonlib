using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///片語設定
/// </summary>
public class Phrase : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///片語代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///片語標題
///[varchar(20), nullable(True)]
///</summary>
public string Title { get; set; }

///<summary>
///內容
///[varchar(50), nullable(True)]
///</summary>
public string Content { get; set; }

///<summary>
///片語類別(戶號訪客備註、戶號信件備註、訊息通知、通知單、收據備註....)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PhraseType { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

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
