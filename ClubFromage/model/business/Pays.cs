using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubFromage.model.Data;
using ClubFromage.model.Business;

namespace ClubFromage.model.Business
{
    class Pays
    {
        private int _idPays;
        private string _nom;


        public Pays()
        {
            _idPays = 0;
            _nom = "";
        }


        public Pays(int unIdPays , string unNomPays)
        {
            _idPays = unIdPays;
            _nom = unNomPays;
        }

        public int idPays { get => _idPays; set => _idPays = value; }
        public string nom { get => _nom; set => _nom = value; }


        public int getIdPays()
        {
            return idPays;

        }

        public string getNom()
        {
            return nom;
        }

        public void setIdPays(int unIdPays)
        {
            idPays = unIdPays;
        }

        public void setNom(string unNom)
        {
            nom = unNom;
        }
    }
}
