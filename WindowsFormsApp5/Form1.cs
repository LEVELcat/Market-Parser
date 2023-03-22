using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            string s = textBox1.Text;
            string res = "";
            Regex regex = new Regex(@"GPC\d\d\d\d");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    if (list.Contains(match.Value) == false)
                    {
                        list.Add(match.Value);
                        res += match.Value + Environment.NewLine;
                    }         
                res = res.Substring(0, res.Length - 1);
            }
            textBox2.Text = res;
            textBox1.Clear();
        }
    }
}
