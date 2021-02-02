using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修項目明細時限設定
/// </summary>
public class CheckCrmSetting_Item_Time : TableBase
{



///<summary>
///頭檔
///[char(36), nullable(True)]
///</summary>
public Guid? CheckCrmSetting_Item_Id { get; set; }

///<summary>
///時限類別(assignbefore物管派案時限,arrivebefore廠商到達時限,donebefore廠商完成時限,reviewbefore物管驗收時限)
///[varchar(30), nullable(True)]
///</summary>
public string Code_CrmTimeType { get; set; }

///<summary>
///時限數量
///[int(11), nullable(True)]
///</summary>
public Int32? Qty { get; set; }
}
}
