using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///共用審核紀錄
/// </summary>
public class GRM_ReviewHistory : TableBase
{



///<summary>
///來源TABLEName
///[varchar(100), nullable(False)]
///</summary>
[Required]
public string SourceTable { get; set; }

///<summary>
///來源TABLE Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceTable_Id { get; set; }

///<summary>
///審核時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime ReviewDate { get; set; }

///<summary>
///審核機關Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ReviewOrg_Id { get; set; }

///<summary>
///審核人
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_id { get; set; }

///<summary>
///審核狀態(同意，退件，暫存...等)
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string Status { get; set; }

///<summary>
///審核意見
///[varchar(200), nullable(True)]
///</summary>
public string Opinion { get; set; }

///<summary>
///限定改善日期
///[date, nullable(True)]
///</summary>
public DateTime? ImproveDate { get; set; }
}
}
