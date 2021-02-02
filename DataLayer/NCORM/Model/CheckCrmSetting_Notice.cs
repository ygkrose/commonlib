using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修項目設定通知內容明細
/// </summary>
public class CheckCrmSetting_Notice : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckCrmSetting_Id { get; set; }

///<summary>
///通知方式(email,push,sms)
///[varchar(20), nullable(True)]
///</summary>
public string Code_NoticeMethod { get; set; }

///<summary>
///內容
///[varchar(200), nullable(True)]
///</summary>
public string Content { get; set; }

///<summary>
///通知對象類別(客戶、廠商、管理中心)
///[varchar(20), nullable(True)]
///</summary>
public string Code_NoticeClass { get; set; }
}
}
