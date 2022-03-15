using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BASE
{
    public class C_BASE
    {
        C_BASE_AZURE La_Base_Azure = new C_BASE_AZURE();

        //--------------LISTE------------//

        public List<C_VIBRATO> Get_Vibrato()
        {
            return La_Base_Azure.Les_Vibratos.ToList();
        }

        public List<C_CLIENT> Get_Client()
        {
            return La_Base_Azure.Les_Clients.ToList();
        }

        public List<C_MICRO> Get_Micro()
        {
            return La_Base_Azure.Les_Micros.ToList();
        }

        public List<C_GUITARE> Get_Guitare()
        {
            return La_Base_Azure.Les_Guitares.ToList();
        }
        public List<C_BOIS> Get_Bois()
        {
            return La_Base_Azure.Les_Bois.ToList();
        }
        //--------------BOIS------------//

        public List<C_BOIS> Find_Bois(string P_Nom)
        {
            var Requete = from un_bois in La_Base_Azure.Les_Bois where un_bois.Nom.Contains(P_Nom) select un_bois;
            return Requete.ToList();
        }

        //----------------------------------------//

        public void Add_Bois(string P_Nom, string P_Origine = "Non spécifié")
        {
            C_BOIS Nouveau_Bois = new C_BOIS() { Nom = P_Nom, Origine = P_Origine };
            La_Base_Azure.Les_Bois.Add(Nouveau_Bois);
            La_Base_Azure.SaveChanges();
        }

        //----------------------------------------//

        public void Add_Bois(C_BOIS P_Bois)
        {
            La_Base_Azure.Les_Bois.Add(P_Bois);
            La_Base_Azure.SaveChanges();
        }

        //----------------------------------------//

        public void Delete_Bois(C_BOIS P_Bois)
        {
            La_Base_Azure.Entry(P_Bois).State = System.Data.Entity.EntityState.Unchanged;
            La_Base_Azure.Les_Bois.Remove(P_Bois);
            La_Base_Azure.SaveChanges();
        }

        //----------------------------------------//


        public void Update_Bois(C_BOIS P_Bois)
        {
            C_BOIS Le_Bois = (from un_bois in La_Base_Azure.Les_Bois where un_bois.idBois == P_Bois.idBois select un_bois).FirstOrDefault();

                if (Le_Bois != null)
            {
                Le_Bois.Nom = P_Bois.Nom;
                Le_Bois.Origine = P_Bois.Origine;
                La_Base_Azure.SaveChanges();
            }
        }


        //-------------MICRO-----------//

        public void Add_Micro(string P_Nom, string P_Marque, string P_Ref_Constructeur)
        {
            C_MICRO Nouveau_Micro = new C_MICRO() { nom = P_Nom, marque = P_Marque, ref_constructeur = P_Ref_Constructeur };
            La_Base_Azure.Les_Micros.Add(Nouveau_Micro);
            La_Base_Azure.SaveChanges();
        }

        public void Delete_Micro(C_MICRO P_Micro)
        {
            La_Base_Azure.Entry(P_Micro).State = System.Data.Entity.EntityState.Unchanged;
            La_Base_Azure.Les_Micros.Remove(P_Micro);
            La_Base_Azure.SaveChanges();
        }

        public List<C_MICRO> Find_Micro(string P_Nom)
        {
            var Requete = from un_micro in La_Base_Azure.Les_Micros where un_micro.nom.Contains(P_Nom) select un_micro;
            return Requete.ToList();
        }

        public void Update_Micro(C_MICRO P_Micro)
        {
            C_MICRO Le_Micro = (from un_micro in La_Base_Azure.Les_Micros where un_micro.idMicro == P_Micro.idMicro select un_micro).FirstOrDefault();

            if (Le_Micro != null)
            {
                Le_Micro.nom = P_Micro.nom;
                Le_Micro.marque = P_Micro.marque;
                Le_Micro.ref_constructeur = P_Micro.ref_constructeur;
                La_Base_Azure.SaveChanges();
            }
        }

        //-------------VIBRATO----------//
        public void Add_Vibrato(string P_Nom, string P_Modele, string P_Marque)
        {
            C_VIBRATO Nouveau_Vibrato = new C_VIBRATO() { nom = P_Nom, marque = P_Marque, modele = P_Modele };
            La_Base_Azure.Les_Vibratos.Add(Nouveau_Vibrato);
            La_Base_Azure.SaveChanges();
        }
        public void Delete_Vibrato(C_VIBRATO P_Vibrato)
        {
            La_Base_Azure.Entry(P_Vibrato).State = System.Data.Entity.EntityState.Unchanged;
            La_Base_Azure.Les_Vibratos.Remove(P_Vibrato);
            La_Base_Azure.SaveChanges();
        }

        public List<C_VIBRATO> Find_Vibrato(string P_Nom)
        {
            var Requete = from un_vibrato in La_Base_Azure.Les_Vibratos where un_vibrato.nom.Contains(P_Nom) select un_vibrato;
            return Requete.ToList();
        }

        public void Update_Vibrato(C_VIBRATO P_Vibrato)
        {
            C_VIBRATO Le_Vibrato = (from un_vibrato in La_Base_Azure.Les_Vibratos where un_vibrato.idVibrato == P_Vibrato.idVibrato select un_vibrato).FirstOrDefault();

            if (Le_Vibrato != null)
            {
                Le_Vibrato.nom = P_Vibrato.nom;
                Le_Vibrato.marque = P_Vibrato.marque;
                Le_Vibrato.modele = P_Vibrato.modele;
                La_Base_Azure.SaveChanges();
            }
        }
        //------------GUITARE-------------//

        public void Add_Guitare(string P_Nom, string P_Manche, string P_Touche, string P_Micro)
        {
            C_GUITARE Nouvelle_Guitare = new C_GUITARE() { nom = P_Nom, manche = P_Manche, touche = P_Touche, micro = P_Micro };
            La_Base_Azure.Les_Guitares.Add(Nouvelle_Guitare);
            La_Base_Azure.SaveChanges();
        }

        public void Delete_Guitare(C_GUITARE P_Guitare)
        {
            La_Base_Azure.Entry(P_Guitare).State = System.Data.Entity.EntityState.Unchanged;
            La_Base_Azure.Les_Guitares.Remove(P_Guitare);
            La_Base_Azure.SaveChanges();
        }

        public List<C_GUITARE> Find_Guitare(string P_Nom)
        {
            var Requete = from une_guitare in La_Base_Azure.Les_Guitares where une_guitare.nom.Contains(P_Nom) select une_guitare;
            return Requete.ToList();
        }

        public void Update_Guitare(C_GUITARE P_Guitare)
        {
            C_GUITARE Une_Guitare = (from une_guitare in La_Base_Azure.Les_Guitares where une_guitare.idGuitare == P_Guitare.idGuitare select une_guitare).FirstOrDefault();

            if (Une_Guitare != null)
            {
                Une_Guitare.nom = P_Guitare.nom;
                Une_Guitare.corps = P_Guitare.corps;
                Une_Guitare.manche = P_Guitare.manche;
                Une_Guitare.touche = P_Guitare.touche;
                Une_Guitare.micro = P_Guitare.micro;
                Une_Guitare.vibrato = P_Guitare.vibrato;
                Une_Guitare.bridge = P_Guitare.bridge;
                Une_Guitare.centrale = P_Guitare.centrale;
                Une_Guitare.neck = P_Guitare.neck;
                La_Base_Azure.SaveChanges();
            }
        }


        //------------Clients-------------//

        public void Add_Client(string P_Nom, string P_Prenom, string P_Adresse, string P_Ville)
        {
            C_CLIENT Nouveau_Client = new C_CLIENT() { nom = P_Nom, prenom = P_Prenom, adresse = P_Adresse, ville = P_Ville };
            La_Base_Azure.Les_Clients.Add(Nouveau_Client);
            La_Base_Azure.SaveChanges();
        }

        public void Delete_Client(C_CLIENT P_Client)
        {
            La_Base_Azure.Entry(P_Client).State = System.Data.Entity.EntityState.Unchanged;
            La_Base_Azure.Les_Clients.Remove(P_Client);
            La_Base_Azure.SaveChanges();
        }

        public List<C_CLIENT> Find_Client(string P_Nom)
        {
            var Requete = from un_client in La_Base_Azure.Les_Clients where un_client.nom.Contains(P_Nom) select un_client;
            return Requete.ToList();
        }

        public void Udate_Client(C_CLIENT P_Client)
        {
            C_CLIENT Un_Client = (from un_client in La_Base_Azure.Les_Clients where un_client.idClient == P_Client.idClient select un_client).FirstOrDefault();

            if (Un_Client != null)
            {
                Un_Client.nom = P_Client.nom;
                Un_Client.prenom = P_Client.prenom;
                Un_Client.adresse = P_Client.adresse;
                Un_Client.ville =   P_Client.ville;
                La_Base_Azure.SaveChanges();
            }
        }



    }
}
