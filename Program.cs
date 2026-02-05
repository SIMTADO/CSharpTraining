using static System.Console;
using LAPIN;

static class Program
{
    static void Main()
    {
        Lapin Moussa = new Lapin("Moussa", 10); // Premier lapin créé
        Lapin Barda = new Lapin("Barda", 15); // Deuxième lapin créé
        Lapin Djibi = new Lapin("Djibi",50); // Troisième lapin créé

        Lapin[] lapins = { Moussa, Barda, Djibi }; // Tableau pour stocker les lapins

        for(int i=0; i<100; i++)
        {
            foreach(Lapin lapin in lapins)
            {
                lapin.Avancer(); // Chaque lapin avance
            }
        }
        WriteLine("Course terminée");

        Lapin lapinGagnant = GetLapinGagnant(lapins); // Par défaut le premier lapin est gagnant
        
        WriteLine($"Le lapin gagnant est {lapinGagnant.surnom} avec une position de {lapinGagnant.Position}"); // Affiche le lapin gagnant et sa position
    
    }

    static Lapin GetLapinGagnant(Lapin[] lapins)
    {
        int maxPosition = 0;
        Lapin lapinGagnant = lapins[0]; // Par défaut le premier lapin est gagnant
        foreach(Lapin lapin in lapins)
        {
            if(lapin.Position > maxPosition)
            {
                maxPosition = lapin.Position;
                lapinGagnant = lapin;
            }
        }
        return lapinGagnant;
    }
}
