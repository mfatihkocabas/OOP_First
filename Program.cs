using System;
using Charecter;
public class Person{
    private string name;
    public string Name{get {return name;} set {name=value;}}

}




namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson =new Person();

            myPerson.Name="Fatih";
            
            System.Console.WriteLine(myPerson.Name);

            Warrior goodGuy= new Warrior(190,80,"Ahmet");


            
            Warrior badGuy=new Warrior(160,140,"Fatih");

            badGuy.Height=150;
            goodGuy.Weight=80;

            System.Console.WriteLine(badGuy.Height);
            System.Console.WriteLine(goodGuy.Weight);

            if (badGuy.Weight<goodGuy.Weight)
            {
                Console.WriteLine("iyiler her zaman kazanır");
            }else
            {
                Console.WriteLine("Kötüler Kazanır");
            }


            Console.WriteLine("Hello World!");

            goodGuy.Greetings(goodGuy);
        }
    }
}
