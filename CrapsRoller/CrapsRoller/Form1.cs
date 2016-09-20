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
    public class RollDice
    {
        private Random _rng;

        public RollDice()
        {
            _rng = new Random();
        }

        // Properties
        private uint _sided;
        public uint HowMany { get; set; }
        public uint Sided
        {
            get { return _sided; }
            set { _sided = value; }
        }

        // Methods
        private int InternalRoll(uint s)
        {
            return 1 + _rng.Next((int)s);
        }

        public int Roll()
        {
            return InternalRoll((uint)Sided);
            //return (int)HowMany * (int)Sided;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            RollDice rolldice = new RollDice();
            InitializeComponent();
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            
        }
    }
}
