using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///定期檢查設定通知群組
/// </summary>
public class CheckSetting_NoticeGroup : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckSetting_Id { get; set; }

///<summary>
///通知對象類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_NoticeClass { get; set; }

///<summary>
///組別
///[char(36), nullable(True)]
///</summary>
public Guid? Role_Id { get; set; }

///<summary>
///帳號
///[char(36), nullable(True)]
///</summary>
public Guid? User_Id { get; set; }

///<summary>
///客戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///服務人員ID
///[char(36), nullable(True)]
///</summary>
public Guid? WorkCode_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }
}
}
