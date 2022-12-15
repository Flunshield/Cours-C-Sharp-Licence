namespace APIWeb.Entities;

public class Hero
{
    public int Id { get; set; }
    public string HeroesArms { get; set; }
    public string name { get; set; } = string.Empty;

    public long force { get; set; }

    public long sagesse { get; set; }

    public long vitality { get; set; }
    public string classePlayer { get; set; }

}
