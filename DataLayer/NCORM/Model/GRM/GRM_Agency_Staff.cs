using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///業者人員資料
/// </summary>
public class GRM_Agency_Staff : TableBase
{



///<summary>
///業者ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid GRM_Agency_Id { get; set; }

///<summary>
///編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///姓名
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///類別(經紀人、租賃專員、估價師)
///[varchar(20), nullable(True)]
///</summary>
public string StaffType { get; set; }

///<summary>
///性別(男:M，女:F)
///[char(1), nullable(True)]
///</summary>
public string Sex { get; set; }

///<summary>
///出生年月日
///[date, nullable(True)]
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///身分證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///戶籍縣市區域
///[char(36), nullable(True)]
///</summary>
public Guid? residenceNCT_Region_Id { get; set; }

///<summary>
///戶籍地址
///[varchar(100), nullable(True)]
///</summary>
public string ResidenceAddr { get; set; }

///<summary>
///戶籍電話
///[varchar(20), nullable(True)]
///</summary>
public string ResidenceTel { get; set; }

///<summary>
///通訊縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? mailingNCT_Region_Id { get; set; }

///<summary>
///通訊地址
///[varchar(100), nullable(True)]
///</summary>
public string MailingAddr { get; set; }

///<summary>
///通訊電話
///[varchar(20), nullable(True)]
///</summary>
public string MailingTel { get; set; }

///<summary>
///手機
///[varchar(10), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///證照字號1
///[varchar(15), nullable(True)]
///</summary>
public string LicenseNo1 { get; set; }

///<summary>
///證照有效起日1
///[date, nullable(True)]
///</summary>
public DateTime? LicenseStartDate1 { get; set; }

///<summary>
///證照有效迄日1
///[date, nullable(True)]
///</summary>
public DateTime? LicenseEndDate1 { get; set; }

///<summary>
///證照字號2
///[varchar(15), nullable(True)]
///</summary>
public string LicenseNo2 { get; set; }

///<summary>
///證照有效起日2
///[date, nullable(True)]
///</summary>
public DateTime? LicenseStartDate2 { get; set; }

///<summary>
///證照有效迄日2
///[date, nullable(True)]
///</summary>
public DateTime? LicenseEndDate2 { get; set; }

///<summary>
///到職日
///[date, nullable(True)]
///</summary>
public DateTime? OnBoardDate { get; set; }

///<summary>
///離職日
///[date, nullable(True)]
///</summary>
public DateTime? ResignationDate { get; set; }
}
}
