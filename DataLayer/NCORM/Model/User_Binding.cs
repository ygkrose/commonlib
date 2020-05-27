using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NewCity.DataAccess.Model
{
    public class User_Binding : TableBase
    {
        /// <summary>
        /// User Table的 Id
        /// </summary>
        [Required]
        public Guid User_Id { get; set; }

        ///<summary>
        ///EMAIL\r\nAPPLE\r\nFB\r\nGOOGLE\r\nTWITTER
        ///</summary>
        public string BindingCode { get; set; }

        public string Data { get; set; }

        public string BindingAppId { get; set; }

        public UInt64 IsDefault { get; set; }
    }
}
