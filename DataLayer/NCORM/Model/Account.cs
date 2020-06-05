using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    ///帳戶管理
    /// </summary>
    public class Account : TableBase
    {



        ///<summary>
        ///交易對象Id
        ///</summary>
        [Required]
        public Guid Client_Id { get; set; }

        ///<summary>
        ///帳戶名稱
        ///</summary>
        public string AccountName { get; set; }

        ///<summary>
        ///開戶銀行代碼
        ///</summary>
        public string Bank { get; set; }

        ///<summary>
        ///開戶分行代碼
        ///</summary>
        public string Branch { get; set; }

        ///<summary>
        ///帳號
        ///</summary>
        public string AccountNo { get; set; }

        ///<summary>
        ///存摺影本上傳
        ///</summary>
        public Guid? UploadFile_Id { get; set; }

        ///<summary>
        ///終止日
        ///</summary>
        public DateTime? StopDate { get; set; }

        ///<summary>
        ///異動單號
        ///</summary>
        public Guid? ModForm_Id { get; set; }
    }
}
