using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修滿意度調查
/// </summary>
public class CrmRecord_Questionnaire : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///評分分類(customer客戶評分、manage驗收評分)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_RespondentType { get; set; }

///<summary>
///評分項目(attitude態度、quality品質、others其他…)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_QuestionnaireItem { get; set; }

///<summary>
///評等(1~5)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Level { get; set; }

///<summary>
///意見
///[varchar(150), nullable(True)]
///</summary>
public string Opinion { get; set; }

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
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }
}
}
