using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓之部門權限身檔
/// </summary>
public class Building_Auth : TableBase
{



///<summary>
///大樓Id
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///部門Id
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }
}
}
