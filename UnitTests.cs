using System;
using NUnit.Framework;

namespace Gun_Master_9000{
    [TestFixture]
    class UnitTests {

        [Test, Description("Character without Gun can't shoot")]
        public void CharacterWithoutGunTest() {
            Character John = new Character("John");
            Bug bug = new Bug();
            Exception ex = Assert.Throws<System.InvalidOperationException>(
                () => {
            John.Shoot(bug);
                }
            );
        }
                [Test, Description("Character with Gun and without target can't shoot")]
        public void CharacterWithGunTest() {
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 6);
            john.Equip(revolver);
            Exception ex = Assert.Throws<System.ArgumentException>(
                () => {
                    john.Shoot(null);
                }
            );
        }
        
            [Test, Description("Character with Gun and without target can't shoot")]
        public void CharacterWithReloadTest() {
            Character john = new Character("John");
            Gun revolver = new Gun("Revolver", 6);
            john.Equip(revolver);
            Bug bug = new Bug();
          
             john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(false));

            john.Reload();
            john.Shoot(bug);
            Assert.That(bug.IsDead(), Is.EqualTo(true));
        }
    }
}
