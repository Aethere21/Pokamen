using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokamen
{
    public class EntityInfo
    {
        //Public integer to store the enemy health
        public int EnemyHealth
        {
            get;
            set;
        }
        //Public integer to store the player health
        public int PlayerHealth
        {
            get;
            set;
        }
        //Public boolean (true or false) to store whether the enemy is defending or not
        public bool EnemyDefending
        {
            get;
            set;
        }
        //Public boolean (true or false) to store whether the player is defending or not
        public bool PlayerDefending
        {
            get;
            set;
        }
        //Public integer to store the player's score
        public int PlayerScore
        {
            get;
            set;
        }
        //Public boolean (true or false) to store whether it is the player's or enemy's turn
        public bool PlayerTurn
        {
            get;
            set;
        }
    }
}
