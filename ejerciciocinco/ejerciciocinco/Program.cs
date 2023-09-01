/* Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.*/

public class Ejercicio5
{
    static void Main(string[] args)
    {
        double catetoA, catetoB, hipotenusa;

        Console.Write("Ingrese el valor de el cateto A: ");
        catetoA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el valor del cateto B: ");
        catetoB = Convert.ToDouble(Console.ReadLine());

        hipotenusa = (Math.Sqrt((Math.Pow(catetoA, 2)) + (Math.Pow(catetoB, 2))));

        Console.Write("El valor de la hipotenusa es:" +  hipotenusa);


    }






}

