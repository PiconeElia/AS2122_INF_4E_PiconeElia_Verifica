using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_INF_4E_PiconeElia_Verifica
{
        class Articolo
        {
            string codice;
            string descrizione;
            string unitaDiMisura;
            double prezzo;
        
        //costruttore
            public Articolo(string codice, string descrizione, string unitaDiMisura, double prezzo)
            {
                this.codice = codice;
                this.descrizione = descrizione;
                this.unitaDiMisura = unitaDiMisura;
                this.prezzo = prezzo;
            }
        
        //metodi
            public string Codice 
        { get { return codice; } }
            public string Descrizione 
        { get { return descrizione; } }
            public string UnitaDiMisura 
        {get { return unitaDiMisura; } }
            public double Prezzo
        { get { return prezzo; } }
        //override
        public string Visualizzati()
        {
            return $"{descrizione} {unitaDiMisura} {prezzo} ({codice})";
        }
    }  
}
