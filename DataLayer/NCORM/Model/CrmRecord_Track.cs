using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄處理明細
/// </summary>
public class CrmRecord_Track : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///開始處裡日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///報修處理狀態(tobeprocessed待處理,processing處理中,finished廠商已完成,closed已結案,suspend暫不處理)
///[varchar(20), nullable(True)]
///</summary>
public string Code_RepairRecordStatus { get; set; }

///<summary>
///報修處理中進度(wait待料,processing施工中)
///[varchar(20), nullable(True)]
///</summary>
public string Code_ProcessingStatus { get; set; }

///<summary>
///說明
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///施工前照片
///[char(36), nullable(True)]
///</summary>
public Guid? beforeFile_UploadMap_Id { get; set; }

///<summary>
///施工後照片
///[char(36), nullable(True)]
///</summary>
public Guid? afterFile_UploadMap_Id { get; set; }

///<summary>
///客戶簽名
///[char(36), nullable(True)]
///</summary>
public Guid? signFile_Id { get; set; }

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
