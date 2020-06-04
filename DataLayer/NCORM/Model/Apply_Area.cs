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
    ///</summary>
    public Guid? Apply_Id { get; set; }

    ///<summary>
    ///區域碼
    ///</summary>
	public Guid? Region_Id { get; set; }

    ///<summary>
    ///街道名
    ///</summary>
    public string Street { get; set; }
}
}
