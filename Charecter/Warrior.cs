

namespace Charecter
{
    
public class Warrior{
  private int height;
  private int weight;
  private string names;

  public int Height{get;set;}
  public int Weight{get; set;}

  public string Names{get;set;}

  public void Greetings(Warrior warrior){
      System.Console.WriteLine($@"Greetings,{warrior.Names}!");
  }  

    public Warrior(int height,int weight,string names){
        Height=height;
        Weight=weight;
        Names=names;
    }

}
}