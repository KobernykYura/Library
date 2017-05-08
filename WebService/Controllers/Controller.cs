using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.LoginData;

namespace Controllers
{
    public class Controller
    {
        
        List<LoginData> adminlogindata;

        public bool ContrCheckLog(string l, string p)
        {
            bool mean = false;

            foreach (var item in adminlogindata)
            {
                
                if (item.Login == l && item.Password == p) mean = true;
            }

            return mean;
        }
    }
}
