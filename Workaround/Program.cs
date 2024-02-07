using Business.Concrete;
using Entities.Concrete;

static int Topla(int sayi1, int sayi2)
{
    int result = sayi1 + sayi2;
    Console.WriteLine("Toplam: " + result);
    return result;
    
}
Person person = new Person();
person.NationalIdentity = 123;
person.FirstName = "Muhammed";
person.LastName = "Demir";
person.DateOfBirthYear = 1994;


PttManager pttManager=new PttManager(new PersonManager());
pttManager.GiveMask(person);
Console.ReadLine();