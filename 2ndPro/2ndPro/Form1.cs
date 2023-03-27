using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //default Event for form is load 
            Text = "hello";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "helowrod";
            this.Size = new Size(1200, 1490);
            this.BackColor = Color.Aqua;
            this.MaximumSize = new Size(1230, 1499);
            //enmration
            //objict
            //value
            button1.Font = new Font("Comic Sans MS", 20,FontStyle.Bold);
            Text = "yyyyy";
            MessageBox.Show("you add category");
        }
    }
}
