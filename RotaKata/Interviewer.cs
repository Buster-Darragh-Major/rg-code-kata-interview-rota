namespace RotaKata;

public record Interviewer(string Name)
{
    public string Name = Name;
    public int TotalEffort = 0;
    public bool IsAvailable = true;
}