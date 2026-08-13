
namespace TddApi.Dto;

public class GoblinResponse
{
    //added in goblin id for 404 testen tror ikke jeg trenger den.
    public int Id { get; set; }
    public int Health { get; set; } = 100;
    public int XpReward { get; set; } = 33;
    public bool IsDead { get; set; }
}