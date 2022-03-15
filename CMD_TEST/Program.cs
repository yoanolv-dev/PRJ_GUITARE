using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB_BASE;

namespace CMD_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C_BASE La_Base = new C_BASE();

            //La_Base.Add_Bois($"Bois XXXX", "Origine XXX");
            //La_Base.Add_Bois("grr");

            var Liste_Bois = La_Base.Get_Bois();
            Console.WriteLine(Liste_Bois.Count());

            foreach (C_BOIS Un_Bois in Liste_Bois)
                Console.WriteLine($"{Un_Bois.idBois} {Un_Bois.Nom} {Un_Bois.Origine}");


            Console.WriteLine("============================");
            var resultat = La_Base.Find_Bois("Bois");

            foreach (C_BOIS Un_Bois in resultat)
            {
                Console.WriteLine($"{Un_Bois.idBois} {Un_Bois.Nom} {Un_Bois.Origine}");
            }

            //La_Base.Add_Guitare($"Guitare XXX", "Manche XXXX");
            La_Base.Add_Client($"Nom XXXX", "Prenom XXXX", "Adresse XXXX", "Ville XXXX");

            var Liste_Clients = La_Base.Get_Client();
            Console.WriteLine(Liste_Clients.Count());

            var Liste_Guitare = La_Base.Get_Guitare();
            Console.WriteLine(Liste_Guitare.Count()); ;
        }
    }
}
