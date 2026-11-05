using System;

class Program
{
    static void Main()
    {
        int repeticiones9 = 5;

        // Ejercicio 4: Uso de SWITCH y WHILE

        switch (9)
        {
            case 9:
                Console.WriteLine("Pasó la materia con grado MUY BUENO");

                while (repeticiones9 >= 0)
                {
                    switch (repeticiones9)
                    {
                        case 0:
                            Console.WriteLine("Ya en serio, supéralo");
                            break;

                        case 1:
                            Console.WriteLine("Ya deje de quejarse y póngase la cena para el curso");
                            break;

                        case 2:
                            Console.WriteLine("A llorar al parque");
                            break;

                        case 3:
                            Console.WriteLine("Ya supéralo, tienes buena nota, no eres Dios para tener 10");
                            break;

                        case 4:
                            Console.WriteLine("No, no hay trabajos extra para subir notas");
                            break;

                        case 5:
                            Console.WriteLine("En hora buena, sacaste una buena nota");
                            break;
                    }

                    repeticiones9--;
                }

                break;

            default:
                Console.WriteLine("No pasó la materia");
                break;
        }

        Console.ReadKey();
    }
}