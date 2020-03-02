using System;

namespace Gun_Master_9000 {

    interface DodgingTarget : Target {

        void Dodge();

        void Hit();

        void Miss();
    }
}