using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///申請物件附屬設備身檔
/// </summary>
public class GRM_ObjectTemp_Facility : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///類別(選項：設備、家電、家具)
///[varchar(20), nullable(True)]
///</summary>
public string Code_Facility { get; set; }

///<summary>
///品項(電視、冰箱、冷氣、熱水器、洗衣機、瓦斯、第四台、網路、床、衣櫃、桌、椅、沙發、其他)
///[varchar(20), nullable(True)]
///</summary>
public string Facility { get; set; }

///<summary>
///數量
///[smallint(6), nullable(True)]
///</summary>
public Int16? Qty { get; set; }

///<summary>
///廠牌型號
///[varchar(20), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
