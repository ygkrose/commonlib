using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// JWT中存放的使用者物件
    /// </summary>
    public class TokenUserInfo : UserData
    {
        /// <summary>
        /// 作用中的CompanyId,BuildingId,HouseId,ClientId,RoleId
        /// </summary>
        public CurrentData CurrentUserData { get; set; }

        ///<summary>
        ///帳號
        ///[varchar(20), nullable(False)]
        ///</summary>
        [Required]
        public string Code { get; set; }

        ///<summary>
        ///姓名
        ///[varchar(30), nullable(False)]
        ///</summary>
        [Required]
        public string Name { get; set; }


        ///<summary>
        ///大頭照
        ///[char(36), nullable(True)]
        ///</summary>
        public Guid? headshotFile_Id { get; set; }

        /// <summary>
        /// 使用者綁定的資料
        /// </summary>
        public List<User_Binding> user_Bindings { get; set; }

        /// <summary>
        /// 使用者註冊的設備
        /// </summary>
        public List<User_Device> user_Devices { get; set; }

        /// <summary>
        /// 使用者擁有的角色
        /// </summary>
        public List<Role> user_Roles { get; set; }

        /// <summary>
        /// 使用者對應的資料權限
        /// </summary>
        public List<User_Company> user_Company { get; set; }

        /// <summary>
        /// 帳號所對應的住戶
        /// </summary>
        public List<UserCompany> userCompany { get; set; }

        /// <summary>
        /// 使用者擁有的程式權限
        /// </summary>
        public  List<ProgramAction> programActions { get; set; }
        //public Dictionary<string, List<ProgramAction>> programs { get; set; }

        /// <summary>
        /// user可使用的program
        /// </summary>
        public IEnumerable<Guid> programsId
        {
            get {

                //IEnumerable<ProgramAction> rst = programs.Values?.First();
                //for (var i = 1; i < programs.Values?.Count; i++)
                //{
                //    rst.Union(programs.Values.AsEnumerable().ElementAt(i));
                //}
                //return rst?.Select(p => p.Id).Distinct();

                return programActions.Select(x=>x.Id).Distinct();

            }
        }
    }

    /// <summary>
    /// 程式權限
    /// </summary>
    public class ProgramAction : Program
    {
        ///<summary>
        ///動作編號(Insert/Update/Delete/Print...)
        ///[varchar(30), nullable(False)]
        ///</summary>
        [Required]
        public string FunctionCode { get; set; }

        /// <summary>
        /// 功能名稱
        /// </summary>
        public string FunctionName { get; set; }
        /// <summary>
        /// Http方法名
        /// </summary>
        public string HttpMethod { get; set; }
        /// <summary>
        /// ControllerName/ActionName
        /// </summary>
        public string ActionUrl { get; set; }

        /// <summary>
        /// 權限來源Id
        /// </summary>
        public Guid SourceId { get; set; }
    }

    /// <summary>
    /// 使用者所屬社宅架構
    /// </summary>
    public class UserCompany
    {
        /// <summary>
        /// Client_Id
        /// </summary>
        public Guid? CustomerId { get; set; }
        /// <summary>
        /// Client Short Name
        /// </summary>
        public virtual string CustomerName { get; set; }
        /// <summary>
        /// House_Id
        /// </summary>
        public Guid? HouseId { get; set; }
        /// <summary>
        /// House Short Name
        /// </summary>
        public virtual string HouseName { get; set; }
        /// <summary>
        /// Arch_Id
        /// </summary>
        public Guid? ArchId { get; set; }
        /// <summary>
        /// Arch Name
        /// </summary>
        public virtual string ArchName { get; set; }
        /// <summary>
        /// Building_Id
        /// </summary>
        public Guid? BuildingId { get; set; }
        /// <summary>
        /// Building Short Name
        /// </summary>
        public virtual string BuildingName { get; set; }
        /// <summary>
        /// Company_Id
        /// </summary>
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Company Short Name
        /// </summary>
        public virtual string CompanyName { get; set; }
    }

    /// <summary>
    /// 當前使用的Id
    /// </summary>
    public class CurrentData : UserCompany
    {
        /// <summary>
        /// 當前使用的角色Id
        /// </summary>
        public Guid? RoleId { get; set; }

        /// <summary>
        /// 當前角色名稱
        /// </summary>
        public virtual string RoleName { get; set; }
    }
}
