using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// �ɮ׶ǿ��ƪ����O
    /// </summary>
    public class File : TableBase
    {

        ///<summary>
        ///���~�W��
        ///</summary>
        [Required]
        public string Prog_Code { get; set; }

        ///<summary>
        ///�ɮפW�ǨϥΪ�ID
        ///</summary>
        [Required]
        public Guid User_Id { get; set; }

        ///<summary>
        ///�ϥΪ̦W��
        ///</summary>
        public string User_Code { get; set; }

        ///<summary>
        ///�ɮ׸��|
        ///</summary>
        [Required]
        public string Path { get; set; }

        ///<summary>
        ///�ɮצW��
        ///</summary>
        [Required]
        public string Name { get; set; }

        ///<summary>
        ///�إߤ��
        ///</summary>
        [Required]
        public DateTime CreateDate { get; set; }

        ///<summary>
        ///�ɮ��v�� O:Open,D:Delete,L:Limit,A:Auth
        ///</summary>
        [Required]
        public string Privilege { get; set; }

        ///<summary>
        ///��s�H��ID
        ///</summary>
        public Guid? updateUser_Id { get; set; }

        ///<summary>
        ///��s���
        ///</summary>
        public DateTime? UpdateDate { get; set; }

        ///<summary>
        ///�M�צW��
        ///</summary>
        public string ProjectCode { get; set; }


    }


}
