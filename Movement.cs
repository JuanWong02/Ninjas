using System;

namespace ninjas
{
    class Movement
    {
        public float speed;

        public float walkSpeed;
        public float runSpeed;
        public float crouchSpeed;

        // - power up
        // - debuff
        // - run
        // - crouch
        public void Move()
        {

        }

        public void Run()
        {
            this.speed = this.runSpeed;
        }

        public void StopRunning()
        {
            this.speed = this.walkSpeed;
        }
    }
}