using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Copter : UserControl, IPlayer
    {
        private int score = 0;
        private bool alive = true;
        public Copter()
        {
            InitializeComponent();
        }

        public bool Alive()
        {
            return this.alive;
        }

        public void GainPoint()
        {
            this.score++;
        }

        public int GetScore()
        {
            return this.score;
        }

        public void Kill()
        {
            this.alive = false;
        }

        public bool TopScore()
        {
            throw new NotImplementedException();
        }
    }
}
