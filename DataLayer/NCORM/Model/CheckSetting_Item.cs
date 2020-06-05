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
///</summary>
[Required]
public Guid CheckSetting_Id { get; set; }

///<summary>
///代號
///</summary>
public string Code { get; set; }

///<summary>
///項目名稱
///</summary>
public string Name { get; set; }

///<summary>
///上階代號
///</summary>
public Guid? Pid { get; set; }

///<summary>
///審查說明
///</summary>
public string Memo { get; set; }

///<summary>
///數量
///</summary>
public Int32 Qty { get; set; }

///<summary>
///是否必要(0:否1:是)
///</summary>
public UInt64 Must { get; set; }
}
}
