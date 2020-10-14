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

///<summary>
///組織Id
///[char(36), nullable(True)]
///</summary>
public Guid? Org_Id { get; set; }

///<summary>
///檢查類別(Facility設備巡檢,Guideline工作準則, Sop -SOP文件)
///[varchar(20), nullable(True)]
///</summary>
public string CheckType { get; set; }
}
}
