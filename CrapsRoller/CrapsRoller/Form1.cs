﻿using System;
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
        int HowManyTimes = 1;

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            rolldice.HowMany = 2;
            rolldice.Sided = 6;
            int[] DiceRolls = new int[13];
        
            for (int c = 0; c < HowManyTimes; c++)
            {
                int[] myresult = rolldice.RollMany();
                switch (myresult[0])
                {
                    case 1:
                        lblDie1.Text = "1";
                        pBoxDie1.Image = DieFaces.die_face_1;
                        break;
                    case 2:
                        lblDie1.Text = "2";
                        pBoxDie1.Image = DieFaces.die_face_2;
                        break;
                    case 3:
                        lblDie1.Text = "3";
                        pBoxDie1.Image = DieFaces.die_face_3;
                        break;
                    case 4:
                        lblDie1.Text = "4";
                        pBoxDie1.Image = DieFaces.die_face_4;
                        break;
                    case 5:
                        lblDie1.Text = "5";
                        pBoxDie1.Image = DieFaces.die_face_5;
                        break;
                    case 6:
                        lblDie1.Text = "6";
                        pBoxDie1.Image = DieFaces.die_face_6;
                        break;
                }
                switch (myresult[1])
                {
                    case 1:
                        lblDie2.Text = "1";
                        pBoxDie2.Image = DieFaces.die_face_1;
                        break;
                    case 2:
                        lblDie2.Text = "2";
                        pBoxDie2.Image = DieFaces.die_face_2;
                        break;
                    case 3:
                        lblDie2.Text = "3";
                        pBoxDie2.Image = DieFaces.die_face_3;
                        break;
                    case 4:
                        lblDie2.Text = "4";
                        pBoxDie2.Image = DieFaces.die_face_4;
                        break;
                    case 5:
                        lblDie2.Text = "5";
                        pBoxDie2.Image = DieFaces.die_face_5;
                        break;
                    case 6:
                        lblDie2.Text = "6";
                        pBoxDie2.Image = DieFaces.die_face_6;
                        break;
                }
                lblDie1.Refresh();
                pBoxDie1.Refresh();
                lblDie2.Refresh();
                pBoxDie2.Refresh();
                int DiceTotal = myresult[0] + myresult[1];
                DiceRolls[DiceTotal]++;
             }
            chart1.Series["Roll Result"].Points.Clear();
            chart1.Series["Roll Result"].Points.AddXY(2, DiceRolls[2]);
            chart1.Series["Roll Result"].Points.AddXY(3, DiceRolls[3]);
            chart1.Series["Roll Result"].Points.AddXY(4, DiceRolls[4]);
            chart1.Series["Roll Result"].Points.AddXY(5, DiceRolls[5]);
            chart1.Series["Roll Result"].Points.AddXY(6, DiceRolls[6]);
            chart1.Series["Roll Result"].Points.AddXY(7, DiceRolls[7]);
            chart1.Series["Roll Result"].Points.AddXY(8, DiceRolls[8]);
            chart1.Series["Roll Result"].Points.AddXY(9, DiceRolls[9]);
            chart1.Series["Roll Result"].Points.AddXY(10, DiceRolls[10]);
            chart1.Series["Roll Result"].Points.AddXY(11, DiceRolls[11]);
            chart1.Series["Roll Result"].Points.AddXY(12, DiceRolls[12]);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            switch (btn.Name)
            {
                case "rb1time":
                    HowManyTimes = 1;
                    break;
                case "rb10times":
                    HowManyTimes = 10;
                    break;
                case "rb100times":
                    HowManyTimes = 100;
                    break;
                case "rb1000times":
                    HowManyTimes = 1000;
                    break;
                case "rb10000times":
                    HowManyTimes = 10000;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
