namespace APIWeb.Entities;

public class Enemy
{
    public long Id { get; set; }
    public long IdWeapon { get; set; }
    public string name { get; set; } = string.Empty;

    public long strength { get; set; }

    public long wisdom { get; set; }

    public long vitality { get; set; }
    public string classePlayer { get; set; } = string.Empty;

}
