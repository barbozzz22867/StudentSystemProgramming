namespace StudentSystemProgramming.Models;

public sealed class AppSettings
{
    public string Theme { get; set; } = "Light";
    public int LaunchCount { get; set; }
    public int SchemaVersion { get; set; } = 1;
}