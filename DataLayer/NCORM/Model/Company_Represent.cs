using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公司代表人
/// </summary>
public class Company_Represent : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///代表人類別(負責人,代理人)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_RepresentType { get; set; }

///<summary>
///姓名
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///性別(F/M)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///出生年月日
///[date, nullable(True)]
///</summary>
public DateTime? Bday { get; set; }

///<summary>
///身份證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///地址
///[varchar(150), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///有效起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///有效訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///檔案上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }

///<summary>
///備註
///[varchar(120), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
