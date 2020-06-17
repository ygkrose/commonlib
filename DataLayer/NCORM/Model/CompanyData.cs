using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公司關聯表
/// </summary>
public class CompanyData : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///勞工保險證號
///[varchar(20), nullable(True)]
///</summary>
public string LaborInsuracneNo { get; set; }

///<summary>
///全民健保證號
///[varchar(20), nullable(True)]
///</summary>
public string HealthInsuranceNo { get; set; }

///<summary>
///退休金證號
///[varchar(20), nullable(True)]
///</summary>
public string PensionNo { get; set; }

///<summary>
///媒體單位代號
///[varchar(20), nullable(True)]
///</summary>
public string MediaNo { get; set; }

///<summary>
///房屋稅籍編號
///[varchar(15), nullable(True)]
///</summary>
public string HouseTaxIdNo { get; set; }
}
}
