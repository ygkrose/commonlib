using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///廠商管理
/// </summary>
public class Supplier : TableBase
{



///<summary>
///交易編號
///[varchar(20), nullable(True)]
///</summary>
public string AccountNo { get; set; }

///<summary>
///廠商編號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///簡稱
///[varchar(8), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///全銜
///[varchar(50), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///自然人/法人
///[varchar(10), nullable(True)]
///</summary>
public string Person { get; set; }

///<summary>
///廠商類別
///[varchar(30), nullable(True)]
///</summary>
public string Code_SupplierType { get; set; }

///<summary>
///匯款手續費負擔(廠商/公司)
///[varchar(30), nullable(True)]
///</summary>
public string Code_FeeBelong { get; set; }

///<summary>
///權限類別(1:財務用、0:櫃台用)
///[char(1), nullable(True)]
///</summary>
public string IsFinancial { get; set; }

///<summary>
///縣市ID
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///聯絡人
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///聯絡電話
///[varchar(20), nullable(True)]
///</summary>
public string ContactTel { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(False)]
///</summary>
[Required]
public string GuiNo { get; set; }

///<summary>
///手機
///[varchar(20), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///付款月數
///[varchar(20), nullable(True)]
///</summary>
public string PayMonth { get; set; }

///<summary>
///所屬公司ID，用於篩選
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///匯款手續費負擔(廠商、公司)
///[varchar(10), nullable(True)]
///</summary>
public string FeeBelong { get; set; }

///<summary>
///LOGO上傳
///[char(36), nullable(True)]
///</summary>
public Guid? logoFile_Id { get; set; }

///<summary>
///網址
///[varchar(200), nullable(True)]
///</summary>
public string Url { get; set; }

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

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///身分證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///公司負責人
///[varchar(30), nullable(True)]
///</summary>
public string Chief { get; set; }

///<summary>
///免扣補充保費(0:否 1:是)
///[char(1), nullable(True)]
///</summary>
public string NoInsuranceFee { get; set; }

///<summary>
///關係企業(0:否 1:是)
///[char(1), nullable(True)]
///</summary>
public string Affiliated { get; set; }

///<summary>
///停止配合日期
///[date, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///停止原因說明
///[varchar(150), nullable(True)]
///</summary>
public string StopReason { get; set; }

///<summary>
///勞安組織設置核准文
///[varchar(50), nullable(True)]
///</summary>
public string LaborSafetyCode { get; set; }
}
}
