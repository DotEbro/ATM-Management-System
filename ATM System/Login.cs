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
    public partial class Login : Form
    {
        Admin admin;
        string adName = "Mike";
        string adPass = "Mike@123";
        string custName;
        string custPass;

        //Customer cust = new Customer();

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
        public Login()
        {
            Console.WriteLine("Log in Classs COnstractor");
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public string getAdName()
        {
            return adName;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (AdCheckBox.Checked == false && CustCheckBox.Checked == false)
            {
                MessageBox.Show("Please check any one box.", "Select One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (AdCheckBox.Checked == true && CustCheckBox.Checked == true)
            {
                MessageBox.Show("Please Select only one category.", "Select One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(AdCheckBox.Checked == true && CustCheckBox.Checked == false)
            {
                if (txtUserName.Text == adName && txtPassword.Text == adPass)
                {
                    admin = new Admin();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Sorry! the credentials are incorrect.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                }
            }


            if (CustCheckBox.Checked == true && AdCheckBox.Checked == false)
            {
                this.custName = admin.getCname();
                this.custPass = admin.getCpass();
                Console.WriteLine("Name: " + custName);
                Console.WriteLine("PIN: " + custPass);
                //Console.WriteLine(cust.getCName());
                //Console.WriteLine(cust.getCPassword());
                if (txtUserName.Text == this.custName && txtPassword.Text == this.custPass)
                {
                    Console.WriteLine("Inside of Customer page");
                    admin.CustomerShow();
                }
                else
                {
                    MessageBox.Show("Sorry! the credentials are incorrect.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (var c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Text = String.Empty;
                        }
                    }
                }
                
            }
        }
    }
}
