
static float convertTime(string time) {
    string[] parts = time.Split(':');
    float hours = float.Parse(parts[0]);
    float minutes = float.Parse(parts[1]) / 60.0f;

    return hours + minutes;
}

Console.WriteLine("What time is it? (in 24 hour format)");

string time = Console.ReadLine();
float convertedTime = convertTime(time);

if (convertedTime >= 7.0f && convertedTime <= 8.0f) {
    Console.WriteLine("Breakfast Time!");
} else if (convertedTime >= 12.0f && convertedTime <= 13.0f) {
    Console.WriteLine("Lunch Time!");
} else if (convertedTime >= 18.0f && convertedTime <= 19.0f) {
    Console.WriteLine("Dinner Time!");
} else {
    Console.WriteLine("Not time to eat!");
}
