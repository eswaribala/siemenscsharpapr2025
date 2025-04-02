// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using shoppersden;

JaggedArray.EntryPoint();
JaggedArray.ShowJaggedArray();

/*
using shoppersden.Models;
using shoppersden.Repositories;
using Bogus;
using System.Net.Http.Headers;
//generate 100 customers
CustomerRepository customerRepository = new CustomerRepository();

for (int i = 0; i < 100; i++)
{
    Customer customer = new Customer(Faker.RandomNumber.Next(1000, 5000),
        Faker.Name.FullName(), 
        Faker.Internet.Email(),
        Faker.Identification.DateOfBirth(),
        Faker.Identification.UkPassportNumber(),
        Faker.Address.StreetAddress(),
        Faker.Address.City(),
        Faker.Address.UsMilitaryState(),
        Faker.Address.ZipCode(),
        Faker.Phone.Number(),
        Faker.Boolean.Random(),
        customerRepository.getRandomGender()
        );
    customerRepository.AddCustomer(customer);
}

//retrieve customers
foreach (Customer customer in customerRepository.GetCustomers())
{
    Console.WriteLine(customer);
      
}

*/





//create customer object
/*
using shoppersden.Models;
using Bogus;
Customer customer=new Customer();
//Setter
customer.UserId= Faker.RandomNumber.Next(1000, 5000);
customer.Name = Faker.Name.FullName();
customer.Email = Faker.Internet.Email();
customer.DOB = Faker.Identification.DateOfBirth();
customer.Password = Faker.Identification.UkPassportNumber();
customer.Address = Faker.Address.StreetAddress();
customer.City = Faker.Address.City();
customer.State = Faker.Address.UsState();
customer.ZipCode = Faker.Address.ZipCode();
//Getter
Console.WriteLine($"Customer Id{customer.UserId}");
Console.WriteLine($"Customer Name{customer.Name}");
Console.WriteLine($"Customer Email{customer.Email}");
Console.WriteLine($"Customer DOB{customer.DOB}");
Console.WriteLine($"Customer Password{customer.Password}");
Console.WriteLine($"Customer Address{customer.Address}");
Console.WriteLine($"Customer City{customer.City}");
Console.WriteLine($"Customer State{customer.State}");
Console.WriteLine($"Customer ZipCode{customer.ZipCode}");
string message= @"Had lunch
    yes or no";
Console.WriteLine(message);


//Describe the Customer
//variable names

long UserId = Faker.RandomNumber.Next(1000, 5000);
string Name = Faker.Name.FullName();
string Email = Faker.Internet.Email();
DateTime DOB = Faker.Identification.DateOfBirth();
string Password = Faker.Identification.UkPassportNumber();
string Address = Faker.Address.StreetAddress();
string City = Faker.Address.City();
string State = Faker.Address.UsState();
string ZipCode = Faker.Address.ZipCode();
string PhoneNumber = Faker.Phone.Number();
bool IsActive= Faker.Boolean.Random();
double OrderTotal = Faker.RandomNumber.Next(100, 5000);
DateTime OrderDate = DateTime.Now;
Console.WriteLine($"UserId: {UserId}");
Console.WriteLine($"Name: {Name}");
Console.WriteLine($"Email: {Email}");
Console.WriteLine($"DOB: {DOB}");
Console.WriteLine($"Password: {Password}");
Console.WriteLine($"Address: {Address}");
Console.WriteLine($"City: {City}");
Console.WriteLine($"State: {State}");
Console.WriteLine($"ZipCode: {ZipCode}");
Console.WriteLine($"PhoneNumber: {PhoneNumber}");
Console.WriteLine($"IsActive: {IsActive}");
Console.WriteLine($"OrderTotal: {OrderTotal}");
Console.WriteLine($"OrderDate: {OrderDate}");
Console.ReadKey();

*/



