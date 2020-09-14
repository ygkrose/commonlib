using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收Gateway上轉發各專案伺服器的設定檔
/// </summary>
public class ServerSetting : TableBase
{



///<summary>
///Server名稱
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///服務位址
///[varchar(150), nullable(True)]
///</summary>
public string ServiceURL { get; set; }

///<summary>
///加密用鑰匙
///[varchar(150), nullable(True)]
///</summary>
public string KeyChain { get; set; }
}
}
