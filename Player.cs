using System;

namespace ninjas
{
    //Que tiene -> atributos (programacion orientada a objetos)
    // -colision (*)
    // - vida / health



    //Que hace -> metodos (programacion orientada a objetos)
    // acciones / verbos 
    // - movimiento -> Moverse() / Move()
    //ataque -> Atacar() / Attack()
    class Player 
    {
        //Atributos
        //health
        public Health health;

        public Movement movement;

        public int attackDamage = 30;

        public Player()
        {
            this.health = new Health(100, 100, 100); // 100 son los valores de los parametros de Health()

        }

        //Metodos
        public void Move()
        {
            
        }
        /// <summary>
        /// Attacks a target
        /// </summary>
        /// <returns>true if attack was a success</returns>
        public bool Attack(Health target)
        {
            if (target == null)
            {
                return false;
            }
            if (target.IsDead())
            {
                return false;
            }

            target.TakeDamage(this.attackDamage);

            return true;
        }
    }

}
