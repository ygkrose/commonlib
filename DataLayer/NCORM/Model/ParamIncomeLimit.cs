using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///區域所得參數設定
/// </summary>
public class ParamIncomeLimit : TableBase
{


///<summary>
///年度
///</summary>
public string Year { get; set; }

///<summary>
///區域ID
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///最低生活費
///</summary>
public Int32 MinLivingExpenses { get; set; }

///<summary>
///家庭年所得上限
///</summary>
public Int32 MaxFamilyYearIncome { get; set; }

///<summary>
///家庭每人每月平均所得上限
///</summary>
public Int32 MaxAvgMonthIncome { get; set; }

///<summary>
///公證費每件每次補助上限
///</summary>
public Int32 MaxNotaryfees { get; set; }
}
}
