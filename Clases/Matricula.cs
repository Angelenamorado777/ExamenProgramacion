using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

public class Matricula : ICalcularNota
{

    public string? Alumno { get; set; }

    public string? Asignatura { get; set; }

    public List<double> NotasParciales { get; set; }

    public Matricula()
    {

        NotasParciales = new List<double>();
    }

    public double CalcularNotaFinal()
    {
        double suma = 0;
        foreach (var nota in NotasParciales)
        {

            suma += nota;

        }
        return suma;

    }


    public double CalcularNotaFinal(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3);

    }
    public string ObtenerMensajeNota(double notaFinal)
    {

        if (notaFinal < 60)
            return "Reprobado";
        else if (notaFinal < 80)
            return "Bueno";
        else if (notaFinal < 90)
            return "Muy Bueno";
        else
            return "Sobresaliente";
    }


    public void ValidarNotas(double n1, double n2, double n3)
    {
        if ((n1 + n2) > 30)
        {
            throw new ArgumentException("la suma de las dos primeras notas no pueden ser mayor a 30");
        }

        if (n3 > 40)
        {
            throw new ArgumentException("la tercera nota no tiene que ser mayor a 40");
        
        }
    }
}
   
 
