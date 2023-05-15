using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Czas
    {
        public int s = 0;
        public int m = 0;
        public int h = 0;

        Czas()
        {
            s = 0;
            m = 0;
            h = 0;
        }
        
        void wyswietl()
        {
            Console.WriteLine(s + " " + m + " " + h);
        }

        void ZwiekszMinuty(int oIle)
        {
            ZwiekszGodziny((h + oIle) / 60);
            m = (m + oIle) % 60;
        }

        void ZwiekszSekundy(int oIle)
        {
            ZwiekszMinuty((m + oIle) / 60);
            s = (s + oIle) % 60;
        }

        void ZwiekszGodziny(int oIle)
        {
            this.h = (this.h + oIle) % 24;
        }
    }
}
