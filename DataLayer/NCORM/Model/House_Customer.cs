using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號住戶管理
/// </summary>
public class House_Customer : TableBase
{



///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶ID
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///住戶身份(所有權人、所有權人成員、承租人、承租人成員)
///[varchar(20), nullable(True)]
///</summary>
public string Code_Resident { get; set; }

///<summary>
///起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///備註
///[varchar(250), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///關係說明
///[varchar(100), nullable(True)]
///</summary>
public string Relationship { get; set; }

///<summary>
///關聯住戶
///[char(36), nullable(True)]
///</summary>
public Guid? fromCustomer_Id { get; set; }
}
}
