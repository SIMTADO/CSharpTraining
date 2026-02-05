namespace LAPIN;
class Lapin
{
    private string surnom;
    private int age;
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

}