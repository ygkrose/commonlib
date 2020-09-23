using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目圖檔管理
/// </summary>
public class BookingItem_File : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///圖檔上傳
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }
}
}
