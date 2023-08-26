public abstract class Upgrade
{
    public bool IsUnlocked(int value)
    {
        return value >= Price;
    }

    public bool IsBought   { get; set; }
    public int Price       { get; set; }
    
}