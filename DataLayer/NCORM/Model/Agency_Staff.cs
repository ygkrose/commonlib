using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///業者人員資料
/// </summary>
public class Agency_Staff : TableBase
{

///<summary>
///業者ID
///</summary>
[Required]
public Guid Agency_Id { get; set; }

///<summary>
///編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///姓名
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///類別(經紀人、租賃專員、估價師)
///</summary>
public string StaffType { get; set; }

///<summary>
///性別(男:M，女:F)
///</summary>
public string Sex { get; set; }

///<summary>
///出生年月日
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///身分證字號
///</summary>
public string IdCardNo { get; set; }

///<summary>
///戶籍縣市區域
///</summary>
public Guid? ResidenceRegion_Id { get; set; }

///<summary>
///戶籍地址
///</summary>
public string ResidenceAddr { get; set; }

///<summary>
///戶籍電話
///</summary>
public string ResidenceTel { get; set; }

///<summary>
///通訊縣市行政區
///</summary>
public Guid? MailingRegion_Id { get; set; }

///<summary>
///通訊地址
///</summary>
public string MailingAddr { get; set; }

///<summary>
///通訊電話
///</summary>
public string MailingTel { get; set; }

///<summary>
///手機
///</summary>
public string Mobile { get; set; }

///<summary>
///證照字號1
///</summary>
public string LicenseNo1 { get; set; }

///<summary>
///證照有效起日1
///</summary>
public DateTime? LicenseStartDate1 { get; set; }

///<summary>
///證照有效迄日1
///</summary>
public DateTime? LicenseEndDate1 { get; set; }

///<summary>
///證照字號2
///</summary>
public string LicenseNo2 { get; set; }

///<summary>
///證照有效起日2
///</summary>
public DateTime? LicenseStartDate2 { get; set; }

///<summary>
///證照有效迄日2
///</summary>
public DateTime? LicenseEndDate2 { get; set; }

///<summary>
///到職日
///</summary>
public DateTime? OnBoardDate { get; set; }

///<summary>
///離職日
///</summary>
public DateTime? ResignationDate { get; set; }
}
}
