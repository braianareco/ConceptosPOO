

using ConceptosPOO;


try
{
	Console.WriteLine(new Date(2022, 11, 9));
    Console.WriteLine(new Date(1974, 9, 27));
    Console.WriteLine(new Date(1985, 12, 45));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}