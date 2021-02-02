using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///廠商窗口管理
/// </summary>
public class Supplier_Contact : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Supplier_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Dept_Id { get; set; }

///<summary>
///類別default(頭檔資料用)
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code_ContactType { get; set; }

///<summary>
///部門聯絡人
///[varchar(30), nullable(True)]
///</summary>
public string DeptContactPerson { get; set; }

///<summary>
///部門聯絡電話
///[varchar(50), nullable(True)]
///</summary>
public string DeptTel { get; set; }

///<summary>
///客戶聯絡人
///[varchar(30), nullable(True)]
///</summary>
public string ContactPerson { get; set; }

///<summary>
///客戶電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///行動電話
///[varchar(20), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///客戶傳真
///[varchar(20), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///客戶EMAIL
///[varchar(120), nullable(True)]
///</summary>
public string Email { get; set; }

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
