using System;

namespace ninjas
{
    class Health
    {
        public int health;

        public int maxHealth;

        public int initialHealth;


        public Health(int health, int maxHealth, int initialHealth)
        {
            this.health = health;
            this.maxHealth = maxHealth;
            this.initialHealth = initialHealth;
        }

        public void TakeDamage(int damage)
        {
            this.health = this.health - damage;
            //TODO: implement      
            if (this.IsDead())
            {
                this.health = 0;
            }
          

        }

        public bool IsAlive()
        {
            // TODO: implement using this.health
            if (this.health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsDead()
        {
            return !this.IsAlive();
        }
    }
}