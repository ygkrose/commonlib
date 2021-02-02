using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///發票單位管理
/// </summary>
public class InvoiceUnit : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///稅籍編號
///[varchar(15), nullable(True)]
///</summary>
public string TaxIdNo { get; set; }

///<summary>
///稅籍名稱
///[varchar(25), nullable(True)]
///</summary>
public string TaxName { get; set; }

///<summary>
///縣市ID
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///總機構稅籍
///[char(36), nullable(True)]
///</summary>
public Guid? declareInvoiceUnit_Id { get; set; }

///<summary>
///發票核准字號
///[varchar(20), nullable(True)]
///</summary>
public string InvoiceApprovalNo { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///發票加密種子
///[varchar(10), nullable(True)]
///</summary>
public string Seed { get; set; }
}
}
