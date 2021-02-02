using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查結果項目明細改善
/// </summary>
public class CheckRecord_ItemImprove : TableBase
{



///<summary>
///改善完成日
///[datetime, nullable(True)]
///</summary>
public DateTime? ImproveDate { get; set; }

///<summary>
///改善值
///[varchar(10), nullable(True)]
///</summary>
public string ImproveValue { get; set; }

///<summary>
///附檔上傳
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }

///<summary>
///檢查說明
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
