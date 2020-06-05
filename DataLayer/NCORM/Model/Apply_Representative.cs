using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
/// 申請人身檔_代理人
/// </summary>
public class Apply_Representative : TableBase
{

    ///<summary>
    ///頭檔Id
///[char(36), nullable(False)]
    ///</summary>
    [Required]
    public Guid Apply_Id { get; set; }

    ///<summary>
    ///法定代理人(0:否,1:是)
///[bit(1), nullable(True)]
    ///</summary>
    public UInt64 Legal { get; set; }

    ///<summary>
    ///代理人姓名
///[varchar(12), nullable(True)]
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///代理人身分證字號
///[varchar(10), nullable(True)]
    ///</summary>
    public string IdCardNo { get; set; }

    ///<summary>
    ///代理人地址
///[varchar(100), nullable(True)]
    ///</summary>
    public string Addr { get; set; }

    ///<summary>
    ///代理人手機
///[varchar(10), nullable(True)]
    ///</summary>
    public string Mobile { get; set; }

    ///<summary>
    ///代理人電話
///[varchar(20), nullable(True)]
    ///</summary>
    public string Tel { get; set; }

    ///<summary>
    ///身分證影像檔上傳編號
///[char(36), nullable(True)]
    ///</summary>
    public Guid? IdCardImgFile_Id { get; set; }
}
}
