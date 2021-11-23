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
    public partial class Customer : Form
    {
        Deposit deposit;
        Withdraw withdraw;
        Transfer transfer;
        ChangePin changepin;

        string custName;
        string custPin;
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
        public Customer()
        {
            Console.WriteLine("Customer empty constractor");
        }
        public Customer(string n, string p, string ac, double mon)
        {
            Console.WriteLine("Customer Classs COnstractor");
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panlNav.Height = btnMyBalance.Height;
            panlNav.Top = btnMyBalance.Top;
            panlNav.Left = btnMyBalance.Left;
            btnMyBalance.BackColor = Color.FromArgb(46, 51, 73);
            this.custName = n;
            this.custPin = p;
            this.custAccNo = ac;
            this.money = mon;
            Console.WriteLine("Name: " + custName);
            Console.WriteLine("PIN: " + custPin);
            Console.WriteLine("Ac: " + custAccNo);
            Console.WriteLine("Money: " + money);
        }

        public string getCName()
        {
            return custName;
        }
        public string getCPassword()
        {
            return custPin;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustName1.Text = custName;
            customerNameLabel.Text = custName;
            AccNoLabel.Text = custAccNo;
            moneyLabel.Text = money.ToString();
        }

        private void btnMyBalance_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnMyBalance.Height;
            panlNav.Top = btnMyBalance.Top;
            panlNav.Left = btnMyBalance.Left;
            btnMyBalance.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panlNav.Height = button1.Height;
            panlNav.Top = button1.Top;
            panlNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
            deposit = new Deposit(custName, custAccNo, money);
            deposit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panlNav.Height = button2.Height;
            panlNav.Top = button2.Top;
            panlNav.Left = button2.Left;
            button2.BackColor = Color.FromArgb(46, 51, 73);
            withdraw = new Withdraw(custName, custAccNo, money);
            withdraw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panlNav.Height = button3.Height;
            panlNav.Top = button3.Top;
            panlNav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
            transfer = new Transfer(custName, custAccNo, money);
            transfer.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panlNav.Height = button4.Height;
            panlNav.Top = button4.Top;
            panlNav.Left = button4.Left;
            button4.BackColor = Color.FromArgb(46, 51, 73);
            changepin = new ChangePin(custName, custAccNo, custPin);
            changepin.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (checkBoxDeposit.Checked == false && checkBoxTransfer.Checked == false && checkBoxWithdraw.Checked == false && checkBoxPin.Checked == false)
            {
                MessageBox.Show("Please any one box.", "Select One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (checkBoxDeposit.Checked == true && checkBoxTransfer.Checked == true && checkBoxWithdraw.Checked == true && checkBoxPin.Checked == true)
            {
                MessageBox.Show("Please select only one box.", "Select One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (checkBoxDeposit.Checked == true && checkBoxTransfer.Checked == false && checkBoxWithdraw.Checked == false && checkBoxPin.Checked == false)
            {
                money = deposit.getMoney();
                moneyLabel.Text = money.ToString();
            }
            if (checkBoxDeposit.Checked == false && checkBoxWithdraw.Checked == true && checkBoxTransfer.Checked == false && checkBoxPin.Checked == false)
            {
                money = withdraw.getMoney();
                moneyLabel.Text = money.ToString();
            }
            if (checkBoxDeposit.Checked == false && checkBoxWithdraw.Checked == false && checkBoxTransfer.Checked == true && checkBoxPin.Checked == false)
            {
                money = transfer.getMoney();
                moneyLabel.Text = money.ToString();
            }
            if (checkBoxDeposit.Checked == false && checkBoxWithdraw.Checked == false && checkBoxTransfer.Checked == false && checkBoxPin.Checked == true)
            {
                custPin = changepin.getPin();
            }
            checkBoxDeposit.Checked = false;
            checkBoxTransfer.Checked = false;
            checkBoxWithdraw.Checked = false;
            checkBoxPin.Checked = false;
        }
    }
}
