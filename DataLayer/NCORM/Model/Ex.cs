using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///期初轉入資料
/// </summary>
public class Ex : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///轉入日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///sales未收款項、advancein預收款、depositin保證金、tempin暫收款
///[varchar(30), nullable(True)]
///</summary>
public string ExTerm { get; set; }

///<summary>
///借方科目
///[char(36), nullable(True)]
///</summary>
public Guid? DAccountingItem_Id { get; set; }

///<summary>
///貸方科目
///[char(36), nullable(True)]
///</summary>
public Guid? CAccountingItem_Id { get; set; }

///<summary>
///須產生傳票(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string AddVoucher { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

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
