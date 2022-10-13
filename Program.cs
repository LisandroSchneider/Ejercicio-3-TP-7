using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            float mayorTemperatura=0,menorTemperatura=999,temperaturaDelDia,diaMenor=0,diaMayor=0;
            Console.Clear();
            
            for(int i=1;i<=7;i++)
            {
                Console.WriteLine("Digite la temperatura del {0}° dia: ",i);
                temperaturaDelDia = float.Parse(Console.ReadLine());
                
                if(temperaturaDelDia<menorTemperatura)
                {
                    menorTemperatura = temperaturaDelDia;
                    diaMenor=i;
                }

                if(temperaturaDelDia>mayorTemperatura)
                {
                    mayorTemperatura = temperaturaDelDia;
                    diaMayor = i;
                }

                
            }
            Console.Clear();
            
            
            Console.WriteLine("La menor  temperarura registrada es:{0}° el dia:{1}",menorTemperatura,diaMenor);
            Console.WriteLine("La mayor  temperarura registrada es:{0}° el dia:{1}",mayorTemperatura,diaMayor);












        }
    }
}
