

Console.WriteLine("Sisesta number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutajate arv on paaris või paaritu

int result = userNum % 2;

//Console.WriteLine(result);

// != tähendab et ei võrdu / ei ole

if(result != 0)
{
    Console.WriteLine("Number on paaritu.");
}
else
{
    Console.WriteLine("Number on paaris.");
}