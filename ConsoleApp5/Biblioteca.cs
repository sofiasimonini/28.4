using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Biblioteca
    {
        public string  Nome { get; set; }
        public List<Documento> Documenti {  get; set; }
        public List<Prestito> Prestiti { get; set; }
        public List<Utente> Utenti { get; set; }

        public Documento CercaDocumento (string codice)
        {
            foreach (Documento documento in Documenti)
            {
                if (documento.Codice == codice)
                    return documento;
                else
                    return null;
            }

        }
        public Documento CercaDocumentoTitolo (string titolo)
        {
            foreach(Documento documento in Documenti)
            {
                if (documento.Titolo == titolo)
                    retrun documento;
                else return null;
            }

        }

        public void RegistraPrestito (Utente utente, Documento documento, DateTime Dal, DateTime Al)

        {
            Prestito nuovoPrestito = new Prestito(); 
            Prestiti.Add (nuovoPrestito);
        }
        public Prestito CercaPrestito (string nome, string cognome)
        {
            foreach (Prestito prestito in Prestiti )
            { if (prestito.Utente.Nome == nome && prestito.Utente.Cognome== cognome)
                    return prestito;
             else 
                    return null;
            }

        }
    }   

}
