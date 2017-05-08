using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.LoginData;

namespace WebService
{
    /// <summary>
    /// Controller.
    /// </summary>
    public class Controller
    {
        private ModelDB dball = new ModelDB();
        List<LoginData> adminlogindata;

        /// <summary>
        /// Method for check login.
        /// </summary>
        /// <param name="l">Login.</param>
        /// <param name="p">Passwor.</param>
        /// <returns></returns>
        public bool ContrCheckLog(string l, string p)
        {
            dball = new ModelDB();
            adminlogindata = new List<LoginData>();
            adminlogindata.AddRange(dball.Logins);

            bool mean = false;
            foreach (var item in adminlogindata)
            {
                if (item.Login == l && item.Password == p) mean = true;
            }

            return mean;
        }
    }
}
