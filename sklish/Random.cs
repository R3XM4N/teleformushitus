using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formlike
{
    //Generates a random weapon from given base data

    //MAYBE CHANGE FOR A BETTER SYSTEM?
    public class RNGWPN
    {
        public int dmg_min;
        public int dmg_max;
        public int wpn_acc;
        public int crit_p;
        public bool heavy;
        public RNGWPN()
        {
            Random r = new Random();
            this.dmg_min = r.Next(5, 4444);
            while (dmg_max < dmg_min)
            {
                dmg_max = r.Next(dmg_min, dmg_min * r.Next(1,4));
            }
            
            this.wpn_acc = r.Next(0,101);
            this.crit_p = r.Next(0,101);
            if (r.Next(0,100) >50)
                this.heavy = true;
            else
                this.heavy=false;
        }
    }
    //Generates stats for characters from given base data

    //MAYBE CHANGE FOR A BETTER SYSTEM?
    public class RNGSTATS
    {
        public double hp;
        public int speed;
        public int ch_attack;
        public int def;
        public int ch_acc;
        public RNGSTATS()
        {
            Random r = new Random();
            this.hp = r.Next(100, 55555); 
            this.speed = r.Next(5, 101);
            this.ch_acc = r.Next(15, 100);
            this.ch_attack = r.Next(100, 333);
            this.def = r.Next(0, 55555);
        }
    }
    //GENERATES THE FAI AGREASION

    //MABE REMOVE?
    public class RNGFAIPRO
    {
        public int agression;
        public RNGFAIPRO()
        {
            Random r = new Random();
            this.agression = r.Next(101);
        }
    }
}
