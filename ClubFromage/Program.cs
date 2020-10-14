using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


using ClubFromage.model.Data;
using ClubFromage.model.Business;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAL clubfromage = new DBAL();
            string requetesql;
            
            ////clubfromage.Insert(requetesql);
            //requetesql = "SELECT * FROM Pays;";
            ////clubfromage.Select(requetesql);
            //requetesql = " Pays SET nom = 'Brezil' WHERE id=1 ;";
            ////clubfromage.Update(requetesql);
            //requetesql = " Pays WHERE idPays = 1;";
            ////clubfromage.Delete(requetesql);

            //requetesql = " Pays VALUES (1,'France');";
            //requetesql = "delete * FROM Pays;";
            //requetesql = " Pays SET nom = 'Brezil' WHERE idPays=1 ;";
            //requetesql = " Pays WHERE idPays = 1;";
            //clubfromage.Delete(reque
            //Pays unPays = new Pays(4, "Belgique");
            daoPays undaoPays = new daoPays(clubfromage);
            daoFromage undaoFromage = new daoFromage(clubfromage);

            //daoFromage undaofromage = new daoFromage(clubfromage, undaoPays);
            //undaoPays.Insert(unPays);
            //DateTime unedate = new DateTime(0 , 0 , 0,15,0,0);
            //DateTime uneautredate = new DateTime(2000, 5, 25);
            //Console.WriteLine(unedate);
            ///DateTime DureeAffinage = new DateTime(0, 0, 0, 15, 0, 0);
            ///DateTime DateCreation = new DateTime(2000, 5, 25);
            ///Fromage camenbert = new Fromage(15, 4, "camenbert", DureeAffinage,DateCreation, "le lait ...", "un laitier ...");
            //undaoPays.Delete(unPays);
            //unPays.setNom("France");
            //undaoPays.Update(unPays);
            ///undaofromage.Insert(camenbert);
            //undaoPays.InsertByFile("D:\\Maël\\ClubFrom\\ClubFromage\\bin\\Debug\\pays.csv");

            //Test RQuery
            DataSet dataS = clubfromage.RQuery("select * from Pays");
            foreach (DataRow p in dataS.Tables[0].Rows)
            {
                System.Console.WriteLine(p["nom"]);
            }
            Console.WriteLine("---------------------------");

            //Test SelectAll
            foreach (DataRow r in clubfromage.SelectAll("Pays").Rows)
            {
                System.Console.WriteLine(r["nom"]);
            }

            Console.WriteLine("---------------------------");

            ////Test SelectByField
            foreach (DataRow r in clubfromage.SelectByField("Pays", "nom like 'O%'").Rows)
            {
                System.Console.WriteLine(r["nom"]);
            }

            Console.WriteLine("---------------------------");

            //Test SelectByID
            //foreach (DataRow r in clubfromage.SelectById("Pays", 38))
            DataRow x = clubfromage.SelectById("Pays", 38);
                System.Console.WriteLine(x["nom"]);



            Console.ReadLine();
        }
    }
}
