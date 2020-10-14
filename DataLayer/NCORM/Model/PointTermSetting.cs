using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數類別設定
/// </summary>
public class PointTermSetting : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///點數類別(贈送free、購買purchase、月票1pass1、月票2pass2、特殊special)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///產生傳票(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsVoucher { get; set; }

///<summary>
///購買換算率%(若須產生傳票則限定100%)
///[double, nullable(False)]
///</summary>
[Required]
public Double? PointRate { get; set; }
}
}
