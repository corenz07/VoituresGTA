using System.Runtime.CompilerServices;

namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    private static void DisplayCars(string[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine((i + 1) + " : " + cars[i]);
        }
    }
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        
        for(int i = 0; i< cars.Length; i++)
        {
            Console.WriteLine((i +1)+ " : " + cars[i]);
        }
        Console.WriteLine("Quel véhicule souhaitez-vous remplacer ? (entrez le numéros de votre choix)");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Veuillez donner le nom du véhicule qui remplacera " + cars[choice-1] + " ?");
        string newCar = Console.ReadLine();
        cars[choice-1] = newCar;
        DisplayCars(cars);
    }
}