using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用分攤抄表明細
/// </summary>
public class ShareCalc_ShareSetting_List : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareCalc_ShareSetting_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///抄表度數
///[double, nullable(False)]
///</summary>
[Required]
public Double? MeterDegree { get; set; }

///<summary>
///本期使用度數
///[double, nullable(False)]
///</summary>
[Required]
public Double? ChargeDegree { get; set; }

///<summary>
///拍照圖檔
///[double, nullable(True)]
///</summary>
public Double? uploadFile_Id { get; set; }

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
