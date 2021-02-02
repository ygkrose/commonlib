using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查結果
/// </summary>
public class CheckRecord : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///年月
///[date, nullable(False)]
///</summary>
[Required]
public DateTime YearMonth { get; set; }

///<summary>
///檢查設定ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckSetting_Id { get; set; }

///<summary>
///應檢日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime ExpectedCheckDate { get; set; }

///<summary>
///實檢日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime CheckDate { get; set; }

///<summary>
///委外(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OutSource { get; set; }

///<summary>
///檢查廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///檢查表上傳
///[char(36), nullable(True)]
///</summary>
public Guid? checklistFile_Id { get; set; }

///<summary>
///檢查圖檔上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }

///<summary>
///檢查說明
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
