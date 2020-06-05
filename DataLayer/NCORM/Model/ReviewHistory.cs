using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///共用審核紀錄
/// </summary>
public class ReviewHistory : TableBase
{


///<summary>
///來源TABLEName
///</summary>
[Required]
public string SourceTable { get; set; }

///<summary>
///來源TABLE Id
///</summary>
[Required]
public Guid SourceTable_Id { get; set; }

///<summary>
///審核時間
///</summary>
[Required]
public DateTime ReviewDate { get; set; }

///<summary>
///審核機關Id
///</summary>
[Required]
public Guid ReviewOrg_Id { get; set; }

///<summary>
///審核人
///</summary>
[Required]
public Guid User_id { get; set; }

///<summary>
///審核狀態(同意，退件，暫存...等)
///</summary>
[Required]
public string Status { get; set; }

///<summary>
///審核意見
///</summary>
public string Opinion { get; set; }

///<summary>
///限定改善日期
///</summary>
public DateTime? ImproveDate { get; set; }
}
}
