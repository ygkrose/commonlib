using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 家庭成員房產身檔
/// </summary>
public class Apply_MemberHouse : TableBase
{


    ///<summary>
    ///Apply_Member_Id
    ///</summary>
    [Required]
    public Guid Member_Id { get; set; }

    ///<summary>
    ///持有者
    ///</summary>
    public string Owner { get; set; }

    ///<summary>
    ///土地/房屋 (L/H)
    ///</summary>
    public string LandOrHouse { get; set; }

    ///<summary>
    ///座落縣市
    ///</summary>
    public string Region_Id { get; set; }

    ///<summary>
    ///地段
    ///</summary>
    public string Section { get; set; }

    ///<summary>
    ///地號
    ///</summary>
    public string LandNo { get; set; }

    ///<summary>
    ///建物建號
    ///</summary>
    public string BuildingNo { get; set; }

    ///<summary>
    ///總面積
    ///</summary>
    public Double TotalArea { get; set; }

    ///<summary>
    ///持分分子
    ///</summary>
    public Double Numerator { get; set; }

    ///<summary>
    ///持分分母
    ///</summary>
    public Double Denominator { get; set; }

    ///<summary>
    ///持分面積
    ///</summary>
    public Double PossessArea { get; set; }

    ///<summary>
    ///路街
    ///</summary>
    public string Street { get; set; }

    ///<summary>
    ///地址
    ///</summary>
    public string Addr { get; set; }

    ///<summary>
    ///設籍否(0:否,1:是)
    ///</summary>
    public UInt64 Registered { get; set; }
}
}
