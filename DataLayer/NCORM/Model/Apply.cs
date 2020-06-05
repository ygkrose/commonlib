using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 申請資料表
/// </summary>
public class Apply : TableBase
{

    ///<summary>
    ///申請日期
///[datetime, nullable(False)]
    ///</summary>
    [Required]
    public DateTime ApplyDate { get; set; }

    ///<summary>
    ///申請人類別(出租人、承租人、雙重身份)
///[varchar(15), nullable(True)]
    ///</summary>
    public string ApplyType { get; set; }

    ///<summary>
    ///申請方案(選項：a包租包管、b代租代管)
///[char(1), nullable(True)]
    ///</summary>
    public string Plan { get; set; }

    ///<summary>
    ///natural自然人、leagal法人
///[varchar(12), nullable(True)]
    ///</summary>
    public string Person { get; set; }

    ///<summary>
    ///申請人編號
///[varchar(20), nullable(True)]
    ///</summary>
    public string Code { get; set; }

    ///<summary>
    ///簡稱
///[varchar(20), nullable(True)]
    ///</summary>
    public string ShortName { get; set; }

    ///<summary>
    ///全銜
///[varchar(50), nullable(True)]
    ///</summary>
    public string FullName { get; set; }

    ///<summary>
    ///身分證字號
///[varchar(10), nullable(True)]
    ///</summary>
    public string IDCardNo { get; set; }

    ///<summary>
    ///租屋業者
///[varchar(20), nullable(True)]
    ///</summary>
    public string Agency_Code { get; set; }

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
    ///戶口名簿戶號
///[varchar(8), nullable(True)]
    ///</summary>
    public string HouseholdNo { get; set; }

    ///<summary>
    ///電話(日)
///[varchar(20), nullable(True)]
    ///</summary>
    public string TelDay { get; set; }

    ///<summary>
    ///電話(夜)
///[varchar(20), nullable(True)]
    ///</summary>
    public string TelNight { get; set; }

    ///<summary>
    ///手機
///[varchar(10), nullable(True)]
    ///</summary>
    public string Mobile { get; set; }

    ///<summary>
    ///電子郵件
///[varchar(30), nullable(True)]
    ///</summary>
    public string Email { get; set; }

    ///<summary>
    ///戶籍縣市
///[varchar(10), nullable(True)]
    ///</summary>
    public string HouseholdCity { get; set; }

    ///<summary>
    ///戶籍行政區
///[varchar(10), nullable(True)]
    ///</summary>
    public string HouseholdTown { get; set; }

    ///<summary>
    ///戶籍地址
///[varchar(100), nullable(True)]
    ///</summary>
    public string HouseholdAddr { get; set; }

    ///<summary>
    ///通訊縣市
///[varchar(10), nullable(True)]
    ///</summary>
    public string MailingCity { get; set; }

    ///<summary>
    ///通訊行政區
///[varchar(10), nullable(True)]
    ///</summary>
    public string MailingTown { get; set; }

    ///<summary>
    ///通訊地址
///[varchar(100), nullable(True)]
    ///</summary>
    public string MailingAddr { get; set; }

    ///<summary>
    ///法定代理人人數
///[int(11), nullable(True)]
    ///</summary>
    public Int32 RepresentativeQty { get; set; }

    ///<summary>
    ///緊急聯絡人
///[varchar(10), nullable(True)]
    ///</summary>
    public string EmerContact { get; set; }

    ///<summary>
    ///聯絡人關係
///[varchar(10), nullable(True)]
    ///</summary>
    public string EmerRelationship { get; set; }

    ///<summary>
    ///聯絡人電話
///[varchar(20), nullable(True)]
    ///</summary>
    public string EmerTel { get; set; }

    ///<summary>
    ///聯絡人手機
///[varchar(10), nullable(True)]
    ///</summary>
    public string EmerMobile { get; set; }

    ///<summary>
    ///統一編號
///[varchar(12), nullable(True)]
    ///</summary>
public string GUINo { get; set; }

