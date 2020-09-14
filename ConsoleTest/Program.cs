using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlX.XDevAPI.Relational;
using NewCity.Common;
using NewCity.DataAccess;
using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using NCModel = NewCity.DataAccess.Model;
using NewCity.Common;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            var acc = NCUtility.AllowMonth(3, 4);
            /////////單一資料表操作/////////
            
            //宣告DB實體
            DBEntity dBEntity = new DBEntity(DBType.MySql, "server=192.168.1.226;database=PMERP;Persist Security Info=False;uid=itlife;pwd=1qaz@WSX;ConnectionTimeout=300;DefaultCommandTimeout=300;Allow User Variables=True");
            //Task.Run(()=> dBEntity.logHistory("a", "b", Guid.NewGuid()));

            TableEntity<NCModel.Org> userOrgTable = new TableEntity<NCModel.Org>(dBEntity);
            User_Org userOrgx = new User_Org { User_Id = Guid.Parse("1a7e021d-09ed-4d8c-adc7-39c5be0befd5") };
            var userOrgs = userOrgTable.Select(new NCModel.Org());
            //var userOrgs = userOrgTable.Select(new NCModel.Org { Code = "%0%"});

            //宣告欲查詢資料表類
            User u = new User()
            {
                //給定查詢key值,或給定其他欄位條件
                Id = Guid.Parse("97d52e4c-8472-11ea-a6ce-1ab29814667c")
            };
            //宣告資料表操作類
            TableEntity<User> userTable = new TableEntity<User>(dBEntity);
            //查詢
            List<User> result = userTable.Select(new User { Code = "%%"});
            foreach (User _user in result)
            {
                //do job
                
            }
            var cnt = 190;
            List<string> ht = new List<string>();
            Hashtable same = new Hashtable();
            while (cnt > 0)
            {
                string _key = ConnSecure.GenerateUID();
                if (ht.Contains(_key))
                {
                    same.Add(cnt, _key);
                }
                else
                {
                    ht.Add(_key);
                    Console.Write(_key);
                }
                cnt--;
            }
            foreach (var item in same.Keys)
            {
                Console.WriteLine($"SameKey:{item},{same[item]}");
            }

            //更新單筆
            result[0].Name = "NewName";
            //userTable.Update(result[0]);
            //更新多筆
            result[0].Name = "NewName";
            //result[1].Name = "NewName";
            //userTable.Update(result);

            //刪除單筆
            //userTable.Delete(result[0]);
            //刪除多筆
           // userTable.Delete(result);
           
            //自訂查詢;
            doQuery();
            
            Console.Read();
            
            
        }

        private static async void doQuery()
        {
            QueryCmd qc = new QueryCmd(DBType.MySql, "server=192.168.1.226;database=PMERP;Persist Security Info=False;uid=itlife;pwd=1qaz@WSX");
            var userRoles =await qc.GetQueryResult<Role>($"SELECT r.* FROM PMERP.User_Role ur JOIN PMERP.Role r ON r.Id = ur.Role_Id WHERE ur.User_Id = '1a7e021d-09ed-4d8c-adc7-39c5be0befd5';");
            List<string> qry = new List<string>();
            qry.Add("select Id,Path,Name from [File]");
            qry.Add("select * from [User]");
            qry.Add("select * from [Group]");
            string s = "select * from [User];";
            
            var _user = qc.GetQueryResult<User>(s);
            var result = qc.GetManyQueryResult(qry);
            IEnumerable<object> _file = result.ToList()[0];
            var r = _file.Cast<File>().Where(p => p.Privilege == "O");
            var _User = result.ToList()[1] as IEnumerable<User>;
            foreach (var f in result)
            {
                //foreach (var r in f)
                //    Console.WriteLine($"Id={r.Id}, Path={r.Path}, Name={r.Name}");
            }
        }

 
    }
}
