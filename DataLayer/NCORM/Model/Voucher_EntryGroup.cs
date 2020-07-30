using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票彙總身檔
/// </summary>
public class Voucher_EntryGroup : TableBase
{



///<summary>
///傳票ID
///[char(36), nullable(True)]
///</summary>
public Guid? Voucher_Id { get; set; }

///<summary>
///序號
///[varchar(10), nullable(True)]
///</summary>
public string Sort { get; set; }

///<summary>
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? Accounting_Id { get; set; }

///<summary>
///借方金額
///[int(11), nullable(True)]
///</summary>
public Int32 DAmount { get; set; }

///<summary>
///貸方金額
///[int(11), nullable(True)]
///</summary>
public Int32 CAmount { get; set; }

///<summary>
///摘要
///[varchar(50), nullable(True)]
///</summary>
public string Note { get; set; }

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
///[varchar(100), nullable(True)]
///</summary>
public string SlipMemo { get; set; }
}
}
