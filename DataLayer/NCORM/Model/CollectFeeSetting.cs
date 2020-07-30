using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收手續費設定
/// </summary>
public class CollectFeeSetting : TableBase
{



///<summary>
///生效日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EffectiveDate { get; set; }

///<summary>
///服務分類
///[varchar(20), nullable(True)]
///</summary>
public string Chain { get; set; }

///<summary>
///Api介面
///[varchar(20), nullable(True)]
///</summary>
public string ApiInterface { get; set; }

///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///手續費
///[int(11), nullable(True)]
///</summary>
public Int32 Fee { get; set; }

///<summary>
///金額上限
///[int(11), nullable(True)]
///</summary>
public Int32 AmountLimit { get; set; }

///<summary>
///總金額含手續費
///[int(11), nullable(True)]
///</summary>
public Int32 FeeInAmount { get; set; }

///<summary>
///超商手續費代號
///[varchar(20), nullable(True)]
///</summary>
public string RefCode { get; set; }

///<summary>
///來源Table
///[varchar(50), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源Id
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }
}
}
