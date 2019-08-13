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
    public partial class LoadMenu : Form
    {
        public LoadMenu()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenDialog openDialog = new OpenDialog();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //открываем форму для работы с программой
                new MainForm(openDialog.group).Show();
                Hide();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form createForm = new CreateFile(this);
            createForm.Show();
            Hide();          
        }
    }
}