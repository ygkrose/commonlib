﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// JWT中存放的使用者物件
    /// </summary>
    public class TokenUserInfo : UserData
    {
        /// <summary>
        /// 作用中的CompanyId
        /// </summary>
        public Guid CurrentCompanyId { get; set; }

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
        /// 使用者所屬組織
        /// </summary>
        public List<Org> user_Org { get; set; }

        /// <summary>
        /// 帳號所對應的住戶
        /// </summary>
        public List<UserCompany> userCompany { get; set; }

        /// <summary>
        /// 使用者擁有的程式權限
        /// </summary>
        public Dictionary<string, List<ProgramAction>> programs { get; set; }
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
    }

    /// <summary>
    /// 使用者所屬社宅架構
    /// </summary>
    public class UserCompany
    {
        /// <summary>
        /// Client_Id
        /// </summary>
        public Guid ClientId { get; set; }
        /// <summary>
        /// Client Short Name
        /// </summary>
        public string ClientName { get; set; }
        /// <summary>
        /// House_Id
        /// </summary>
        public Guid HouseId { get; set; }
        /// <summary>
        /// House Short Name
        /// </summary>
        public string HouseName { get; set; }
        /// <summary>
        /// Building_Id
        /// </summary>
        public Guid BuildingId { get; set; }
        /// <summary>
        /// Building Short Name
        /// </summary>
        public string BuildingName { get; set; }
        /// <summary>
        /// Company_Id
        /// </summary>
        public Guid CompanyId { get; set; }
        /// <summary>
        /// Company Short Name
        /// </summary>
        public string CompanyName { get; set; }
    }
}
