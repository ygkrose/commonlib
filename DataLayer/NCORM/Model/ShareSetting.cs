using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///分攤表設定
/// </summary>
public class ShareSetting : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///分攤名稱
///[varchar(100), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///表號
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string MeterNo { get; set; }

///<summary>
///分攤類別(const、flex、overtime)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string ShareType { get; set; }

///<summary>
///啟用日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///計算月份
///[date, nullable(True)]
///</summary>
public DateTime? ChargeMonth { get; set; }

///<summary>
///計算週期
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Period { get; set; }

///<summary>
///分攤計算群組(自行輸入，做為產生每期分攤計算頭檔的群組依據)
///[varchar(100), nullable(True)]
///</summary>
public string CalcGroup { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///棟別
///[char(36), nullable(True)]
///</summary>
public Guid? Arch_Id { get; set; }

///<summary>
///合約編號(用於租約管理的分攤設定)
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }
}
}
