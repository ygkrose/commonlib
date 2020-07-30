using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///交易對象法人資料
/// </summary>
public class ClientLegal : TableBase
{



///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///法人代表人
///[varchar(20), nullable(True)]
///</summary>
public string Representative { get; set; }

///<summary>
///登記縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? registeredRegion_Id { get; set; }

///<summary>
///登記地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///登記電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }
}
}
