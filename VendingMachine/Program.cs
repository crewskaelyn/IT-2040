int totalCoins = 0, change;
Console.WriteLine("Vending Machine");
Console.WriteLine("----------------");
Console.WriteLine("Amount due: 50 cents");

while (totalCoins < 50) {
    Console.WriteLine("Insert coin:");
    try {
        int coin = int.Parse(Console.ReadLine());
        if (coin == 1 || coin == 5 || coin ==10 || coin==25) {
            Console.WriteLine("Amount due: " + (50- totalCoins));
            totalCoins += coin;
        } else {
            Console.WriteLine("Invalid coin. Please enter a valid amount.");
            continue;
        }
    } catch {
        Console.WriteLine("Invalid coin. Please enter a valid amount.");
    }
}
change = totalCoins - 50;
Console.WriteLine("Change due: "+ change);
