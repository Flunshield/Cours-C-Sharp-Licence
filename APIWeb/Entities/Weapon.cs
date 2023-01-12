namespace APIWeb.Entities;

public class Weapon
{
    public long Id { get; set; }
    public string HeroesNameArms { get; set; }
    public string EnemysNameArms { get; set; }
    public long bonusStrength { get; set; }
    public long bonusWisdom { get; set; }
    public long bonusVitality { get; set; }
}
