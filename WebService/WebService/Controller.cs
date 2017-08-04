using System.Collections.Generic;
using Common.LoginData;
using Common.CheckLoginRes;

namespace WebService
{
    /// <summary>
    /// Controller.
    /// </summary>
    public class Controller
    {
        private ModelDB dball = new ModelDB();
        List<LoginData> adminlogindata;
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
            adminlogindata = new List<LoginData>();
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
