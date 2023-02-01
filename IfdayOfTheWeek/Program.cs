int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0)
{
    Console.WriteLine("Käes on Pühapäev!");
}
else if(weekDay == 1)
{
    Console.WriteLine("Käes on Esmaspäev!");
}
else if(weekDay == 2)
{
    Console.WriteLine("Käes on Teisipäev!");
}
else if(weekDay == 3)
{
    Console.WriteLine("Käes on Kolmapäev!");
}
else if(weekDay == 4)
{
    Console.WriteLine("Käes on Neljapäev!");
}
else if(weekDay == 5)
{
    Console.WriteLine("Käes on Reede!");
}
else
{
    Console.WriteLine("Käes on Laupäev!");
}

Console.WriteLine("Kena päeva!");