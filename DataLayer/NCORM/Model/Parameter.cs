using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///欄位條件設定
/// </summary>
public class Parameter : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///參數代號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///參數名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///欄位屬性(日期、數值、文字)
///[varchar(10), nullable(True)]
///</summary>
public string Property { get; set; }

///<summary>
///參數值
///[varchar(20), nullable(True)]
///</summary>
public string Value { get; set; }

///<summary>
///最小值
///[varchar(20), nullable(True)]
///</summary>
public string MinValue { get; set; }

///<summary>
///最大值
///[varchar(20), nullable(True)]
///</summary>
public string MaxValue { get; set; }

///<summary>
///系統用(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsSys { get; set; }

///<summary>
///參數類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_Param { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
