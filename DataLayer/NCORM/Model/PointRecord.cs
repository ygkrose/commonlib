using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數檔
/// </summary>
public class PointRecord : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///點數
///[double, nullable(False)]
///</summary>
[Required]
public Double? Point { get; set; }

///<summary>
///生效日
///[date, nullable(True)]
///</summary>
public DateTime? SartDate { get; set; }

///<summary>
///失效日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

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
