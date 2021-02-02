using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///分攤表比例明細
/// </summary>
public class ShareSetting_List : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareSetting_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///分攤分子
///[double, nullable(False)]
///</summary>
[Required]
public Double? Numerator { get; set; }

///<summary>
///私表分攤表ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid FlexShareSetting_Id { get; set; }

///<summary>
///備註
///[varchar(150), nullable(False)]
///</summary>
[Required]
public string Memo { get; set; }

///<summary>
///停用日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

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
