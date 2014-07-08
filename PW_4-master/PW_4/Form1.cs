using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PW_4
{
    public partial class Form1 : Form
    {
        public delegate void SetTextDelegate(String text);
        public delegate void GetTextDelegate(String text);
        int n;
        private Thread system;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            if (text_log.InvokeRequired)
            {
                SetTextDelegate d = new SetTextDelegate(SetText);
                this.Invoke(d, new object[] { text });

            }
            else
                this.text_log.AppendText("[" + DateTime.Now.ToString("HH:mm:ss tt") + "] " + text + "\n");
        }

        private void button_Click(object sender, EventArgs e)
        {
            system = new Thread(new ThreadStart(Program.calculate));
            n = int.Parse(text_n.Text);
            SetText("Rozpoczynam liczenie " + n + "!");
            system.Start();
        }

        public int get_n()
        {
            return n;
        }
    }
}
