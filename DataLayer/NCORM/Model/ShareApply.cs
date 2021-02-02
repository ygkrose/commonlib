using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用分攤申請
/// </summary>
public class ShareApply : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///申請使用起日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///申請使用訖日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///時數
///[int(11), nullable(True)]
///</summary>
public Int32? Hour { get; set; }

///<summary>
///分攤申請類別
///[varchar(20), nullable(True)]
///</summary>
public string ShareApplyType { get; set; }

///<summary>
///說明
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? cancelUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? cancelDate { get; set; }

///<summary>
///實際使用開始時間
///[datetime, nullable(True)]
///</summary>
public DateTime? StartUseDate { get; set; }

///<summary>
///實際使用結束時間
///[datetime, nullable(True)]
///</summary>
public DateTime? EndUseDate { get; set; }
}
}
