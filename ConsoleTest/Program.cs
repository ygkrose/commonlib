using System;
using System.Collections;
using System.Collections.Generic;
using MySqlX.XDevAPI.Relational;
using NewCity.Common;
using NewCity.DataAccess;
using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            
            /////////單一資料表操作/////////
            
            //宣告DB實體
            DBEntity dBEntity = new DBEntity(DBType.MySql, "server=192.168.1.226;database=PMERP;Persist Security Info=False;uid=itlife;pwd=1qaz@WSX");
            //宣告欲查詢資料表類
            User u = new User()
            {
                //給定查詢key值,或給定其他欄位條件
                Id = Guid.Parse("97d52e4c-8472-11ea-a6ce-1ab29814667c")
            };
            //宣告資料表操作類
            TableEntity<User> userTable = new TableEntity<User>(dBEntity);
            //查詢
            List<User> result = userTable.Select(u);
            foreach (User _user in result)
            {
                //do job
                
            }
            var cnt = 1900000;
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
            //doQuery();
            
            Console.Read();
            
            
        }

        private static async void doQuery()
        {
            QueryCmd qc = new QueryCmd(DBType.MySql, "server=192.168.1.226;database=PMERP;Persist Security Info=False;uid=root;pwd=23101680");
            var result = await qc.GetQueryResult("select Id,Path,Name from File");
            foreach (var r in result)
            {
                Console.WriteLine($"Id={r.Id}, Path={r.Path}, Name={r.Name}");
            }
        }

 
    }
}
