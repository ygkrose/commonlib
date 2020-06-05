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
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///共有人姓名
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///身分證字號
///</summary>
[Required]
public string IdCardNo { get; set; }

///<summary>
///生日
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///持有比例
///</summary>
public Single Percentage { get; set; }

///<summary>
///電話
///</summary>
public string Tel { get; set; }

///<summary>
///地址
///</summary>
public string Addr { get; set; }

///<summary>
///說明
///</summary>
public string Memo { get; set; }

///<summary>
///同意書上傳影像檔
///</summary>
public Guid? UploadFile_Id { get; set; }
}
}
