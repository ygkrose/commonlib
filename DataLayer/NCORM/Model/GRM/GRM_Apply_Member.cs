using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///家庭成員身檔
/// </summary>
public class GRM_Apply_Member : TableBase
{



///<summary>
///頭檔Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid GRM_Apply_Id { get; set; }

///<summary>
///姓名
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///身分證字號/居留證號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///外籍人仕(0:否,1:是)
///[char(1), nullable(True)]
///</summary>
public string Forign { get; set; }

///<summary>
///稱謂選項
///[varchar(20), nullable(True)]
///</summary>
public string Appellation { get; set; }

///<summary>
///稱謂填空
///[varchar(20), nullable(True)]
///</summary>
public string OtherAppellation { get; set; }

///<summary>
///性別(男:M，女:F)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///出生年月日
///[date, nullable(True)]
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///成員資格，對應設定檔資料表
///[char(36), nullable(True)]
///</summary>
public Guid? Identity_Id { get; set; }

///<summary>
///障礙類別，對應設定檔資料表
///[varchar(20), nullable(True)]
///</summary>
public string Code_Disabled { get; set; }

///<summary>
///障礙程度，對應設定檔資料表
///[char(36), nullable(True)]
///</summary>
public Guid? DisabledLevel_Id { get; set; }

///<summary>
///配偶姓名
///[varchar(50), nullable(True)]
///</summary>
public string Spouse { get; set; }

///<summary>
///最近年所得
///[int(11), nullable(True)]
///</summary>
public Int32? LatestYearIncome { get; set; }

///<summary>
///未同戶籍20歲以下子女(0:否,1:是)
///[char(1), nullable(True)]
///</summary>
public string Under20 { get; set; }
}
}
