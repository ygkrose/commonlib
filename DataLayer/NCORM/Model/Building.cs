using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓資訊
/// </summary>
public class Building : TableBase
{


///<summary>
///大樓編號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///大樓名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///路街
///[varchar(100), nullable(True)]
///</summary>
public string Street { get; set; }

///<summary>
///地址
///[varchar(100), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///總戶數
///[smallint(5), nullable(True)]
///</summary>
public Int16 Qty { get; set; }

///<summary>
///使照年月(紀錄年月，日統一帶01)
///[date, nullable(True)]
///</summary>
public DateTime? LicenseDate { get; set; }

public string Lane { get; set; }

///<summary>
///是否成立管委會(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsCommittee { get; set; }

///<summary>
///對應的組織Id
///[char(36), nullable(True)]
///</summary>
public Guid? Organization_Id { get; set; }
}
}
