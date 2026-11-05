using System;
class Program
{
    static void Main()
    {
        decimal primerParcial = 0;
        decimal segundoParcial = 0;
        decimal promedio = 0;
        decimal suma = 0;

        // Bucle FOR para pedir las 2 notas
        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine("Ingrese su nota del Parcial (" + i + "):");
            decimal nota = decimal.Parse(Console.ReadLine());

            if (i == 1)
                primerParcial = nota;
            else
                segundoParcial = nota;

            suma += nota;
        }

        promedio = suma / 2;

        Console.WriteLine("Su promedio final es: " + promedio);

        if (promedio >= 8 && promedio <= 10)
        {
            Console.WriteLine("Pasaste la materia con grado Excelente");
        }
        else if (promedio >= 7)
        {
            Console.WriteLine("Pasaste la materia con grado Bueno");
        }
        else
        {
            Console.WriteLine("No pasaste la materia");
        }
    }
}
