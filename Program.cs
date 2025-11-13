class Program
{

    static void Main()
    {
        string Nombre = "Angel Alberto Enamorado Rápalo";
        string Numerocuenta = "T32521113";
        string Email = "angel.enamorado@unah.hn";
        string Asignatura = "Programación II";

        Matricula matricula = new Matricula
        {
            Alumno = $"{Nombre} ({Numerocuenta}) - {Email}",
            Asignatura = Asignatura
        };

        Console.WriteLine("Ingrese las tres notas:");
        Console.Write("Nota 1: ");
        double n1 = double.Parse(Console.ReadLine()!);
        Console.Write("Nota 2: ");
        double n2 = double.Parse(Console.ReadLine()!);
        Console.Write("Nota 3: ");
       double n3 = double.Parse(Console.ReadLine()!);


        try
        {
            matricula.ValidarNotas(n1, n2, n3);

            matricula.NotasParciales.Add(n1);
            matricula.NotasParciales.Add(n2);
            matricula.NotasParciales.Add(n3);

            double notaFinal1 = matricula.CalcularNotaFinal(); 
            double notaFinal2 = matricula.CalcularNotaFinal(n1, n2, n3);

            Console.WriteLine($"Alumno: {matricula.Alumno}");
            Console.WriteLine($"Asignatura: {matricula.Asignatura}");
            Console.WriteLine($"Nota Final (metodo sin parámetros): {notaFinal1:F2} - {matricula.ObtenerMensajeNota(notaFinal1)}");
            Console.WriteLine($"Nota Final (metodo con parámetros): {notaFinal2:F2} - {matricula.ObtenerMensajeNota(notaFinal2)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError en las notas {ex.Message}");
        }
    }
} 
