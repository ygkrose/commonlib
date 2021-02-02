using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///物業服務人員管理
/// </summary>
public class WorkCode : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///服務人員編號(全系統須唯一)
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///部門ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Dept_Id { get; set; }

///<summary>
///員工ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Employee_Id { get; set; }

///<summary>
///廠商ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Supplier_Id { get; set; }

///<summary>
///啟用日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///職稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_JobTitle { get; set; }

///<summary>
///休假類別設定ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid OffDutySetting_Id { get; set; }

///<summary>
///電話
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Tel { get; set; }

///<summary>
///分機
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string Ext { get; set; }

///<summary>
///手機
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Mobile { get; set; }

///<summary>
///地址
///[varchar(150), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///性別(F:女M:男)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///身份證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///緊急連絡人
///[varchar(10), nullable(True)]
///</summary>
public string EmerContact { get; set; }

///<summary>
///緊急連絡人關係
///[varchar(10), nullable(True)]
///</summary>
public string EmerRelationship { get; set; }

///<summary>
///緊急連絡人電話
///[varchar(20), nullable(True)]
///</summary>
public string EmerTel { get; set; }

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
