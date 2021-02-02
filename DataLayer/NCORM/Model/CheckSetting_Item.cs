using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查文件設定身檔
/// </summary>
public class CheckSetting_Item : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckSetting_Id { get; set; }

///<summary>
///檢查項目ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckCrmSetting_Item_Id { get; set; }

///<summary>
///代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///審查說明
///[text, nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///數量
///[int(11), nullable(True)]
///</summary>
public Int32? Qty { get; set; }

///<summary>
///是否必要(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Must { get; set; }

///<summary>
///停用(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }

///<summary>
///起始日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///標準值
///[varchar(10), nullable(True)]
///</summary>
public string StandardValue { get; set; }
}
}
