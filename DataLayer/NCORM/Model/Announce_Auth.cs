using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///指定公告組織
/// </summary>
public class Announce_Auth : TableBase
{



///<summary>
///公告ID
///[char(36), nullable(True)]
///</summary>
public Guid? Announce_Id { get; set; }

///<summary>
///公司
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }
}
}
