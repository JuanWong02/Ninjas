using System;


namespace ninjas
{


    class Barrel
    {
        public Health health;

        public Barrel()
        {
            this.health = new Health(200, 200, 200);
        }
    }
}