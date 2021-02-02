using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設使用產品明細
/// </summary>
public class BookingUse_TimePhase : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingUse_Id { get; set; }

///<summary>
///預約ID
///[char(36), nullable(True)]
///</summary>
public Guid? BookingRecord_Id { get; set; }

///<summary>
///時段
///[char(36), nullable(True)]
///</summary>
public Guid? Amenity_TimePhase_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///單次點數
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? UnitPoint { get; set; }

///<summary>
///使用數量
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? UseQty { get; set; }
}
}
