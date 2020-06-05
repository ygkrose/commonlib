using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 承租人承租區域
/// </summary>
public class Apply_Area : TableBase
{

    ///<summary>
    ///頭檔Id
///[char(36), nullable(True)]
    ///</summary>
    public Guid? Apply_Id { get; set; }

    ///<summary>
    ///區域碼
///[char(36), nullable(True)]
    ///</summary>
	public Guid? Region_Id { get; set; }

    ///<summary>
    ///街道名
///[varchar(50), nullable(True)]
    ///</summary>
    public string Street { get; set; }
}
}
