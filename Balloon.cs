using System;


namespace ninjas
{


    class Balloon
    {
        public Health health;

        public Balloon()
        {
            this.health = new Health(1, 1, 1);
        }
    }
}