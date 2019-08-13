using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARM_Headman
{
    public partial class MainForm : Form
    {
        public static Group CurrentGroup { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Group group)
        {
            InitializeComponent();
            CurrentGroup = group;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Главное меню ({CurrentGroup.GroupName})";
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportForm rForm = new ReportForm();
            rForm.ShowDialog();
        }

        private void VedomostButton_Click(object sender, EventArgs e)
        {
            Form vForm = new VedomostForm();
            vForm.ShowDialog();
        }

        private void GroupButton_Click(object sender, EventArgs e)
        {
            Form eForm = new CreateFile(this, true);
            eForm.Show();
            Hide();
        }
    }
}
