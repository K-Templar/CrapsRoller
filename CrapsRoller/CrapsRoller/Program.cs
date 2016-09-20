using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsRoller
{
    public class RollDice
    {
        private Random _rng;

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
            return 1 + _rng.Next( (int)s);
        }

        public int Roll()
        {
            return InternalRoll((uint)Sided);
            //return (int)HowMany * (int)Sided;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RollDice rolldice = new RollDice();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
