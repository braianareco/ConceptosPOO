

using ConceptosPOO;


Console.WriteLine("Conceptos POO");
Console.WriteLine("=============");

// Instanciamos un objeto de la clase SalaryEmployee
Employee employee1 = new SalaryEmployee()
{
    Id = 10,
    FirstName = "Carlos",
    LastName = "Aguero",
    BirthDate = new Date(1999,11,15),
    HiringDate = new Date(2021,10,20),
    IsActive = true,
    Salary = 2550000M
};

// Imprimimos el objeto employee1
Console.WriteLine(employee1);

