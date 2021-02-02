using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///客戶
/// </summary>
public class Customer : TableBase
{



///<summary>
///客戶編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///自然人/法人
///[varchar(10), nullable(True)]
///</summary>
public string Person { get; set; }

///<summary>
///簡稱
///[varchar(20), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///全銜
///[varchar(80), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///印表顯示名稱
///[varchar(80), nullable(True)]
///</summary>
public string ShowName { get; set; }

///<summary>
///所屬公司ID，用於篩選
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
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

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///身分證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///性別(F:女M:男)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///國籍
///[varchar(10), nullable(True)]
///</summary>
public string Nationality { get; set; }

///<summary>
///退款手續費負擔方(客戶/公司)
///[varchar(8), nullable(True)]
///</summary>
public string Code_FeeBelong { get; set; }

///<summary>
///愛心捐贈碼
///[char(36), nullable(True)]
///</summary>
public Guid? DondateCode_Id { get; set; }

///<summary>
///載具類別
///[varchar(30), nullable(True)]
///</summary>
public string Code_CarrierType { get; set; }

///<summary>
///載具編號
///[varchar(50), nullable(True)]
///</summary>
public string CarrierNo { get; set; }

///<summary>
///公司負責人
///[varchar(30), nullable(True)]
///</summary>
public string Chief { get; set; }

///<summary>
///行業別
///[varchar(30), nullable(True)]
///</summary>
public string Industry { get; set; }

///<summary>
///發票上傳方式(noinvoice不開發票noexchage憑證exchage交換)
///[varchar(30), nullable(True)]
///</summary>
public string Code_InvoiceUpload { get; set; }

///<summary>
///發票抬頭
///[varchar(30), nullable(True)]
///</summary>
public string InvoiceHead { get; set; }

///<summary>
///發票合併開立(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string OneInvoice { get; set; }
}
}
