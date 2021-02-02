using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///帳戶管理
/// </summary>
public class BankAccount : TableBase
{



///<summary>
///來源表Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceId { get; set; }

///<summary>
///來源資料表名
///[varchar(100), nullable(False)]
///</summary>
[Required]
public string SourceTable { get; set; }

///<summary>
///帳戶名稱
///[varchar(50), nullable(True)]
///</summary>
public string AccountName { get; set; }

///<summary>
///開戶銀行代碼
///[char(36), nullable(True)]
///</summary>
public Guid? BankInfo_Id { get; set; }

///<summary>
///銀行轉帳扣款(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsAch { get; set; }

///<summary>
///帳號
///[varchar(50), nullable(True)]
///</summary>
public string AccountNo { get; set; }

///<summary>
///存摺影本上傳
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

///<summary>
///終止日
///[datetime, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///異動單號
///[char(36), nullable(True)]
///</summary>
public Guid? ModForm_Id { get; set; }

///<summary>
///銀行審核通過(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsAchApproval { get; set; }

///<summary>
///是否預設帳戶(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsDefault { get; set; }

///<summary>
///帳戶簡稱
///[varchar(20), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///銀行企業編號(虛擬帳號的前幾碼)
///[varchar(10), nullable(True)]
///</summary>
public string BankCode { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }
}
}
