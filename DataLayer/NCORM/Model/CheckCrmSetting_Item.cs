using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查維修設定項目明細
/// </summary>
public class CheckCrmSetting_Item : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckCrmSetting_Id { get; set; }

///<summary>
///上階ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Pid { get; set; }

///<summary>
///順序
///[varchar(4), nullable(False)]
///</summary>
[Required]
public string Ord { get; set; }

///<summary>
///代號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///項目名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///標準值
///[varchar(20), nullable(True)]
///</summary>
public string StandardValue { get; set; }

///<summary>
///1:必要/0:非必要
///[char(1), nullable(True)]
///</summary>
public string Must { get; set; }

///<summary>
///數量
///[int(10) unsigned zerofill, nullable(True)]
///</summary>
public UInt32? Qty { get; set; }

///<summary>
///審查說明
///[varchar(250), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///停用(0:否 1:是)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }

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
