using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查文件設定頭檔
/// </summary>
public class CheckSetting : TableBase
{



///<summary>
///檢查類別代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///檢查類別名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

public Guid? Org_Id { get; set; }
}
}
