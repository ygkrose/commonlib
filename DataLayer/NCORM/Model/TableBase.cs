using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// model base class
    /// </summary>
    public class TableBase
    {
        /// <summary>
        /// 資料表流水號
        /// </summary>
        [IgnoreDataMember]
        protected long Seq { get; set; } // bigint, not null


        /// <summary>
        /// 資料表GUID唯一值
        /// </summary>
        [Required]
        [Key]
        public virtual Guid Id { get; set; }  // char(36), not null

    }
}
