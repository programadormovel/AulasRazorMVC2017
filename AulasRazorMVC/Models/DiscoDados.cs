using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AulasRazorMVC.Models
{
    public class DiscoDados
    {

        public List<Disco> listaDisco = new List<Disco>();
        
        public DiscoDados()
        {
            listaDisco.Add(new Disco
            {
                disco = "Dois",
                artista = "Legião Urbana",
                faixas="13"
            });
            listaDisco.Add(new Disco
            {
                disco = "Titanomaquia",
                artista = "Titãs",
                faixas = "13"
            });
            listaDisco.Add(new Disco
            {
                disco = "Os Grãos",
                artista = "Paralamas do Sucesso",
                faixas = "7"
            });
        }
        public void CriaDiscos(Disco discos)
        {
            listaDisco.Add(discos);
        }

        public bool ApagaDisco(string id)
        {
            foreach(Disco discox in listaDisco)
            {
                if(discox.disco == id)
                {
                    listaDisco.Remove(discox);
                    return true;
                }
            }
            return false;
        }
        public void AtualizaDisco(Disco discos)
        {
            foreach (Disco discox in listaDisco)
            {
                if (discox.disco == discos.disco)
                {
                    listaDisco.Remove(discox);
                    listaDisco.Add(discos);
                    break;
                }
            }
        }
    }
}