using static System.Console;
using ANIMALS;

static class Program
{
    static void Main()
    {
        Lapin Moussa = new Lapin("Moussa", 10); // Premier lapin créé
        Lapin Barda = new Lapin("Barda", 15); // Deuxième lapin créé
        Tortue Ninja = new Tortue("Tortue Ninja", 100, 5); // Tortue créée
        Tortue Gaba = new Tortue("Tortue Gaba", 100, 35); // Tortue créée

        Animal[] animaux = { Moussa, Barda, Ninja, Gaba }; // Tableau pour stocker les animaux

        for(int i=0; i<100; i++)
        {
            foreach(Animal animal in animaux)
            {
                animal.Avancer(); // Chaque animal avance
            }
        }
        WriteLine("Course terminée");
        Animal animalGagnant = GetAnimalGagnant(animaux); // Par défaut le premier animal est gagnant
        WriteLine($"L'animal gagnant est {animalGagnant.ToString()}"); // Affiche l'animal gagnant et sa position
    
    }
    static Animal GetAnimalGagnant(Animal[] animaux)
    {
        int maxPosition = 0;
        Animal animalGagnant = animaux[0]; // Par défaut le premier lapin est gagnant
        foreach(Animal animal in animaux)
        {
            if(animal.Position > maxPosition)
            {
                maxPosition = animal.Position;
                animalGagnant = animal;
            }
        }
        return animalGagnant;
    }
}
