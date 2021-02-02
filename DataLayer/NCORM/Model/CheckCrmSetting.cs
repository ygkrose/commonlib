using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///檢查項目設定
/// </summary>
public class CheckCrmSetting : TableBase
{



///<summary>
///集團
///[char(36), nullable(True)]
///</summary>
public Guid? Group_Id { get; set; }

///<summary>
///公司
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///設定類別:1.定期檢查,2.客戶報修,公共區域報修,3.遷入點交檢查.遷入點交文件.退租點交檢查.退租點交文件.完約文件檢查
///[varchar(30), nullable(True)]
///</summary>
public string Code_CheckType { get; set; }

///<summary>
///檢查代號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///檢查名稱
///[varchar(50), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///檢查起始月份
///[char(1), nullable(True)]
///</summary>
public string CheckMonth { get; set; }

///<summary>
///定檢證照類別ID
///[char(36), nullable(True)]
///</summary>
public Guid? LicenseType_Id { get; set; }

///<summary>
///生效日期
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///檢查週期
///[int(11), nullable(True)]
///</summary>
public Int32? Period { get; set; }

///<summary>
///指定檢查日
///[date, nullable(True)]
///</summary>
public DateTime? CheckDay { get; set; }

///<summary>
///說明文件
///[char(36), nullable(True)]
///</summary>
public Guid? OperatingDoc_Id { get; set; }

///<summary>
///委外(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OutSource { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///資料維護部門
///[char(36), nullable(True)]
///</summary>
public Guid? maintainDept_Id { get; set; }

///<summary>
///置頂(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OnTop { get; set; }

///<summary>
///上架(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Released { get; set; }

///<summary>
///連結網址
///[varchar(250), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///注意事項
///[varchar(450), nullable(True)]
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
