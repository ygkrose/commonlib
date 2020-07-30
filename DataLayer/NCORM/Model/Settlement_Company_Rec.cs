using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收撥款審查大樓交易明細
/// </summary>
public class Settlement_Company_Rec : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? Settlement_Company_Id { get; set; }

///<summary>
///繳款編號
///[char(36), nullable(True)]
///</summary>
public Guid? PaymentRecord_Id { get; set; }
}
}
