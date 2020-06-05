using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///申請物件車位身檔
/// </summary>
public class ObjectTemp_Parking : TableBase
{


///<summary>
///頭檔ID
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///車位類型
///</summary>
public string ParkingType { get; set; }

///<summary>
///車位編號
///</summary>
public string ParkingNo { get; set; }

///<summary>
///車位樓層(-1 , -2 ..)
///</summary>
public Boolean Floor { get; set; }

///<summary>
///每月清潔費
///</summary>
public Int32 CleaningFee { get; set; }
}
}
