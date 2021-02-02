using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///移轉作業
/// </summary>
public class Transfer : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///轉換日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///轉換類別(advance預收.depositin保證金.artemp暫收.sales銷貨.point點數)
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string TransferTerm { get; set; }

///<summary>
///來源戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceHouse_Id { get; set; }

///<summary>
///來源住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceCustomer_Id { get; set; }

///<summary>
///目的戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid TargetHouse_Id { get; set; }

///<summary>
///目的住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid TargetCustomer_Id { get; set; }

///<summary>
///備註
///[varchar(150), nullable(False)]
///</summary>
[Required]
public string Memo { get; set; }
}
}
