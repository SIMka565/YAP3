﻿using System;

struct Person
{
  public string firstName;
  public string lastName;
  public int age;
  public Genders gender;
  public enum Genders : int { Male, Female };
  public Person(string _firstName, string _lastName, int _age, Genders _gender)
  {
    firstName = _firstName; lastName =
    _lastName; age = _age; gender = _gender;
  }
  public override string ToString()
  {
    return firstName + " " + lastName + " (" + gender + "), age " + age;
  }
}
namespace prakt01
{
  class Program
  {
    static void Main(string[] args)
    {
      // C#
      Person p = new Person("Tony", "Allen", 32, Person.Genders.Female); Console.WriteLine(p.ToString());
    }
  }
}