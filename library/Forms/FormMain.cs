using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class FormMain : Form
    {
        FormLibrarian librarian;


        public FormMain()
        {
            InitializeComponent();
        }




        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void mLibrarian_Click(object sender, EventArgs e)
        {

            if (librarian == null)
            {
                librarian = new FormLibrarian();
                librarian.TopLevel = false;
                librarian.WindowState = FormWindowState.Maximized;
                librarian.Dock = DockStyle.Fill;
                librarian.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(librarian);
                librarian.Show();
                librarian.BringToFront();

            }
            else
            {

                librarian.BringToFront();
            }
        }

    }
}
