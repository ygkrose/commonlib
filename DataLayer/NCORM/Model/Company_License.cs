using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公司證號管理
/// </summary>
public class Company_License : TableBase
{



///<summary>
///公司Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///證照類別ID(防火證照、設備證照、事務證照...)
///[char(36), nullable(True)]
///</summary>
public Guid? LicenseType_Id { get; set; }

///<summary>
///證號號碼
///[varchar(50), nullable(True)]
///</summary>
public string LicenseCode { get; set; }

///<summary>
///有效起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///有效訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///檔案上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }

///<summary>
///備註
///[varchar(120), nullable(True)]
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
///服務人員
///[char(36), nullable(True)]
///</summary>
public Guid? WorkCode_Id { get; set; }
}
}
