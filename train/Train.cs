using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Train
    {
        Vagon[] sostav;
        public int i;
       public int a;
       
        


        public  Train( int a)
        {
            sostav= new Vagon[a];
            

        }
        public void FillIn(string b, int i)
        {
            for (i = 0; i < a; i++)
            {
                if (b == "да")
                    sostav[i].mass = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutOut( int mass, int a, int i)

        {
           
            for (i=0; i<a ;i++)
            {
                Console.WriteLine($"Вагон № {i} отправляется с грузом массой =" , mass );
            }
        }
           

            




    }

   

} 

