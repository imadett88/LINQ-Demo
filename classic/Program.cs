using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        // Liste d'exemple d'entiers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Requête LINQ pour sélectionner les nombres pairs
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Nombres pairs :");

        // Parcours du résultat de la requête LINQ
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Syntaxe de méthode LINQ pour sélectionner les nombres impairs
        var oddNumbers = numbers.Where(num => num % 2 != 0);

        Console.WriteLine("\nNombres impairs :");

        // Parcours du résultat de la syntaxe de méthode LINQ
        foreach (var num in oddNumbers)
        {
            Console.WriteLine(num);
        }

        // Requête LINQ pour ordonner les nombres par ordre décroissant
        var descendingOrder = from num in numbers
                              orderby num descending
                              select num;

        Console.WriteLine("\nNombres en ordre décroissant :");

        // Parcours du résultat de la requête LINQ
        foreach (var num in descendingOrder)
        {
            Console.WriteLine(num);
        }

        // Syntaxe de méthode LINQ pour trouver le premier nombre supérieur à 5
        var firstGreaterThanFive = numbers.First(num => num > 5);

        Console.WriteLine($"\nPremier nombre supérieur à 5 : {firstGreaterThanFive}");

        // Requête LINQ pour sélectionner les nombres entre 3 et 7
        var betweenThreeAndSeven = from num in numbers
                                   where num > 3 && num < 7
                                   select num;

        Console.WriteLine("\nNombres entre 3 et 7 :");

        // Parcours du résultat de la requête LINQ
        foreach (var num in betweenThreeAndSeven)
        {
            Console.WriteLine(num);
        }
    }
}
