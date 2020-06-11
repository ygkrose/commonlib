using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查文件設定身檔
/// </summary>
public class CheckSettingItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckSetting_Id { get; set; }

///<summary>
///代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///項目名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///上階代號
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///審查說明
///[text, nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///數量
///[int(11), nullable(True)]
///</summary>
public Int32 Qty { get; set; }

///<summary>
///是否必要(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 Must { get; set; }
}
}
