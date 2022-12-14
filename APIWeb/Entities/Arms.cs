namespace APIWeb.Entities;

public class Arms
{
    public int Id { get; set; }
    public string name { get; set; } = string.Empty;

    public long bonusForce { get; set; }

    public long bonusSagesse { get; set; }

    public long bonusVitality { get; set; }

}
