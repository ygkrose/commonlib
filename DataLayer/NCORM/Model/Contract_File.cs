using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///合約用印文檔
/// </summary>
public class Contract_File : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Contract_Id { get; set; }

///<summary>
///檔案類別(合約掃瞄檔、意向書、批注單...)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_ContractFile { get; set; }

///<summary>
///附檔上傳
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid File_UploadMap_Id { get; set; }

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

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
