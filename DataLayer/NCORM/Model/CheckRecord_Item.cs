using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查結果項目明細
/// </summary>
public class CheckRecord_Item : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckRecord_Id { get; set; }

///<summary>
///順序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///檢查項目ID
///[char(36), nullable(True)]
///</summary>
public Guid? CheckSetting_Item_Id { get; set; }

///<summary>
///標準值
///[varchar(10), nullable(True)]
///</summary>
public string StandardValue { get; set; }

///<summary>
///檢查值
///[varchar(10), nullable(True)]
///</summary>
public string CheckValue { get; set; }

///<summary>
///必檢查(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string Must { get; set; }

///<summary>
///合格(1:是0:否)
///[char(1), nullable(True)]
///</summary>
public string Qualify { get; set; }

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
