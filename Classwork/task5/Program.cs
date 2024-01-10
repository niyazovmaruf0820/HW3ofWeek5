string a = Console.ReadLine();
Color b = Color.red;
Color c = Color.green;
Color d = Color.blue;
if (a == "red" || a == "Red" || a == "RED") System.Console.WriteLine((int)b);
else if (a == "green" || a == "Green" || a == "GREEN") System.Console.WriteLine((int)c);
else System.Console.WriteLine((int)d);
enum Color
{
    red = 256000000,
    green = 000256000,
    blue = 000000256
}

