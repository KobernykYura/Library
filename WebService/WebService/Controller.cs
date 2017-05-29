using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.LoginData;
using Common.CheckLoginRes;
using Common.Readers;
using Common.Workers;

namespace WebService
{
    /// <summary>
    /// Controller.
    /// </summary>
    public class LoginController
    {
        private ModelDB dball = new ModelDB();
        ResLog reslog = new ResLog();

        /// <summary>
        /// Method for check login.
        /// </summary>
        /// <param name="l">Login.</param>
        /// <param name="p">Passwor.</param>
        /// <returns></returns>
        public ResLog ContrCheckLog(string l, string p)
        {
            dball = new ModelDB();
            List<LoginData>  adminlogindata = new List<LoginData>();
            adminlogindata.AddRange(dball.Logins);

            reslog.mean = false;
            reslog.MeanID = 0;
            foreach (var item in adminlogindata)
            {
                if (item.Login == l && item.Password == p) { reslog.mean = true; reslog.MeanID = item.Id; }
            }
            
            return reslog;
        }
    }
}
