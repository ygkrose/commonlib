using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///區域所得參數設定
/// </summary>
public class GRM_ParamIncomeLimit : TableBase
{



///<summary>
///年度
///[char(3), nullable(True)]
///</summary>
public string Year { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///最低生活費
///[int(11), nullable(True)]
///</summary>
public Int32? MinLivingExpenses { get; set; }

///<summary>
///家庭年所得上限
///[int(11), nullable(True)]
///</summary>
public Int32? MaxFamilyYearIncome { get; set; }

///<summary>
///家庭每人每月平均所得上限
///[int(11), nullable(True)]
///</summary>
public Int32? MaxAvgMonthIncome { get; set; }

///<summary>
///公證費每件每次補助上限
///[int(11), nullable(True)]
///</summary>
public Int32? MaxNotaryfees { get; set; }
}
}
