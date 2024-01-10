namespace task4;

public class Counter
{
    public int Value {get; set;}
    public Counter(int startValue)
    {
        Value = startValue;
    }
    public Counter()
    {
        Value = 0;
    }
    public void Increase()
    {
        if (Value <= 5) Value++;
    }
    public void Decrease()
    {
        if (Value >= 0) Value--;
    }
    public void IncreaseBy(int increaseBy)
    {
        if (increaseBy > 0)
        {
            Value += increaseBy;
        }
    }
    public void DecreaseBy(int increaseBy)
    {
        if (increaseBy > 0)
        {
            Value -= increaseBy;
        }
    }
}
