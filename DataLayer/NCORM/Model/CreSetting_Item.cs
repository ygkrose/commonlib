using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///服務項目明細
/// </summary>
public class CreSetting_Item : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmSetting_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///設定名稱
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///說明
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///停用(0:否1:是)
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
}
}
