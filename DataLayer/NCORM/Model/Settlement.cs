using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收撥款審查
/// </summary>
public class Settlement : TableBase
{



///<summary>
///結算日
///[date, nullable(True)]
///</summary>
public DateTime? SettleDate { get; set; }

///<summary>
///撥款週期(日)
///[char(1), nullable(True)]
///</summary>
public string SettleTerm { get; set; }

///<summary>
///帳務起日
///[date, nullable(True)]
///</summary>
public DateTime? CollectAccountStartDate { get; set; }

///<summary>
///帳務訖日
///[date, nullable(True)]
///</summary>
public DateTime? CollectAccountEndDate { get; set; }

///<summary>
///撥款日
///[date, nullable(True)]
///</summary>
public DateTime? RemitDate { get; set; }

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
///社區總數
///[int(11), nullable(True)]
///</summary>
public Int32? CompanyQty { get; set; }

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
///網銀案件編號
///[varchar(20), nullable(True)]
///</summary>
public string CaseNo { get; set; }

///<summary>
///簽核狀態
///[char(36), nullable(True)]
///</summary>
public Guid? Code_FlowFlag { get; set; }

///<summary>
///FLOWID
///[varchar(20), nullable(True)]
///</summary>
public string Flow_Id { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///核示人
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///核示日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }
}
}
