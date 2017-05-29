using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Controllers;
using Common.Readers;
using Common.Workers;
using Common.CheckLoginRes;
using WebService.Controllers;

namespace WebService
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        LoginController contr;
        ReadersController contrRead;
        WorkersController contrWork;
        /// <summary>
        /// Hello world.
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        /// <summary>
        /// Web method for check login and password.
        /// </summary>
        /// <param name="l">Login.</param>
        /// <param name="p">Password.</param>
        /// <returns></returns>
        [WebMethod]
        public ResLog CheckLogin(string l, string p)
        {
            contr = new LoginController();
            return contr.ContrCheckLog(p: p, l: l);
        }
        /// <summary>
        /// Load workers from DB.
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Reader> LoadReaders()
        {
            contrRead = new ReadersController();
            return contrRead.GetList();
        }
        /// <summary>
        /// Load readers from DB.
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<Worker> LoadWorkers()
        {
            contrWork = new WorkersController();
            return contrWork.GetList();
        }
    }
}
