using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_4b
{
    public partial class Form1 : Form
    {
        public int grade = 0;
        int TIME_FINISH = 120;
        int _ticks;
        enum GameStatus { start, pause, end };
        private GameStatus GameStatus_c;
        public Form1()
        {
            InitializeComponent();
        }
        void StratTimer()
        {
            _ticks = 0;
            lblTime.Text = "" + TIME_FINISH;
            tmrForm.Start();
        }
        void EndTime ()
        {
            _ticks = 120;
            tmrForm.Stop();
            Form childForm = new Form(); //initialize a child form
            childForm.TopLevel = false; //set its TopLevel to false
            Controls.Add(childForm); //and add it to the parent Form
            childForm.Show(); //finally display it
            childForm.BringToFront(); //use this to render your newly created form over the controls
        }
        private void tmrForm_Tick(object sender, EventArgs e)
        {
            switch (GameStatus_c)
            {
                case GameStatus.end:
                    break;
                case GameStatus.pause:
                    break;
                case GameStatus.start:
                    _ticks++;
                    lblTime.Text = "" + (TIME_FINISH - _ticks);
                    if (_ticks == TIME_FINISH)
                    {
                        MessageBox.Show("your time has ran out");
                        GameStatus_c = GameStatus.end;
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lblQ1_Click(object sender, EventArgs e)
        {

        }

        private void ckbxQ1A1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void ckbxQ1A2_CheckedChanged(object sender, EventArgs e) //Milan
        {
            
        }

        private void ckbxQ1A4_CheckedChanged(object sender, EventArgs e) //Cruzeiro 
        {
            
        }

        private void ckbxQ1A5_CheckedChanged(object sender, EventArgs e) //Bracelona
        {
            
        }

        private void ckbxQ1A8_CheckedChanged(object sender, EventArgs e) //Real Madrid
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // Q3 Ruud Gullit
        {
            //he plays in 6 teams
            if (nmbbxQ3.Value == 6)
                grade += 20;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Q4 Romario's play
        {
            if (cbobxQ4.Text == "ו__ו _ה ג_מה")
                grade += 20;
        }

        private void lblQ4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ckbxQ1A3_CheckedChanged(object sender, EventArgs e) // Q1 Bayren
        {
            grade += 5;
        }

        private void ckbxQ1A6_CheckedChanged(object sender, EventArgs e) // Q1 PSG
        {
            grade += 5;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnQ2A2_CheckedChanged(object sender, EventArgs e) //Ruud
        {
            grade += 20;
        }

        private void btnPSV_Click(object sender, EventArgs e) //PSV
        {
            grade += 20;
        }

        private void btnFinish_Click(object sender, EventArgs e) // FINISH BUTTON
        {
            EndTime();
        }
    }
}
