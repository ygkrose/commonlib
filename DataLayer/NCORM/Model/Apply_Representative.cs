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
    ///</summary>
    [Required]
    public Guid Apply_Id { get; set; }

    ///<summary>
    ///法定代理人(0:否,1:是)
    ///</summary>
    public UInt64 Legal { get; set; }

    ///<summary>
    ///代理人姓名
    ///</summary>
    public string Name { get; set; }

    ///<summary>
    ///代理人身分證字號
    ///</summary>
    public string IdCardNo { get; set; }

    ///<summary>
    ///代理人地址
    ///</summary>
    public string Addr { get; set; }

    ///<summary>
    ///代理人手機
    ///</summary>
    public string Mobile { get; set; }

    ///<summary>
    ///代理人電話
    ///</summary>
    public string Tel { get; set; }

    ///<summary>
    ///身分證影像檔上傳編號
    ///</summary>
    public Guid? IdCardImgFile_Id { get; set; }
}
}
