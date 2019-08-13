using System.Windows.Forms;
using System.Diagnostics;

namespace ARM_Headman
{
    public partial class HumanInfoGroupBox : UserControl
    {
        public HumanInfoGroupBox()
        {
            InitializeComponent();
        }

        public HumanInfoGroupBox(string userName)
        {
            InitializeComponent();
            userGroupBox.Text = userName;
        }

        public bool BoxIsFill()
        {
            if (userSurname.Text != "" && userName.Text != "" && userMiddlename.Text != "") return true;
            else return false;
        }

        public string GetName() { return $"{userSurname.Text} {userName.Text} {userMiddlename.Text}"; }
        public string GetVkUrl() { return $"vk.com/{userVkUrl.Text}"; }
        public int GetPhone() { return userPhone.Text != "" ? int.Parse(userPhone.Text) : 0; }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        public void Fill(Human human)
        {
            string[] name = human.FullName.Split(' ');

            userSurname.Text = name[0];
            userName.Text = name[1];
            userMiddlename.Text = name[2];

            userVkUrl.Text = human.VkUrl.Substring(human.VkUrl.IndexOf('/') + 1);
            userPhone.Text = human.Phone.ToString();
        }

        private void ToBrowser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($@"https://{GetVkUrl()}");
        }
    }
}
