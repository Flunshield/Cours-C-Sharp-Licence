namespace APIWeb.Entities;

public class Arms
{
    public long Id { get; set; }
    public string HeroesNameArms { get; set; } = string.Empty;
    public string EnemysNameArms { get; set; } = string.Empty;
    public long bonusForce { get; set; }
    public long bonusSagesse { get; set; }
    public long bonusVitality { get; set; }
}
