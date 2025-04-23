// See https://aka.ms/new-console-template for more information
using ConsoleApp12;

Person p = new Person("juan");

Person p2 = new Person("ana");

PeopleEnum gente = new PeopleEnum([p,p2]);



// Recorrer con el enumerador
while (gente.MoveNext())
{
    
    Console.WriteLine(gente.Current.Name);
}