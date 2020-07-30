using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///訪客管理
/// </summary>
public class Visit : TableBase
{



///<summary>
///拜訪時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime VisitDate { get; set; }

///<summary>
///拜訪戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///拜訪住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///訪客姓名
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Visitor { get; set; }

///<summary>
///訪客電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///事由類別
///[varchar(150), nullable(True)]
///</summary>
public string VisitTerm { get; set; }

///<summary>
///押證類別
///[varchar(20), nullable(True)]
///</summary>
public string MortgageTerm { get; set; }

///<summary>
///通行證號
///[varchar(20), nullable(True)]
///</summary>
public string PassNo { get; set; }

///<summary>
///借出感應卡編號
///[char(36), nullable(True)]
///</summary>
public Guid? Card_Id { get; set; }

///<summary>
///拍照圖檔
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

///<summary>
///離開時間
///[datetime, nullable(True)]
///</summary>
public DateTime? LeaveDate { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
