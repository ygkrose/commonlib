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
///預計拜訪時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ExpectedDate { get; set; }

///<summary>
///社區ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///受訪戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///拜訪住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///受訪單位
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///受訪員工
///[char(36), nullable(True)]
///</summary>
public Guid? Employee_Id { get; set; }

///<summary>
///訪客姓名
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Visitor { get; set; }

///<summary>
///受訪人姓名
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///訪客電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///訪客車牌號碼
///[varchar(20), nullable(True)]
///</summary>
public string Plate { get; set; }

///<summary>
///訪客人數
///[int(11), nullable(True)]
///</summary>
public Int32? Qty { get; set; }

///<summary>
///引導位置
///[varchar(30), nullable(True)]
///</summary>
public string Place { get; set; }

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
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
