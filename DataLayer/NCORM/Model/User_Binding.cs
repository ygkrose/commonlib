using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///帳號綁定
/// </summary>
    public class User_Binding : TableBase
    {
        /// <summary>
///帳號Id
        /// </summary>
        [Required]
        public Guid User_Id { get; set; }

        ///<summary>
        ///EMAIL\r\nAPPLE\r\nFB\r\nGOOGLE\r\nTWITTER
        ///</summary>
        public string BindingCode { get; set; }

///<summary>
///資料
///</summary>
        public string Data { get; set; }

///<summary>
///綁定的APP
///</summary>
        public string BindingAppId { get; set; }

///<summary>
///預設
///</summary>
        public UInt64 IsDefault { get; set; }
    }
}
