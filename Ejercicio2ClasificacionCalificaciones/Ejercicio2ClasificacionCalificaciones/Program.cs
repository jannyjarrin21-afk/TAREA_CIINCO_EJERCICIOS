using System;

class Program
{
    static void Main()
    {
        int nota;

        Console.WriteLine("Ingrese su calificacion (0 al 10):");
        nota = int.Parse(Console.ReadLine());

        switch (nota)
        {
            case 10:
                Console.WriteLine("Excelente, obtuvo la nota maxima");
                break;

            case 9:
                Console.WriteLine("Muy bien, excelente trabajo");
                break;

            case 8:
                Console.WriteLine("Buen trabajo, siga esforzandose");
                break;

            case 7:
                Console.WriteLine("Aprobado, puede mejorar");
                break;

            case 6:
                Console.WriteLine("No aprobo la materia");
                break;

            default:
                Console.WriteLine("Calificacion no valida o reprobada");
                break;
        }

        Console.ReadKey();
    }
}