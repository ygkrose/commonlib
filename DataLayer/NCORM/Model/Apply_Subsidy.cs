using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 已申請租金補貼項目
/// </summary>
public class Apply_Subsidy : TableBase
{

    ///<summary>
    ///頭檔Id
///[char(36), nullable(False)]
    ///</summary>
    [Required]
    public Guid Apply_Id { get; set; }

    ///<summary>
    ///項次
///[int(11), nullable(True)]
    ///</summary>
    public Int32 Sort { get; set; }

    ///<summary>
    ///年度
///[int(11), nullable(True)]
    ///</summary>
    public Int32 Year { get; set; }

    ///<summary>
    ///補貼項目名稱
///[varchar(50), nullable(True)]
    ///</summary>
    public string SubsidyItem { get; set; }
}
}
