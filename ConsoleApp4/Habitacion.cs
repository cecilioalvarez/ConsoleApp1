using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Habitacion : Encendible
    {

        public List<Encendible> encendibles = new List<Encendible>();
        public void Off() 
        {

            foreach (Encendible encendible in encendibles)
            {
                encendible.Off();
            }
        }

        public void On()
        {
            foreach (Encendible encendible in encendibles)
            {
                encendible.On();
            }
        }

        public void AddEncendible(Encendible encendible)
        {
            encendibles.Add(encendible);
        }
    }
}
