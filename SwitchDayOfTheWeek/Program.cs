int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay)    //Väärtus mida kontrollitakse
{
    case 0: //case 0: tähendab sama mis if(weekDay == 0)
        Console.WriteLine("Käes on Pühapäev!");
        break;
    case 1:
        Console.WriteLine("Käes on Esmaspäev!");
        break;
    case 2:
        Console.WriteLine("Käes on Teisipäev!");
        break;
    case 3:
        Console.WriteLine("Käes on Kolmapäev!");
        break;
    case 4:
        Console.WriteLine("Käes on Neljapäev!");
        break;
    case 5:
        Console.WriteLine("Käes on Reede!");
        break;
    case 6:
        Console.WriteLine("Käes on Laupäev!");
        break;
    default:    //Viisakas kasutada alati. toimib juhul kui ei peaks olemas olema ühtegi sobivat case
        Console.WriteLine("Oops. Sinu kalender on katki!");
        break;
}

Console.WriteLine("Kena päeva!");