using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;


namespace BUS
{
    public class UserBUS
    {
        private static UserBUS instance;
        public static UserBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserBUS();
                return instance;
            }
        }
        private UserBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = UserDAO.Instance.Xem();
        }
    }
}
