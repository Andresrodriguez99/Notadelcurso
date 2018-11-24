using System;

namespace notasdelcurso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantos estudiantes hay en el curso?: ");
            int NumerodeEstudiantes = Convert.ToInt32(Console.ReadLine());
            string[] estudiantes = new string[NumerodeEstudiantes];

            Console.Write("Cuantos cortes son?:");
            int cortes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese las notas totales por corte:");
            int Notasdelcorte = Convert.ToInt32(Console.ReadLine());

            int Columnas = cortes * Notasdelcorte + 1;
            
            double[,] notasFinales = new double[NumerodeEstudiantes,Columnas];
            
            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.Write($"Ingrese el nombre del {i + 1} estudiante: ");
                estudiantes[i] = Console.ReadLine();
                Console.WriteLine();
            }
            double Promediodelcurso = 0;
            for (int i = 0; i < NumerodeEstudiantes; i++)
            {
                string notasdelestudiante = estudiantes[i];
                Console.WriteLine($"Ingrese las notas del estudiante: {notasdelestudiante}");
                
                double Promediodelestudiante = 0;
               
                for (int j = 0; j < Columnas; j++)
                {
    
                    if (j == Columnas - 1)
                    {
                        notasFinales[i, j] = Promediodelestudiante / (cortes * Notasdelcorte);
                        Promediodelcurso = ((Promediodelestudiante  / (NumerodeEstudiantes)));
                    }
                    else
                    {
                        Console.Write($"{j + 1} Nota del estudiante {notasdelestudiante}:");
                        double nota = Convert.ToDouble(Console.ReadLine());
                        notasFinales[i, j] = nota;
                        Promediodelestudiante += nota;
                    }
                    
                }
            }

            Console.WriteLine();
            Console.WriteLine("Nota final: ");
           
            for (int i = 0; i < NumerodeEstudiantes; i++)
            {
                string notafinal = estudiantes[i];
               
                
                Console.Write(notafinal + " ");

                Console.WriteLine();

                for (int j = 0; j < Columnas; j++)
                {
                    
                    Console.Write(notasFinales[i,j] + " ");
                
                
                if (notasFinales[i,j]>=3)
                {
                    Console.WriteLine("Pasaste ");
                }  
                else
                {
                    Console.WriteLine("Perdiste ");
                }
        
                Console.WriteLine();
                
                }
            }
            
            Console.WriteLine($"El promedio del curso es: {Promediodelcurso} ");
             
            Console.Read();
            

        }
    }
}
