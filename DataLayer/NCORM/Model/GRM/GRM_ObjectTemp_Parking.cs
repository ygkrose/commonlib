using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///申請物件車位身檔
/// </summary>
public class GRM_ObjectTemp_Parking : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///車位類型
///[varchar(10), nullable(True)]
///</summary>
public string ParkingType { get; set; }

///<summary>
///車位編號
///[char(5), nullable(True)]
///</summary>
public string ParkingNo { get; set; }

///<summary>
///車位樓層(-1 , -2 ..)
///[smallint(6), nullable(True)]
///</summary>
public Int16 Floor { get; set; }

///<summary>
///每月清潔費
///[int(11), nullable(True)]
///</summary>
public Int32 CleaningFee { get; set; }
}
}
