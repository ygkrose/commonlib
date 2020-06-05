using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///上傳檔案對應表
/// </summary>
public class File_UploadMap : TableBase
{


///<summary>
///關聯資料表名稱
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源表資料Id
///</summary>
public Guid? SourceTable_Id { get; set; }

///<summary>
///上傳檔案表Id
///</summary>
public Guid? File_Id { get; set; }

///<summary>
///檔案說明
///</summary>
public Guid? FileDesc { get; set; }
}
}
