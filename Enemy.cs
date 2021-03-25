using System;

namespace ninjas
{
    class Enemy 
    {
        //Que tiene
        //(igual que el Player)
        public Health health;

        //Que acciones realiza
        //(igual que el Player)

        public Enemy()
        {
            this.health = new Health(40, 40, 40);
        }
    }

}
