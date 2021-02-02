using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///證照類別管理
/// </summary>
public class LicenseType : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///證照屬性(Company公司設立證照,CompanyPro公司技術證照,Supplier廠商公司設立證照,SupplierPro廠商技術證照)
///[varchar(20), nullable(True)]
///</summary>
public string Code_LicenseType { get; set; }

///<summary>
///證照類別
///[varchar(20), nullable(True)]
///</summary>
public string LicenseName { get; set; }

///<summary>
///規定數量
///[int(11), nullable(True)]
///</summary>
public Int32? QualifiedQty { get; set; }

///<summary>
///可執行案場數
///[int(11), nullable(True)]
///</summary>
public Int32? UsingQty { get; set; }

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
