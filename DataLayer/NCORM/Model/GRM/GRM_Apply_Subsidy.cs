using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///已申請租金補貼項目
/// </summary>
public class GRM_Apply_Subsidy : TableBase
{



///<summary>
///頭檔Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Apply_Id { get; set; }

///<summary>
///項次排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

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