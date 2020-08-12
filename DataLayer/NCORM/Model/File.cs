using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檔案傳輸資料表
/// </summary>
public class File : TableBase
{



///<summary>
///產品名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string ProgCode { get; set; }

///<summary>
///檔案上傳使用者ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///檔案路徑
///[varchar(200), nullable(False)]
///</summary>
[Required]
public string Path { get; set; }

///<summary>
///檔案名稱
///[varchar(500), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///建立日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime CreateDate { get; set; }

///<summary>
///檔案權限O:Open,D:Delete,L:Limit,A:Auth
///[char(1), nullable(False)]
///</summary>
[Required]
public string Privilege { get; set; }

///<summary>
///更新人員ID
///[char(36), nullable(True)]
///</summary>
public Guid? updateUser_Id { get; set; }

///<summary>
///更新日期
///[datetime, nullable(True)]
///</summary>
public DateTime? UpdateDate { get; set; }

///<summary>
///專案名稱
///[varchar(200), nullable(True)]
///</summary>
public string ProjectCode { get; set; }

///<summary>
///使用者名稱
///[varchar(200), nullable(True)]
///</summary>
public string User_Code { get; set; }
}
}
