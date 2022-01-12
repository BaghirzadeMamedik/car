using lesson3;

string right = "";
Console.OutputEncoding = System.Text.Encoding.UTF8;

do

{
    Console.WriteLine("Maşınınızı Daxil edin");
    Console.WriteLine("----------------------");
    Console.WriteLine("Marka:");
    string marka = Console.ReadLine();

    Console.WriteLine("Model:");
    string model = Console.ReadLine();

    Console.WriteLine("FuelEff:");
    string fuelEff = Console.ReadLine();

    Console.WriteLine("Max Fuel:");
    string maxFuel = Console.ReadLine();

    Console.WriteLine("Current Fuel:");
    string currentFuel = Console.ReadLine();
    bool isCorrect = false;

    try
    {
        decimal fuelEffDec = Convert.ToDecimal(fuelEff);
        decimal maxFuelDec = Convert.ToDecimal(maxFuel);
        decimal currentFuelDec = Convert.ToDecimal(currentFuel);

        Car newCar = new Car()
        {
            Marka = marka,
            Model = model,
            FuelEff = fuelEffDec,
            MaxFuel = maxFuelDec
        };
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Marka adı: {marka} maşın uğurla yaradıldi\n");
        isCorrect = true;

    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Benzin ilə bağlı məlumatları rəqəm daxil edin");

    }
    if (isCorrect==true)
    {

    
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Welcome");
    Console.WriteLine("1.Go");
    Console.WriteLine("2.Topup");
    Console.WriteLine("3.Stop");
    Console.WriteLine("4.Exit");
    right = Console.ReadLine();


    try
    {
        int rightNumber = Convert.ToInt32(right);
        Console.Clear();
        switch (rightNumber)
        {
            case 1:
                Console.WriteLine("masin getdi");
                break;
            case 2:
                Console.WriteLine("benzin doldu");
                break;
            case 3:
                Console.WriteLine("stop");
                break;
            case 4:
                Console.WriteLine("Yaxshi yol");
                break;
            default:
                Console.WriteLine("Xaish edirem verilmish reqemlerden birini daxil edin");
                break;

        }
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();
        Console.WriteLine("Xaish edirem reqem daxil edin!");
        
    }









    }
} while (right!= "4");