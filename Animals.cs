using randonFunc = System.Random;

namespace ANIMALS;

class Animal
{
    public string surnom;
    public int age;
    public int position;
    public int Position { set; get;}
    public Animal(string nom, int age)
    {
        this.surnom = nom;
        this.age = age;
    }

    public virtual void Avancer() {}
    public override string ToString()
    {
      return $"{surnom}";
    }
}

class Lapin : Animal
{
    static int nombreDeLapins;

    public Lapin(string surnom, int age) : base(surnom, age)
    {
        nombreDeLapins++;
    }

    public int NombreDeLapins()
    {
        return nombreDeLapins;
    }

    public override void Avancer()
    {
       Position += new randonFunc().Next(0, 11);
    }

    public override string ToString()
    {
      return $"{surnom} - age: {age} - position: {Position}";
    }
}

class Tortue :  Animal
{
    public int epaisseurCarapace;

    public Tortue(string surnom, int age, int epaisseurCarapace) : base(surnom, age)
    {
        this.epaisseurCarapace = epaisseurCarapace;
    }

    public override void Avancer()
    {
       Position += new randonFunc().Next(0, 6);
    }
    public override string ToString()
    {
        return $"{base.ToString()} - Epaisseur carapace: {epaisseurCarapace} - age: {age} - position: {Position}";
    }
}