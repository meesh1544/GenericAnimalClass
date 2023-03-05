using System;

    public class Animal <T>
    {
        public T data;
    
    public Animal(T data)
    {
        this.data = data;
        Console.WriteLine("Data passed: " + this.data);
    }
    
    }
class Program
{
    static void Main()
    {
        Animal<string> animalName = new Animal<string>("Lion");

        Animal<string> animalHabitat = new Animal<string>("Jungle");

        Animal<string> endangered = new Animal<string> ("False"); 
        
        Animal<string> extinct = new Animal<string> ("False");

        Animal<int> averageLifespan = new Animal<int>(30);
    
        var objEqual = animalName.Equals(animalHabitat);
        Console.WriteLine(objEqual);
        var objEquals = animalName.Equals(endangered);
        Console.WriteLine(objEqual);
        var objEqualss = animalName.Equals(extinct);
        Console.WriteLine(objEqual);
        var objEqualsss = animalName.Equals(averageLifespan);
        Console.WriteLine(objEqual);

        

    }
}
