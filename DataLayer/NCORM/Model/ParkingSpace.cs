using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///車位管理
/// </summary>
public class ParkingSpace : TableBase
{



///<summary>
///車位編號
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///車位樓層
///[smallint(6), nullable(False)]
///</summary>
[Required]
public Int16? Floor { get; set; }

///<summary>
///車位總類(法定車位、獎勵車位、增設車位、自劃車位)
///[varchar(20), nullable(True)]
///</summary>
public string Code_ParkingSpaceTerm { get; set; }

///<summary>
///車位類型(平面車位、機械上層、機械下層、機車位)
///[varchar(20), nullable(True)]
///</summary>
public string Code_ParkingSpaceType { get; set; }

///<summary>
///產權性質(公有、私有)
///[varchar(10), nullable(True)]
///</summary>
public string Ownership { get; set; }

///<summary>
///公司Id
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///限停車位數
///[int(1), nullable(True)]
///</summary>
public Int32? CarQty { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }

///<summary>
///收費對象
///[char(36), nullable(True)]
///</summary>
public Guid? billCustomer_Id { get; set; }

///<summary>
///住戶收費對象
///[char(36), nullable(True)]
///</summary>
public Guid? billHouse_Id { get; set; }

///<summary>
///資產ID
///[char(36), nullable(True)]
///</summary>
public Guid? Property_Id { get; set; }

///<summary>
///室內外
///[varchar(10), nullable(True)]
///</summary>
public string InOutDoor { get; set; }

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
