﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineBookStore.Resources
{
    public partial class text_effect : Label
    {
        public text_effect()
        {
            InitializeComponent();
            UseCompatibleTextRendering = true;
            this.BackColor = Color.White;
            timer1.Start();
        }

        private void text_effect_Load(object sender, EventArgs e)
        {

        }

        int position, speed;

        public int Set_Speed{ get { return speed; } set { speed = value; Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)position,0);
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position < -Width)
            {
                position = Width;
            }
            position -= speed;
            Invalidate();
        }
    }
}
