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

    public partial class ChangePin : Form
    {
        string custName;
        string custAccNo;
        string custPin;

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
        public ChangePin(string name, string AccNo, string pin)
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panlNav.Height = btnChange.Height;
            panlNav.Top = btnChange.Top;
            panlNav.Left = btnChange.Left;
            btnChange.BackColor = Color.FromArgb(46, 51, 73);
            this.custName = name;
            this.custAccNo = AccNo;
            this.custPin = pin;
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {
            CustName1.Text = custName;
            customerNameLabel.Text = custName;
            AccNoLabel.Text = custAccNo;
        }

        private void btnMyBalance_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnMyBalance.Height;
            panlNav.Top = btnMyBalance.Top;
            panlNav.Left = btnMyBalance.Left;
            btnMyBalance.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string inName = textName.Text;
            string inOldPin = txtOldPin.Text;
            string inNewPin = txtNewPin.Text;
            if(inName == custName && inOldPin == custPin)
            {
                custPin = inNewPin;
            }
            MessageBox.Show("Your Pin is updated Successfully." + "\n" + "Please refresh save your Pin in mian Page.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getPin()
        {
            return custPin;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnDeposit.Height;
            panlNav.Top = btnDeposit.Top;
            panlNav.Left = btnDeposit.Left;
            btnDeposit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnWithdraw.Height;
            panlNav.Top = btnWithdraw.Top;
            panlNav.Left = btnWithdraw.Left;
            btnWithdraw.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnTranfer.Height;
            panlNav.Top = btnTranfer.Top;
            panlNav.Left = btnTranfer.Left;
            btnTranfer.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            panlNav.Height = btnChange.Height;
            panlNav.Top = btnChange.Top;
            panlNav.Left = btnChange.Left;
            btnChange.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            panlNav.Height = btnSignOut.Height;
            panlNav.Top = btnSignOut.Top;
            panlNav.Left = btnSignOut.Left;
            btnSignOut.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnMyBalance_Leave(object sender, EventArgs e)
        {
            btnMyBalance.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnDeposit_Leave(object sender, EventArgs e)
        {
            btnDeposit.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnWithdraw_Leave(object sender, EventArgs e)
        {
            btnWithdraw.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnTranfer_Leave(object sender, EventArgs e)
        {
            btnTranfer.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnChange_Leave(object sender, EventArgs e)
        {
            btnChange.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btnSignOut_Leave(object sender, EventArgs e)
        {
            btnSignOut.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
