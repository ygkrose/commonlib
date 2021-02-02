using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄
/// </summary>
public class CrmRecord : TableBase
{



///<summary>
///公司
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///客戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///服務類別(客戶報修,公共空間報修,業主交辦)
///[varchar(30), nullable(True)]
///</summary>
public string Code_CheckCrmType { get; set; }

///<summary>
///日期
///[datetime, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///聯絡人
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///電話
///[varchar(30), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///手機
///[varchar(30), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///報修項目
///[char(36), nullable(True)]
///</summary>
public Guid? CheckRepairSetting_Item_Id { get; set; }

///<summary>
///問題描述
///[varchar(350), nullable(True)]
///</summary>
public string Description { get; set; }

///<summary>
///保固期內(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Warranty { get; set; }

///<summary>
///人為損壞(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string HumanNegligence { get; set; }

///<summary>
///處理廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///維修總金額
///[int(11), nullable(True)]
///</summary>
public Int32? TotalAmount { get; set; }

///<summary>
///客戶自付額
///[int(11), nullable(True)]
///</summary>
public Int32? CustomerAmount { get; set; }

///<summary>
///公共空間
///[char(36), nullable(True)]
///</summary>
public Guid? PublicArea_Id { get; set; }

///<summary>
///說明
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

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
