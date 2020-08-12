using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收撥款審查大樓身檔
/// </summary>
public class Settlement_Company : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Settlement_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///代收金額
///[int(11), nullable(True)]
///</summary>
public Int32? CollectAmount { get; set; }

///<summary>
///代收筆數
///[int(11), nullable(True)]
///</summary>
public Int32? CollectQty { get; set; }

///<summary>
///交易手續費負擔方
///[varchar(20), nullable(True)]
///</summary>
public string FeePayer { get; set; }

///<summary>
///社區負擔交易手續費
///[int(11), nullable(True)]
///</summary>
public Int32? ComanyTransFee { get; set; }

///<summary>
///平台負擔交易手續費
///[int(11), nullable(True)]
///</summary>
public Int32? NcTransFee { get; set; }

///<summary>
///社區撥款手續費
///[int(11), nullable(True)]
///</summary>
public Int32? ComanyRemitFee { get; set; }

///<summary>
///平台撥款手續費
///[int(11), nullable(True)]
///</summary>
public Int32? NcRemitFee { get; set; }

///<summary>
///撥款金額
///[int(11), nullable(True)]
///</summary>
public Int32? RemitAmount { get; set; }

///<summary>
///開戶銀行
///[char(36), nullable(True)]
///</summary>
public Guid? BankInfo_Id { get; set; }

///<summary>
///戶名
///[varchar(50), nullable(True)]
///</summary>
public string AccountName { get; set; }

///<summary>
///帳號
///[varchar(50), nullable(True)]
///</summary>
public string AccountNo { get; set; }

///<summary>
///通知EMAIL
///[varchar(150), nullable(True)]
///</summary>
public string Email { get; set; }
}
}
