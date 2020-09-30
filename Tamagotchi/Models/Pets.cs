using System;
using System.Collections.Generic;

namespace Tamagotchi.Models
{

  public class Pet
  {

    public string Name { get; set; }
    public string Img { get; set; }
    public int Id { get; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    private static List<Pet> _instances = new List<Pet> { };


    public Pet(string name)
    {
      Name = name;
      Food = 50;
      Attention = 50;
      Rest = 50;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public void Feed()
    {
      this.Food += 10;
    }

    public void Play()
    {
      this.Attention += 10;
    }

    public void Sleep()
    {
      this.Rest += 50;
    }
    public static List<Pet> GetAll()
    {
      Console.WriteLine();
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Pet Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}