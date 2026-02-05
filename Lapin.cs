using random = System.Random;

namespace LAPIN;
class Lapin
{
    public string surnom;
    public int age;
    private int position;
    static int nombreDeLapins;
    public int Position { set; get;}

    public Lapin(string surnom, int age)
    {
        this.age = age;
        this.surnom = surnom;
        nombreDeLapins++;
    }

    public int NombreDeLapins()
    {
        return nombreDeLapins;
    }

    public void Avancer()
    {
       Position += new random().Next(0, 05);
    }

}