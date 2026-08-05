using System.Numerics;
using XpTdd.Models;

namespace Tests
{
    public class PlayerTests
    {

        [Fact]
        public void GainXp_WhenGiven50_Adds50xp()
        {
            //Arrange
            Player player = new();
            //Act
            player.GainXp(50);
            //Assert
            Assert.Equal(50, player.Xp); //red

        }

        [Fact]
        public void GainXp_WhenXpReaches100_PlayerLevelup()
        {
            //Arrange
            Player player = new();
            //Act
            player.GainXp(100);
            //Assert
            Assert.Equal(2, player.Level);
        }

        [Fact]
        public void GainXp_WhenXpReachesLimit_KeepsRemainingXp()
        {
            //Arrange
            Player player = new();
            //act
            player.GainXp(90);
            player.GainXp(20);
            //Assert
            Assert.Equal(2, player.Level);
            Assert.Equal(10, player.Xp);
        }

        [Fact]
        public void GainXp_WhenEnoughForMultipleLevels_LevelsUpMultipleTimes()
        {
            //Arrange
            Player player = new();
            //Act
            player.GainXp(250);
            //Assert
            Assert.Equal(3, player.Level);// will fail beacuse he will be lvl 3
            Assert.Equal(50, player.Xp);
        }
        [Fact]
        public void Goblin_HasCorrectXpReward()
        {
            //Arrange
            Goblin goblin = new Goblin(25, 100);
            //Act

            //Assert
            Assert.Equal(25, goblin.XpReward);
        }

        [Fact]
        public void Player_GainsKillXp_SmallAmount()
        {
            //Arrange
            Player player = new Player();

            //Act
            player.GainXp(25);
            //Assert
            Assert.Equal(25, player.Xp);
        }
        [Fact]
        public void GainXp_OnKill_Goblin()
        {
            //Arrange
            Player player = new Player();
            Goblin goblin = new Goblin(25, 100);
            //Act
            player.GainXp(goblin.XpReward);
            //Assert
            Assert.Equal(25, player.Xp);
        }
        [Fact]
        public void GainXp_KillEnoughGoblins_ToLevelUp()
        {
            //Arrange
            Player player = new Player();
            Goblin goblin = new Goblin(25, 100);
            //Act
            //for loop for og simulere 8 kills som gir 25xp per.
            for (var i = 0; i < 8; i++)
            {
                player.GainXp(goblin.XpReward);
            }
            //Assert
            Assert.Equal(3, player.Level);
        }

        [Fact]
        public void EquipWeapon_PlayerEquipWeapon()
        {
            //Arrange
            Player player = new Player();
            Weapon sword = new Weapon("Short Sword", 25);
            //Act
            player.EquipWeapon(sword);
            //Assert
            Assert.Equal(sword, player.EquipedWeapon);
        }
        [Fact]
        public void Attack_UsingWeapon_GivesDamage()
        {
            //Arrange
            Player player = new Player();
            Goblin goblin = new Goblin(25, 100);
            Weapon sword = new Weapon("Short Sword", 25);
            player.EquipWeapon(sword);
            //Act
            player.Attack(goblin);
            //Assert
            Assert.Equal(75, goblin.Health);

        }

        [Fact]

        public void Damage_ByWeapons_GoblinIsDead()
        {
            //Arrange
            Player player = new Player();
            Goblin goblin = new Goblin(25, 100);
            Weapon sword = new Weapon("UberSword", 125);
            player.EquipWeapon(sword);
            //Act
            player.Attack(goblin);
            //Assert
            Assert.True(goblin.Isdead);
        }

    }
}
