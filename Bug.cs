using System;

namespace Gun_Master_9000 {

    class Bug : Target {

       private bool dead = false;
        public void Shot(){
            this.dead = true;
        }

        public bool IsDead() {
            return this.dead;
        }
    }
}