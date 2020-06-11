using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號屬性管理
/// </summary>
public class HouseProperty : TableBase
{



///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///房屋管理人
///[char(36), nullable(True)]
///</summary>
public Guid? agentClient_Id { get; set; }

///<summary>
///不印通知單(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsNoNotice { get; set; }

///<summary>
///繳費贈送點數
///[int(11), nullable(True)]
///</summary>
public Int32 FreePoint { get; set; }

///<summary>
///門禁卡數
///[tinyint(4), nullable(True)]
///</summary>
public SByte CardQty { get; set; }

///<summary>
///門禁釦數
///[tinyint(4), nullable(True)]
///</summary>
public SByte TagQty { get; set; }

///<summary>
///信件合併領取(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsAllPost { get; set; }

///<summary>
///水號
///[varchar(30), nullable(True)]
///</summary>
public string WaterNo { get; set; }

///<summary>
///電號
///[varchar(30), nullable(True)]
///</summary>
public string ElectricityNo { get; set; }

///<summary>
///瓦斯錶號
///[varchar(30), nullable(True)]
///</summary>
public string GasNo { get; set; }

///<summary>
///對講機號碼
///[varchar(10), nullable(True)]
///</summary>
public string IntercomNo { get; set; }

///<summary>
///房型
///[varchar(20), nullable(True)]
///</summary>
public string RoomQty { get; set; }

///<summary>
///格局
///[varchar(20), nullable(True)]
///</summary>
public string Pattern { get; set; }

///<summary>
///方位
///[varchar(20), nullable(True)]
///</summary>
public string Direction { get; set; }
}
}
