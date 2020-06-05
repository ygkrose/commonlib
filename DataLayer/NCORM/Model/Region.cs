using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///行政區
/// </summary>
public class Region : TableBase
{


///<summary>
///區域父ID
///</summary>
public Guid? Pid { get; set; }

///<summary>
///階層
///</summary>
public string Code { get; set; }

///<summary>
///全名
///</summary>
public string FullName { get; set; }

///<summary>
///簡短名
///</summary>
public string ShortName { get; set; }

    ///<summary>
    ///排序
    ///</summary>
    public Byte? Rank { get; set; } 

public string Ord { get; set; }
}
}
