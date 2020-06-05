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
///</summary>
public string Code { get; set; }

///<summary>
///檢查類別名稱
///</summary>
public string Name { get; set; }

///<summary>
///專案期數編號
///</summary>
public Guid? ProjectPeriod_Id { get; set; }
}
}
