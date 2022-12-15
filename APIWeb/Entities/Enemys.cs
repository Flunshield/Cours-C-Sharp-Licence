namespace APIWeb.Entities;

public class Enemys
{
    public int Id { get; set; }
    public string EnemysArms { get; set; } = string.Empty;
    public string name { get; set; } = string.Empty;

    public long force { get; set; }

    public long sagesse { get; set; }

    public long vitality { get; set; }
    public string classePlayer { get; set; } = string.Empty;

}
