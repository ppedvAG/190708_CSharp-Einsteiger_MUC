using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Buch
    {
        // Felder 
        // Klassenintern
        private string titel;
        private Person autor;
        private string isbn;
        private int kapitel;


        // Eigenschaft
        // Zugriff von außen

        public string ISBN
        {
            get
            {
                return isbn;
            }
            private set
            {
                    isbn = value;                
            }
        }

        public float Preis;
        public string Titel
        {
            get
            {
                return titel;
            }
            private set
            {
                titel = value;
            }
        }

        public Person Autor
        {
            get
            {
                return autor;
            }
        }

        public int Kapitel { get => kapitel; set => kapitel = value; }
        public int Seiten { get; set; }

        public Buch()
        {
            titel = "";
        }

        public Buch(Person autor)
        {
            this.autor = autor;
        }


        //public string GetTitel()
        //{
        //    return titel;
        //}
        //public void SetTitel(string value)
        //{
        //    titel = value;
        //}

        enum genre { Roman, Krimi, Fachbuch };
    }
}
