using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄聯繫明細
/// </summary>
public class CrmRecord_Contact : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///聯繫時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ContactDate { get; set; }

///<summary>
///聯繫進度(norespond聯繫不上, respond已聯繫未約定時間, appoint已約定時間)
///[varchar(20), nullable(True)]
///</summary>
public string Code_ContactStatus { get; set; }

///<summary>
///描述
///[varchar(100), nullable(True)]
///</summary>
public string Desc { get; set; }

///<summary>
///聯繫電話
///[varchar(30), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///約定時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AppointmentDate { get; set; }

///<summary>
///備註
///[varchar(120), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
