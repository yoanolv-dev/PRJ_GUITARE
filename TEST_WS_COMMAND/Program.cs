using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TEST_WS_COMMAND.NS_WS_LOCAL;

namespace TEST_WS_COMMAND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WS_GUITARESoapClient Le_WS = new WS_GUITARESoapClient();

            var message = Le_WS.GetDate();
            Console.WriteLine(message);

            var liste_bois = Le_WS.Donne_Liste_Bois();
            foreach (var element in liste_bois)
            {
                Console.WriteLine(element.idBois);
            }

        }
    }
}
