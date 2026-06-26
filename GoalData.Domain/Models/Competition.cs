namespace GoalData.Domain.Models;

public class Competition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Emblem { get; set; } = string.Empty;
    public string LastUpdate { get; set; } = string.Empty;
}
