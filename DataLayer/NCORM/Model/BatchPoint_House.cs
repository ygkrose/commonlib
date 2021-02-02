using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數贈送戶號明細
/// </summary>
public class BatchPoint_House : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BatchPoint_Id { get; set; }

///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Customer_Id { get; set; }

///<summary>
///點數
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Point { get; set; }
}
}
