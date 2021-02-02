using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓
/// </summary>
public class Building : TableBase
{



///<summary>
///公司Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///資料維護部門
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Dept_Id { get; set; }

///<summary>
///住址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///房屋類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_HouseType { get; set; }

///<summary>
///大樓代號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///大樓簡稱
///[varchar(30), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///大樓名稱
///[varchar(100), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///縣市ID
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///電話
///[varchar(50), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///傳真
///[varchar(50), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///檔案上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }
}
}
