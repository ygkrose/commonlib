using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓委員明細
/// </summary>
public class Company_OwnerAssociation : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///屆別，對應SysCode
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_Class { get; set; }

///<summary>
///職務編號，對應SysCode
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_JobTitle { get; set; }

///<summary>
///棟別
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///委員姓名
///[varchar(10), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///住戶身份(所有權人、承租人)
///[varchar(20), nullable(True)]
///</summary>
public string Code_Resident { get; set; }

///<summary>
///任期起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///任期訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///聯絡電話
///[varchar(12), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///傳真
///[varchar(12), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///辭職日
///[date, nullable(True)]
///</summary>
public DateTime? QuitDate { get; set; }

///<summary>
///辭職書上傳
///[char(36), nullable(True)]
///</summary>
public Guid? quitUploadFile_Id { get; set; }

///<summary>
///備註
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
