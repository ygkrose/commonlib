using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///記錄使用者登入的設備
/// </summary>
public class User_Device : TableBase
{



///<summary>
///使用者Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///作業系統(Window10, MacOS, IOS, Android, Linux....)
///[varchar(20), nullable(True)]
///</summary>
public string OS { get; set; }

        ///<summary>
        ///Desktop/Mobile
        ///[varchar(10), nullable(True)]
        ///</summary>
        public string DeviceType { get; set; }

        ///<summary>
        ///行動裝置設備ID，若非行動裝置紀錄瀏覽器版本
        ///[varchar(300), nullable(True)]
        ///</summary>
        public string DeviceId { get; set; }

///<summary>
///更新權杖
///[char(36), nullable(True)]
///</summary>
public Guid? RefreshToken { get; set; }
}
}
