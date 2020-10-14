using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數異動紀錄檔
/// </summary>
public class PointRecord_Track : TableBase
{



///<summary>
///點數檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PointRecord_Id { get; set; }

///<summary>
///異動日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///free贈送 purchase購買 use使用 void作廢 clfree取消贈送 clpurchase取消購買 cluse取消使用 clvoid取消作廢 transfer移轉
///[varchar(25), nullable(False)]
///</summary>
[Required]
public string PointTrackTerm { get; set; }

///<summary>
///點數(以正負值表示增減)
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Point { get; set; }

///<summary>
///來源Table
///[varchar(50), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
