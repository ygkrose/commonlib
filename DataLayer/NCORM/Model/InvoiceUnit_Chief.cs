using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///發票單位負責人身檔
/// </summary>
public class InvoiceUnit_Chief : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid InvoiceUnit_Id { get; set; }

///<summary>
///啟用日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///負責人
///[varchar(20), nullable(True)]
///</summary>
public string Chief { get; set; }
}
}
