using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppREGEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validatePattern();
        }
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            validatePattern();
        }

        private void txtPattern_TextChanged(object sender, EventArgs e)
        {
            validatePattern();
        }

        private void validatePattern()
        {
            try
            {
                Regex reg = new Regex(txtPattern.Text);
                bool result = reg.IsMatch(txtText.Text);
                lblResult.Text = result.ToString();
            }
            catch (Exception)
            {

            }
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        
    }
}
