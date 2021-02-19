using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公共空間管理
/// </summary>
public class PublicArea : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///棟別
///[char(36), nullable(True)]
///</summary>
public Guid? Arch_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///區域名稱
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///空間屬性(車用/會議用/廁所用/機房用/頂樓/牆面/電梯間)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PublicAreaType { get; set; }

///<summary>
///面積
///[double, nullable(True)]
///</summary>
public Double? Area { get; set; }

///<summary>
///室內外(in/out)
///[varchar(5), nullable(True)]
///</summary>
public string InOutDoor { get; set; }

///<summary>
///樓層
///[int(11), nullable(True)]
///</summary>
public Int32? Floor { get; set; }

///<summary>
///停用(是:1 否:0)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///實景導覽
///[char(36), nullable(True)]
///</summary>
public Guid? panoramaFile_Id { get; set; }

///<summary>
///BIM元件
///[varchar(50), nullable(True)]
///</summary>
public string BimCode { get; set; }

///<summary>
///BIM連結網址
///[varchar(200), nullable(True)]
///</summary>
public string BimUrl { get; set; }

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
}
}
