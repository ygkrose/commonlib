using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///廠商自然人資料
/// </summary>
public class SupplierNatural : TableBase
{



///<summary>
///身分證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///性別(M:男 F:女)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///免扣補充保費(0:否 1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsNoInsuranceFee { get; set; }
}
}
