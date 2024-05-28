using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Data.Models
{
    public class Fate
    {
        //Representacion de la clase============================================================================================
        public int ID { get; set; }
        public string Servant { get; set; }
        public string Classe { get; set; }
        public byte Lv {  get; set; }
        public string Noble_Phantams { get; set; }
        public string NPEffect { get; set; }
        public string Gender { get; set; }
        public DateTime InvocationDate { get; set; }
        public string Description { get; set; }
        public bool Activate { get; set; }
        public bool validacion { get; set; }

        //Constructor sin paramentros===========================================================================================
        public Fate() { }

        //Constructor con paramentros===========================================================================================
        public Fate(int id, string servant, string classe, byte lv, string noblePhantams, string npEffect, string gender, DateTime invocationDate, string description, bool activate)
        {
            ID = id;
            Servant = servant;
            Classe = classe;
            Lv = lv;
            Noble_Phantams = noblePhantams;
            NPEffect = npEffect;
            Gender = gender;
            InvocationDate = invocationDate;
            Description = description;
            Activate = activate;
        }

        //Con esto limpio para manejar mejor todo===============================================================================
        public void RestablecerUsr()
        {
            Servant = string.Empty;
            Classe = string.Empty;
            Lv = 0;
            Noble_Phantams = string.Empty;
            NPEffect = string.Empty;
            Gender = string.Empty;
            InvocationDate = default(DateTime);
            Description = string.Empty;
            Activate = false;
            validacion = false;
        }
    }
}
