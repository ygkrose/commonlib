using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///合約管理
/// </summary>
public class Contract : TableBase
{



///<summary>
///公司Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///客戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Buillding_Id { get; set; }

///<summary>
///合約類別(R租約、G駐警)
///[char(1), nullable(False)]
///</summary>
[Required]
public string ContractType { get; set; }

///<summary>
///合約編號
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///簽約發票稅籍
///[char(36), nullable(True)]
///</summary>
public Guid? InvoiceUnit_Id { get; set; }

///<summary>
///合約名稱
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///合約起日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///合約訖日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///實際終止日期
///[datetime, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///付款方式
///[varchar(30), nullable(True)]
///</summary>
public string Code_PayMethod { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///經辦人
///[char(36), nullable(True)]
///</summary>
public Guid? Employee_Id { get; set; }

///<summary>
///合約備註
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

///<summary>
///核示人員
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///核示日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }
}
}
