using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///申請物件共有人身檔
/// </summary>
public class ObjectTemp_Coowner : TableBase
{


///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///共有人姓名
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///身分證字號
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string IdCardNo { get; set; }

///<summary>
///生日
///[date, nullable(True)]
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///持有比例
///[float, nullable(True)]
///</summary>
public Single Percentage { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///地址
///[varchar(100), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///說明
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///同意書上傳影像檔
///[char(36), nullable(True)]
///</summary>
public Guid? UploadFile_Id { get; set; }
}
}
