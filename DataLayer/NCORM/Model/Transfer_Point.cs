using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///移轉作業點數明細,因有效期限不同,由USER自行選定移轉哪幾筆點數ID
/// </summary>
public class Transfer_Point : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Transfer_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(True)]
///</summary>
public string PointTerm { get; set; }

///<summary>
///點數ID
///[char(36), nullable(True)]
///</summary>
public Guid? PointRecord_Id { get; set; }

///<summary>
///移轉點數
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Point { get; set; }
}
}
