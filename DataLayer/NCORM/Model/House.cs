using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號管理
/// </summary>
public class House : TableBase
{



///<summary>
///分戶時該欄位需有值
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///對應組織ID
///[char(36), nullable(True)]
///</summary>
public Guid? Org_Id { get; set; }

///<summary>
///房屋類型
///[varchar(20), nullable(True)]
///</summary>
public string HouseType { get; set; }

///<summary>
///樓層
///[tinyint(4), nullable(True)]
///</summary>
public SByte Floor { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///使用狀況
///[varchar(100), nullable(True)]
///</summary>
public string UsingStatus { get; set; }
}
}
