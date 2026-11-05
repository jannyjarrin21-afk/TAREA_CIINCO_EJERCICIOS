using System;

class Program
{
    static void Main()
    {
        int repeticiones9 = 5;

        // Uso de DO WHILE

        switch (7)
        {
            case 7:
                Console.WriteLine("Paso la materia con grado REGULAR");

                do
                {
                    Console.WriteLine(repeticiones9.ToString());

                    repeticiones9--;

                } while (repeticiones9 >= 3);

                break;

            default:
                Console.WriteLine("No paso la materia");
                break;
        }

        Console.ReadKey();
    }
}