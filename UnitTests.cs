using System;
using NUnit.Framework;
using System.Collections.Generic;

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

        [Test, Description("Minigun can be used as a gun")]
        public void MinigunTest () {
            //Gun[] guns = new Gun[2];
            //new Gun();
            List<Gun> guns = new List<Gun>();

            Gun Minigun = new Minigun("Minigun Mk1", 99999);
            Gun revolver = new Gun("revolver", 6);
            guns.Add(Minigun);
            guns.Add(revolver);

            Bug bug = new Bug();

            guns[0].Shoot(bug);

            Assert.That(bug.IsDead(), Is.EqualTo(true));

            Assert.Throws<System.InvalidOperationException>(
                () => {
                    guns[0].Reload();
                }
            );
        }
    }
}
