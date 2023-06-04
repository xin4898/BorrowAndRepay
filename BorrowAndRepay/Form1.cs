using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorrowAndRepay
{
    public partial class Form1 : Form
    {
        Person i, friend;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            i.borrow(friend, int.Parse(txtMoney.Text));

            updateMoney();
        }

        private void btnRepay_Click(object sender, EventArgs e)
        {
            i.repay(friend, int.Parse(txtMoney.Text));

            updateMoney();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            i = new Person(txtMyName.Text, 0);
            friend = new Person(txtFriendName.Text, 0);
            if (txtMyName.Text != string.Empty && txtFriendName.Text != string.Empty)
            {
                lblMyName.Text = i.Name;
                lblFriendName.Text = friend.Name;

                if (txtMoney.Text != string.Empty)
                {
                    btnBorrow.Text = "跟" + friend.Name + "借 " + txtMoney.Text + "元";
                    btnRepay.Text = "還" + friend.Name + " " + txtMoney.Text + "元";

                    btnBorrow.Enabled = true;
                    btnRepay.Enabled = true;
                }
                else
                {
                    MessageBox.Show("請輸入金額");
                }
            }
            else
            {
                MessageBox.Show("請填寫姓名欄位");
            }
        }

        private void updateMoney()
        {
            lblMyMoney.Text=i.Money.ToString();
            lblFriendMoney.Text=friend.Money.ToString();
        }
    }
}
