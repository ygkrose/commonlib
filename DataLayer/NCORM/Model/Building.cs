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
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///大樓名稱
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///縣市行政區
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///路街
///</summary>
public string Street { get; set; }

///<summary>
///地址
///</summary>
public string Addr { get; set; }

///<summary>
///總戶數
///</summary>
public Int16 Qty { get; set; }

///<summary>
///使照年月(紀錄年月，日統一帶01)
///</summary>
public DateTime? LicenseDate { get; set; }

public string Lane { get; set; }

///<summary>
///是否成立管委會(0:否1:是)
///</summary>
public UInt64 IsCommittee { get; set; }

///<summary>
///對應的組織Id
///</summary>
public Guid? Organization_Id { get; set; }
}
}
