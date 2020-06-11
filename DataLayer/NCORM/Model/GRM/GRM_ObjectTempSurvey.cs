using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///申請物件現勘資料
/// </summary>
public class GRM_ObjectTempSurvey : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///現勘日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime SurveyDate { get; set; }

///<summary>
///妨礙逃生(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsNotEscapable { get; set; }

///<summary>
///海砂屋否(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsSeaSandHouse { get; set; }

///<summary>
///海砂屋檢測(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsSeaSandTest { get; set; }

///<summary>
///海砂屋檢測結果
///[varchar(20), nullable(True)]
///</summary>
public string SeaSandTestResult { get; set; }

///<summary>
///是否輻射屋(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsRadiationHouse { get; set; }

///<summary>
///輻射屋檢測(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsRadiationTest { get; set; }

///<summary>
///輻射屋檢測結果
///[varchar(20), nullable(True)]
///</summary>
public string RadiationTestResult { get; set; }

///<summary>
///消防設備(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 FireEquipment { get; set; }

///<summary>
///衛浴設備(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsBathroomEquipment { get; set; }

///<summary>
///熱水器(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 Heater { get; set; }

///<summary>
///熱水器位置
///[varchar(20), nullable(True)]
///</summary>
public string HeaterLocation { get; set; }

///<summary>
///加裝排氣管(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsHeaterPipe { get; set; }

///<summary>
///有管委會(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsCommittee { get; set; }

///<summary>
///管理費每坪單價
///[tinyint(4), nullable(True)]
///</summary>
public SByte MgtFeePerPing { get; set; }

///<summary>
///住戶規約(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsMgtAgreement { get; set; }

///<summary>
///住戶規約附檔
///[char(36), nullable(True)]
///</summary>
public Guid? MgtAgreementUploadFile_Id { get; set; }

///<summary>
///定期消防安檢(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsFireSecurity { get; set; }

///<summary>
///積欠管理費(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsUnpaid { get; set; }

///<summary>
///積欠管理費金額
///[int(11), nullable(True)]
///</summary>
public Int32 UnpaidAmount { get; set; }

///<summary>
///有無漏水(0:無1:有)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsLeak { get; set; }

///<summary>
///漏水處說明
///[varchar(50), nullable(True)]
///</summary>
public string LeakDescription { get; set; }

///<summary>
///供/排水正常否(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsWaterNormal { get; set; }

///<summary>
///不正常供/排水負責維修(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 WaterRepairer { get; set; }

///<summary>
///凶宅否,產權持有期間(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsHauntedHousePossess { get; set; }

///<summary>
///凶宅否,產權持有前(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsHauntedHouseBefore { get; set; }

///<summary>
///未登記之增建(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsIllegalExpansion { get; set; }

///<summary>
///未登記之增建面積
///[int(11), nullable(True)]
///</summary>
public Int32 IllegalArea { get; set; }
}
}
