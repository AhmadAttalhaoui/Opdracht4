using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class TeDoen
    {
        public static int Id { get; set; }
        public static int counter = 0;
        public string Title { get; set; }
        public DateTime Tijdstip {  get; set; }
        public string[] Informatie {  get; set; }
        

        public TeDoen(string title, string[] informatie)
        {
            counter = Id;
            Title = title;
            counter++;
            Informatie = informatie;
        }

        public TeDoen(string title, DateTime tijdstip, string[] informatie)
        {
            Title = title;
            Tijdstip = tijdstip;
            Informatie = informatie;
        }

        public override string ToString()
        {
            return "id: " + Id +" Title: " +  Title +" info: " +  Informatie;
        }

        public delegate void ToonMij(string Title, string[] Informatie, Boolean dringend);
        public event ToonMij ToonMijEvent;
            

    }
    }

