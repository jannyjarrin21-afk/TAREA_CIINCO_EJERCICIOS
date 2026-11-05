using System;

class Program
{
    static void Main()
    {
        decimal promedio;
        int repeticiones = 5;

        Console.WriteLine("Ingrese el promedio del estudiante:");
        promedio = decimal.Parse(Console.ReadLine());

        switch ((int)promedio)
        {
            case 10:
                Console.WriteLine("Pasaste con grado EXCELENTE");

                for (int i = 0; i <= 5; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Lo hiciste muy bien");
                            break;
                        case 1:
                            Console.WriteLine("Debes apoyar a tus compañeros");
                            break;
                        case 2:
                            Console.WriteLine("Estas EXONERADO");
                            break;
                        case 3:
                            Console.WriteLine("Ya puedes ir a casa");
                            break;
                        case 4:
                            Console.WriteLine("Sigue esforzandote");
                            break;
                        case 5:
                            Console.WriteLine("Excelente trabajo");
                            break;
                    }
                }
                break;

            case 9:
                Console.WriteLine("Pasaste con grado MUY BUENO");

                while (repeticiones >= 0)
                {
                    Console.WriteLine("Repeticion: " + repeticiones);
                    repeticiones--;
                }
                break;

            case 8:
                Console.WriteLine("Pasaste con grado BUENO");
                break;

            case 7:
                Console.WriteLine("Pasaste con grado REGULAR");

                do
                {
                    Console.WriteLine("Repeticion: " + repeticiones);
                    repeticiones--;
                }
                while (repeticiones >= 3);
                break;

            default:
                Console.WriteLine("No pasaste la materia");

                for (int i = 0; i <= 1; i++)
                {
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Preparáte para el mejoramiento");
                            break;

                        case 1:
                            Console.WriteLine("Es hora de estudiar");
                            break;
                    }
                }
                break;
        }

        Console.ReadKey();
    }
}