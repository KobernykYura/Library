using System.Web.Services;
using Common.CheckLoginRes;

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
        Controller contr;

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
            contr = new Controller();
            return contr.ContrCheckLog(p: p, l: l);
        }
    }
}
