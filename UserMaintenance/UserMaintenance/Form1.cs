using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName; // label1
            
            btnAdd.Text = Resource1.Add; // button1
            save.Text = Resource1.Save;
            btnDelete.Text = Resource1.Remove;
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text,
            };
            users.Add(u);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var s in users)
                {
                    sw.Write(s.ID);
                    sw.Write(";");
                    sw.Write(s.FullName);
                    sw.Write(";");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var törles = listUsers.SelectedItem;
            if (törles != null)
                users.Remove((User)törles);
        }
    }
}
