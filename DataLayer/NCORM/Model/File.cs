using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// 檔案傳輸資料表類別
    /// </summary>
    public class File : TableBase
    {

        ///<summary>
        ///產品名稱
        ///</summary>
        [Required]
        public string Prog_Code { get; set; }

        ///<summary>
        ///檔案上傳使用者ID
        ///</summary>
        [Required]
        public Guid User_Id { get; set; }

        ///<summary>
        ///使用者名稱
        ///</summary>
        public string User_Code { get; set; }

        ///<summary>
        ///檔案路徑
        ///</summary>
        [Required]
        public string Path { get; set; }

        ///<summary>
        ///檔案名稱
        ///</summary>
        [Required]
        public string Name { get; set; }

        ///<summary>
        ///建立日期
        ///</summary>
        [Required]
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///檔案權限 O:Open,D:Delete,L:Limit,A:Auth
        ///</summary>
        [Required]
        public string Privilege { get; set; }

        ///<summary>
        ///更新人員ID
        ///</summary>
        public Guid? updateUser_Id { get; set; }

        ///<summary>
        ///更新日期
        ///</summary>
        public DateTime? UpdateDate { get; set; }

        ///<summary>
        ///專案名稱
        ///</summary>
        public string ProjectCode { get; set; }


    }


}
