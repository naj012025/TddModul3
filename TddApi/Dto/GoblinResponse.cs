
namespace TddApi.Dto;

public class GoblinResponse
{
    //added in goblin id for 404 testen tror ikke jeg trenger den.
    public int Id { get; set; }
    public int Health { get; set; }
    public int XpReward { get; set; }
    public bool IsDead { get; set; }
}