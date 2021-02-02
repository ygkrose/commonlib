using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///服務項目設定
/// </summary>
public class CrmSetting : TableBase
{



///<summary>
///集團
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Group_Id { get; set; }

///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///服務類別(客戶報修,公共空間報修,業主交辦)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_CrmType { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///設定名稱
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///起始日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///終止日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///上架
///[date, nullable(True)]
///</summary>
public DateTime? Released { get; set; }

///<summary>
///說明
///[varchar(150), nullable(True)]
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
