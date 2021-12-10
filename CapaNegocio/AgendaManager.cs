using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class AgendaManager
    {
        public DataManager dataManager;

        public List<Agenda> GetAgenda() 
        {
            dataManager = new DataManager();
            return dataManager.GetFromDb();
        }

        public List<Agenda> GetAgenda(Agenda agenda)
        {
            dataManager = new DataManager();
            return dataManager.GetFromDb(new Agenda() { Id_Agenda = agenda .Id_Agenda });
        }

        public List<Agenda> LookAgenda(string param) 
        {
            dataManager = new DataManager();
            return dataManager.LookAgenda(param);
        }

        public void PutAgenda(Agenda agenda, int opt) 
        {
            dataManager = new DataManager();
            dataManager.PutToDB(agenda, opt);
        }
    }
}
