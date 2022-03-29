// See https://aka.ms/new-console-template for more information
using Promotion;

Console.WriteLine("Hello, World!");

Person person1 = new Person(56342, "John Doe", 21);
Console.WriteLine(person1);

JuniorSoftwareEngineer juniorSoftwareEngineer = new JuniorSoftwareEngineer(person1);
Console.WriteLine(juniorSoftwareEngineer);

MediorSoftwareEngineer mediorSoftwareEngineer = new JuniorToMedior(juniorSoftwareEngineer);
Console.WriteLine(mediorSoftwareEngineer);

SeniorSoftwareEngineer seniorSoftwareEngineer = new MediorToSenior(mediorSoftwareEngineer);
Console.WriteLine(seniorSoftwareEngineer);

Console.ReadKey(true);
