using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class PresDB
    { //Testar
        private static List<Pres> lstPres = new List<Pres>();

        public PresDB()
        {
            //Implementar
        }

        public bool Salvar(Pres pres)
        {
            try
            {
                lstPres.Add(pres);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public List<Pres> ConsultarTudo()
        {
            return lstPres;
        }
    }
}
