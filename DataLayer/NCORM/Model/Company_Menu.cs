using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///組織程式選單
/// </summary>
public class Company_Menu : TableBase
{



///<summary>
///組織ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///選單編號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///選單名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///父層Id
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///對應的Program_Id
///[char(36), nullable(True)]
///</summary>
public Guid? Program_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///節點屬性(F:Folder, P:Program)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Type { get; set; }
}
}
