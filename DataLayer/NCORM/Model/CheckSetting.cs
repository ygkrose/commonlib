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
///公司
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///檢查類別(Facility定期檢查,Maintain設備保養,Regulation公司規範)
///[varchar(30), nullable(True)]
///</summary>
public string Code_CheckType { get; set; }

///<summary>
///生效日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///集團
///[char(36), nullable(True)]
///</summary>
public Guid? Group_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///檢查廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///操作文件
///[char(36), nullable(True)]
///</summary>
public Guid? OperatingDoc_Id { get; set; }

///<summary>
///資料維護部門
///[char(36), nullable(True)]
///</summary>
public Guid? maintainDept_Id { get; set; }

///<summary>
///平面圖
///[char(36), nullable(True)]
///</summary>
public Guid? planFileUploadMap_Id { get; set; }

///<summary>
///實景導覽
///[char(36), nullable(True)]
///</summary>
public Guid? panoramaFile_Id { get; set; }

///<summary>
///通知群組
///[char(36), nullable(True)]
///</summary>
public Guid? NoticeGroup_Id { get; set; }

///<summary>
///委外(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OutSource { get; set; }

///<summary>
///BIM元件
///[varchar(250), nullable(True)]
///</summary>
public string BimUrl { get; set; }

///<summary>
///連結網址
///[varchar(250), nullable(True)]
///</summary>
public string Urlv { get; set; }

///<summary>
///指定檢查日
///[date, nullable(True)]
///</summary>
public DateTime? CheckDay { get; set; }

///<summary>
///檢查週期
///[char(1), nullable(True)]
///</summary>
public string Period { get; set; }

///<summary>
///檢查起始月份
///[char(1), nullable(True)]
///</summary>
public string CheckMonth { get; set; }

///<summary>
///置頂(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OnTop { get; set; }

///<summary>
///不顯示(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsHidden { get; set; }

///<summary>
///順序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///注意事項
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
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
