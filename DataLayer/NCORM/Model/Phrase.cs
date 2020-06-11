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
///片語類別(訊息通知、通知單、收據備註.....)
///[varchar(20), nullable(True)]
///</summary>
public string PhraseType { get; set; }
}
}
