using System;
using LAPIN;
static class Program
{
    static void Main()
    {
        Lapin Moussa = new Lapin("Moussa", 10);
        Lapin Barda = new Lapin("Barda", 15);
        Lapin Djibi = new Lapin("Djibi",50);

        Console.WriteLine(Djibi.NombreDeLapins());
    }
}