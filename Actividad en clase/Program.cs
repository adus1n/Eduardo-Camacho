using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_en_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre_alumno, matricula, semestre, seccion, materia;
            int calificacion;

            Console.WriteLine("Ingrese su nombre completo por favor");
            nombre_alumno = Console.ReadLine();
            Console.WriteLine("Ingrese su matricula por favor");
            matricula = Console.ReadLine();
            Console.WriteLine("Semestre que esta cursando");
            semestre = Console.ReadLine();
            Console.WriteLine("Seccion");
            seccion = Console.ReadLine();
            Console.WriteLine("matreria cursada");
            materia = Console.ReadLine();
            Console.WriteLine("ingresa tu calificacion");
            calificacion = Convert.ToInt16(Console.Read());

            if (calificacion >= 70)
            {
                Console.WriteLine("felicidades aprobaste el semestre!!!!");
                Console.WriteLine("disfruta tus vacaciones");
                Console.ReadKey();
            }

            else 
            {
                Console.WriteLine("lo siento no has pasado el semestere:c");
                Console.WriteLine("nos vemos en vacaciones:c");
                Console.ReadKey();
            }






            


            
            

            

            
        
           

          
            


            
        }

        
    }
}
