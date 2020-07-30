using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票身檔關聯表
/// </summary>
public class Voucher_EntryData : TableBase
{



///<summary>
///課稅別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string TaxType { get; set; }

///<summary>
///費用年月
///[date, nullable(False)]
///</summary>
[Required]
public DateTime YearMonth { get; set; }

///<summary>
///費用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///費用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///合約編號
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///服務據點
///[char(36), nullable(True)]
///</summary>
public Guid? Station_Id { get; set; }

///<summary>
///印單備註
///[varchar(50), nullable(True)]
///</summary>
public string SlipMemo { get; set; }

///<summary>
///是否沖預收(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 WriteOffByAdvance { get; set; }

///<summary>
///來源類別(沖帳,折讓,作廢)
///[varchar(20), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///對應沖帳頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }
}
}
