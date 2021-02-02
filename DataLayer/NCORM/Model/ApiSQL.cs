using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///Apiallinone專用
/// </summary>
public class ApiSQL : TableBase
{



[Required]
public string Sqlstr { get; set; }

public DateTime? Adddate { get; set; }
}
}
