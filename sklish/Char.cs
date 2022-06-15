using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formlike
{
    //ASSEMBLES THE WEAPON AND STATS INTO A CHARACTER
    public class CHAR
    {
        public WPN ch_wpn;
        public STATS ch_stats;
        public CHAR(WPN ch_wpn, STATS ch_stats){}
    }
    //STATS 
    public class STATS
    {
        public double hp;
        public int speed;
        public int ch_attack;
        public int def;
        public int ch_acc;
        public STATS(double hp, int speed, int ch_attack, int def, int ch_acc)
        { 
            this.hp = hp;
            this.speed = speed;
            this.ch_attack = ch_attack;
            this.def = def;
            this.ch_acc = ch_acc;
        }
    }
    //WEAPON ITSELF
    public class WPN
    {
        public int dmg_min;
        public int dmg_max;
        public int wpn_acc;
        public int crit_p;
        public bool heavy;
        public WPN( int dmg_min, int dmg_max, int wpn_acc,int crit_p, bool heavy)
        {
            this.dmg_min = dmg_min;
            this.dmg_max = dmg_max;
            this.wpn_acc = wpn_acc;
            this.crit_p = crit_p;
            this.heavy = heavy;
        }
    }
    //HOW FAI ACTS

    //MABE REMOVE ALONG WITH GENERATION
    public class FAIPRO
    {
        public int agression;
        public FAIPRO()
        {
            this.agression = 5;
        }
    }
    //FAI CHARACTER ITSELF
    public class FAICHAR
    {
        public WPN fai_wpn;
        public STATS fai_stats;
        public FAIPRO fai_pro;
        public FAICHAR(WPN fai_wpn, STATS fai_stats, FAIPRO fai_pro)
        {
            this.fai_stats = fai_stats;
            this.fai_wpn =  fai_wpn;
            this.fai_pro = fai_pro;
        }
    }
}
