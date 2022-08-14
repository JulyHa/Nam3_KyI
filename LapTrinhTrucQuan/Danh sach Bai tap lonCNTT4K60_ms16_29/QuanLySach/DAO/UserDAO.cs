using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDAO();
                return instance;
            }
        }
        private UserDAO() { }
        public List<User> Xem()
        {
            List<User> users = new List<User>();
            string query = "select * from user";


            return users;
        }
    }
}
