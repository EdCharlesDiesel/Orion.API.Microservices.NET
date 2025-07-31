namespace Orion.WebApps.HealthCheckUI.Models;

public class HealthRecord
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int Age { get; set; }
    public float BMI { get; set; }
    public int HeartRate { get; set; }
}