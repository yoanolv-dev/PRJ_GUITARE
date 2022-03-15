using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using LIB_BASE;

namespace WS_GUITARE
{
    /// <summary>
    /// Description résumée de WS_GUITARE
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_GUITARE : System.Web.Services.WebService
    {
        C_BASE La_Base = new C_BASE();

        [WebMethod]
        public string GetDate()
        {
            return DateTime.Now.ToString();
        }

        [WebMethod]
        public List<C_BOIS> Donne_Liste_Bois()
        { return La_Base.Get_Bois(); }

        [WebMethod]
        public List<C_VIBRATO> Donne_Liste_Vibrato()
        {
            return La_Base.Get_Vibrato(); 
        }

        [WebMethod]
        public List<C_MICRO> Donne_Liste_Micro()
        {
            return La_Base.Get_Micro();
        }

        [WebMethod]
        public List<C_CLIENT> Donne_Liste_Client()
        {
            return La_Base.Get_Client();
        }

        [WebMethod]
        public List<C_GUITARE> Donne_Liste_Guitare()
        {
            return La_Base.Get_Guitare();
        }
    }
}

