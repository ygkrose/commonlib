using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 家庭成員身檔
/// </summary>
public class Apply_Member : TableBase
{



    ///<summary>
    ///頭檔Id
    ///</summary>
    [Required]
    public Guid Apply_Id { get; set; }

    ///<summary>
    ///姓名
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///身分證字號/居留證號
    ///</summary>
    public string IdCardNo { get; set; }

    ///<summary>
    ///外籍人仕(0:否,1:是)
    ///</summary>
    public UInt64 Forign { get; set; }

    ///<summary>
    ///稱謂選項
    ///</summary>
    public string Appellation { get; set; }

    ///<summary>
    ///稱謂填空
    ///</summary>
    public string OtherAppellation { get; set; }

    ///<summary>
    ///性別(男:M，女:F)
    ///</summary>
    public string Sex { get; set; }

    ///<summary>
    ///出生年月日
    ///</summary>
    public DateTime? BDay { get; set; }

    ///<summary>
    ///成員資格，對應設定檔資料表
    ///</summary>
    public Guid? Identity_Id { get; set; }

    ///<summary>
    ///障礙類別，對應設定檔資料表
    ///</summary>
    public Guid? DisabledType_Id { get; set; }

    ///<summary>
    ///障礙程度，對應設定檔資料表
    ///</summary>
    public Guid? DisabledLevel_Id { get; set; }

    ///<summary>
    ///配偶姓名
    ///</summary>
    public string Spouse { get; set; }

    ///<summary>
    ///最近年所得
    ///</summary>
    public Int32 LatestYearIncome { get; set; }

    ///<summary>
    ///未同戶籍20歲以下子女(0:否,1:是)
    ///</summary>
    public UInt64 Under20 { get; set; }
}
}