    ///<summary>
    ///法人代表人
///[varchar(12), nullable(True)]
    ///</summary>
    public string Representative { get; set; }

    ///<summary>
    ///登記縣市
///[varchar(10), nullable(True)]
    ///</summary>
    public string RegisteredCity { get; set; }

    ///<summary>
    ///登記行政區
///[varchar(10), nullable(True)]
    ///</summary>
    public string RegisteredTown { get; set; }

    ///<summary>
    ///登記地址
///[varchar(100), nullable(True)]
    ///</summary>
    public string RegisteredAddr { get; set; }

    ///<summary>
    ///法人電話
///[varchar(20), nullable(True)]
    ///</summary>
    public string RegisteredTel { get; set; }

    ///<summary>
    ///帳戶名稱
///[varchar(25), nullable(True)]
    ///</summary>
    public string AccountName { get; set; }

    ///<summary>
    ///開戶銀行(選項：全國銀行之總行，3碼)
///[char(3), nullable(True)]
    ///</summary>
    public string Bank { get; set; }

    ///<summary>
    ///開戶分行,選項：總行之分行，4碼
///[char(4), nullable(True)]
    ///</summary>
    public string Branch { get; set; }

    ///<summary>
    ///帳號
///[varchar(30), nullable(True)]
    ///</summary>
    public string AccountNo { get; set; }

    ///<summary>
	///影本上傳後的檔案代碼
///[char(36), nullable(True)]
    ///</summary>
    public Guid? UploadFile_Id { get; set; }

    ///<summary>
    ///承租申請資格(選項：0一般戶、1第一類弱勢戶、2第二類弱勢戶、3其他)
///[bit(1), nullable(True)]
    ///</summary>
    public UInt64 RentIdentity { get; set; }

    ///<summary>
    ///其他申請資格的描述
///[varchar(50), nullable(True)]
    ///</summary>
    public string OtherIndetity { get; set; }

    ///<summary>
    ///配偶分戶者戶號
///[varchar(8), nullable(True)]
    ///</summary>
    public string SpouseHouseholdNo { get; set; }

    ///<summary>
    ///家戶最近年所得合計
///[int(11), nullable(True)]
    ///</summary>
    public Int32 TotalIncome { get; set; }

    ///<summary>
    ///平均每人每月所得
///[int(11), nullable(True)]
    ///</summary>
    public Int32 AvgIncome { get; set; }

    ///<summary>
    ///格局
///[varchar(20), nullable(True)]
    ///</summary>
    public string Pattern { get; set; }

    ///<summary>
    ///房屋類型
///[varchar(20), nullable(True)]
    ///</summary>
    public string BuildingType { get; set; }

    ///<summary>
    ///實際使用面積
///[double, nullable(True)]
    ///</summary>
    public Double UsingArea { get; set; }

    ///<summary>
    ///樓層
///[int(11), nullable(True)]
    ///</summary>
    public Int32 Floor { get; set; }

    ///<summary>
    ///隔間_房
///[int(11), nullable(True)]
    ///</summary>
    public Int32 BedRoom { get; set; }

    ///<summary>
    ///隔間_廳
///[int(11), nullable(True)]
    ///</summary>
    public Int32 LivingRoom { get; set; }

    ///<summary>
    ///隔間_衛
///[int(11), nullable(True)]
    ///</summary>
    public Int32 BathRoom { get; set; }

    ///<summary>
    ///門禁需求
///[varchar(20), nullable(True)]
    ///</summary>
    public string AccessControl { get; set; }

    ///<summary>
    ///最低租金
///[int(11), nullable(True)]
    ///</summary>
    public Int32 MinRent { get; set; }

    ///<summary>
    ///最高租金
///[int(11), nullable(True)]
    ///</summary>
    public Int32 MaxRent { get; set; }

    ///<summary>
    ///設備
///[varchar(150), nullable(True)]
    ///</summary>
    public string Facility { get; set; }
}
}
