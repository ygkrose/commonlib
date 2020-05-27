using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// 使用者資料表類別
    /// </summary>
    public class User : TableBase
    {
        ///<summary>
        ///帳號
        ///</summary>
        [Required]
        public string Code { get; set; }

        ///<summary>
        ///姓名
        ///</summary>
        [Required]
        public string Name { get; set; }

        ///<summary>
        ///密碼(MD5)
        ///</summary>
        [Required]
        public string Password { get; set; }

        ///<summary>
        ///大頭照
        ///</summary>
        public Guid? HeadshotFile_Id { get; set; }

        ///<summary>
        ///更新權杖
        ///</summary>
        public Guid? RefreshToken { get; set; }
    }

}
