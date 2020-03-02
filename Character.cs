using System;

namespace Gun_Master_9000
{
    class Character{
        public string Name;

        public Gun gun;

        public Character(string name){
            this.Name = name;
        }

        public void Equip(Gun gun){
            this.gun = gun;
        }

        public void Shoot(Target target) {
            if (this.gun == null) {
                throw new System.InvalidOperationException("Character can´t shoot");
            }
            try {
                this.gun.Shoot(target);
            }catch (System.InvalidOperationException ex) {
                Console.WriteLine("*gun clicks*");
            }
        }

        public void Reload() {
             if (this.gun == null) {
                throw new System.InvalidOperationException("Character can´t shoot");
            }
            this.gun.Reload();
        }
    }
}