using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsRoller
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RollDice rolldice = new RollDice();

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            rolldice.HowMany = 2;
            rolldice.Sided = 6;
            int[] myresult = rolldice.RollMany();
            lblDie1.Text = myresult[0].ToString();
            string image = "die_face_" + myresult[0].ToString();
            //pBoxDie1.Image = DieFaces."die_face_1";
            lblDie2.Text = myresult[1].ToString();
        }
    }

    public class RollDice
    {
        private Random _rng;

        public RollDice()
        {
            _rng = new Random();
        }

        // Properties
        public uint HowMany { get; set; }
        public uint Sided { get; set; }
        
        // Methods
        private int InternalRoll(uint s)
        {
            return 1 + _rng.Next((int)s);
        }

        public int RollOne()
        {
            return InternalRoll((uint)Sided);
        }

        public int[] RollMany()
        {
            int[] result = new int[HowMany];
            for (int i = 0; i < HowMany; i++)
            {
                result[i] = InternalRoll(Sided);
            }
            return result;
        }
    }
}
