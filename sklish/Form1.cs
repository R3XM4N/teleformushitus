using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;


namespace formlike
{
    public partial class Form1 : Form
    {
        //revise this shit
        public RNGWPN rnwpn = new RNGWPN();
        public RNGSTATS rnstats = new RNGSTATS();
        public FAIPRO rnfaipro = new FAIPRO();
        public CHAR player = null;
        public FAICHAR enemy = null;
        public WPN p_wpn = null;
        public WPN enemy_wpn = null;
        public STATS p_stats = null;
        public STATS enemy_stats = null;
        public Form1()
        {
            InitializeComponent();
            STB();
            pee_name.Text = "YOU";
            enemy_name.Text = "This is the person to be yeatened";
        }
        #region close button
        private void close_buttonnot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region no touch zone
        //NO TOUCH ZONE
        private void button1_Click(object sender, EventArgs e){TURN(1);}
        private void button2_Click(object sender, EventArgs e){ TURN(2); }
        private void button3_Click(object sender, EventArgs e) { TURN(3); }
        //END OF NO TOUCH ZONE
        #endregion
        #region start end button functions also no touch
        //Disables buttons until turn ends
        public void STB()
        {
            use_1_1.Enabled = false;
            use_1_2.Enabled = false;
            use_1_3.Enabled = false;
        }
        //Re-enables buttons after turn ends
        public void ETB()
        {
            use_1_1.Enabled = true;
            use_1_2.Enabled = true;
            use_1_3.Enabled = true;
        }
        #endregion
        //TURN LOGIC
        #region turn logic
        public void TURN(int action)
        {
            switch (action)
            {
                //action one
                #region ac1
                case 1:
                    STB();
                    //CODE GOES HERE
                    enemy_stats.hp -= DMG(p_wpn.dmg_min, p_wpn.dmg_max, p_wpn.crit_p);
                    testvalues.Text = Convert.ToString(enemy_stats.hp);
                    if (Convert.ToInt32(enemy_stats.hp) <0)
                    {
                        MessageBox.Show("he ded");
                    }
                    else
                    hp2test.Value = Convert.ToInt32(enemy_stats.hp);
                    FTURN();
                    ETB();
                    break;
                #endregion
                //action two
                #region ac2
                case 2:
                    STB();
                    //CODE GOES HERE
  
                    ETB();
                    break;
                #endregion
                //action three
                #region ac3
                case 3:
                    STB();
                    //CODE GOES HERE
                    
                    ETB();
                    break;
                #endregion
                //message for invalid input
                default:
                    MessageBox.Show("Invalid action");
                    break;
            }
        }
        public void FTURN()
        {
            Random r = new Random();

            int agg = enemy.fai_pro.agression;
            int temp;
            temp = r.Next(0,5);
            if (temp <= agg)
            {
                p_stats.hp -= DMG(enemy_wpn.dmg_min, enemy_wpn.dmg_max, enemy_wpn.crit_p);
                testvalues.Text = Convert.ToString(p_stats.hp);
                if (Convert.ToInt32(p_stats.hp) < 0)
                {
                    MessageBox.Show("u ded");
                }
                else
                    hp1test.Value = Convert.ToInt32(p_stats.hp);
            }
        }
        #endregion
        public double DMG(int min_damage, int max_damage,int critchance)
        {
            Random random = new Random();
            return random.Next(min_damage,max_damage);
        }
        #region start game logic UNFINISHED
        private void magicalbutton(object sender, EventArgs e)
        {
            ETB();
            RNGWPN rnwpn = new RNGWPN();
            RNGSTATS rnstats = new RNGSTATS();
            FAIPRO rnfaipro = new FAIPRO();
            //player stuff
            p_wpn = new WPN(rnwpn.dmg_min, rnwpn.dmg_max, rnwpn.wpn_acc, rnwpn.crit_p, rnwpn.heavy);
            p_stats = new STATS(rnstats.hp, rnstats.speed, rnstats.ch_attack, rnstats.def, rnstats.ch_acc);
            player = new CHAR(p_wpn, p_stats);
            //enemy stuff
            enemy_wpn = new WPN(rnwpn.dmg_min, rnwpn.dmg_max, rnwpn.wpn_acc, rnwpn.crit_p, rnwpn.heavy);
            enemy_stats = new STATS(rnstats.hp, rnstats.speed, rnstats.ch_attack, rnstats.def, rnstats.ch_acc);
            enemy = new FAICHAR(p_wpn, p_stats, rnfaipro);

            hp2test.Maximum = Convert.ToInt32(enemy_stats.hp);
            hp2test.Value = hp2test.Maximum;

            hp1test.Maximum = Convert.ToInt32(p_stats.hp);
            hp1test.Value = hp1test.Maximum;

            testvalues.Text = p_wpn.dmg_max.ToString();
        }
        #endregion
    }
}
