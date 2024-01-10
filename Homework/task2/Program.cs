int s = 0;
while(true)
{
    string a = Console.ReadLine();
    s++;
    if (a == "end")
    {
        s--;
        break;
    }
        
}
System.Console.WriteLine(s);