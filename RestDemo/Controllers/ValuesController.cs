using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestDemo.Controllers
{
    public class ValuesController : ApiController
    {
        public class users
        {
            public int user_Id { get; set; }
            public string user_fname { get; set; }
            public string user_lname { get; set; }
            public DateTime birthday { get; set; }
            public string user_gender { get; set; }
            public bool is_vip { get; set; }
            public float user_balance { get; set; }
        }

        static List<users> userList = new List<users>();

        // GET api/values
        public IEnumerable<users> Get()
        {
            return userList;
        }

        // GET api/values/5
        public users Get(int id)
        {
            if(userList.ElementAtOrDefault(id) != null)
            {
                return userList[id];
            }
            else { return null; }
            
        }

        // POST api/values
        public void Post([FromBody] users u)
        {
            userList.Add(new users 
            { 
                user_Id=u.user_Id,
                user_fname = u.user_fname,
                user_lname = u.user_lname,
                birthday = u.birthday,
                user_gender = u.user_gender,
                is_vip = u.is_vip,
                user_balance = u.user_balance
            });
        }

        // PUT api/values/5
        public void Put([FromBody] users u)
        {
            foreach (var uid in userList)
            {
                if(uid.user_Id == u.user_Id)
                {
                    uid.user_fname = u.user_fname;
                    uid.user_lname = u.user_lname;
                    uid.birthday = u.birthday;
                    uid.user_gender = u.user_gender;
                    uid.is_vip = u.is_vip;
                    uid.user_balance = u.user_balance;
                }
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            userList.RemoveAll(u => u.user_Id == id);
        }
    }
}
