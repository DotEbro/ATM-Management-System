using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ATM_System
{


    public partial class Withdraw : Form
    {

        string custName;
        string custAccNo;
        double money;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Withdraw(string name, string AccNo, double mone)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panlNav.Height = button2.Height;
            panlNav.Top = button2.Top;
            panlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            this.custName = name;
            this.custAccNo = AccNo;
            this.money = mone;
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            CustName1.Text = custName;
            customerNameLabel.Text = custName;
            AccNoLabel.Text = custAccNo;
            moneyLabel.Text = money.ToString();
        }

        public double getMoney()
        {
            return money;
        }
        private void btnDeposit_Click_1(object sender, EventArgs e)
        {
            string input = textMoney.Text;
            double withdraw = double.Parse(input);
            money = money - withdraw;
            MessageBox.Show("The money withdraw successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            moneyLabel.Text = money.ToString();
            textMoney.Text = String.Empty;
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMyBalance_Click_1(object sender, EventArgs e)
        {
            panlNav.Height = btnMyBalance.Height;
            panlNav.Top = btnMyBalance.Top;
            panlNav.Left = btnMyBalance.Left;
            btnMyBalance.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panlNav.Height = button1.Height;
            panlNav.Top = button1.Top;
            panlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panlNav.Height = button2.Height;
            panlNav.Top = button2.Top;
            panlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panlNav.Height = button3.Height;
            panlNav.Top = button3.Top;
            panlNav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panlNav.Height = button4.Height;
            panlNav.Top = button4.Top;
            panlNav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            panlNav.Height = button6.Height;
            panlNav.Top = button6.Top;
            panlNav.Left = button6.Left;
            button6.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnMyBalance_Leave(object sender, EventArgs e)
        {
            btnMyBalance.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button4_Leave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void button6_Leave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        
    }
}
