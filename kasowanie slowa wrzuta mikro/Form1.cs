using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace kasowanie_slowa_wrzuta
{
    public partial class Form1 : Form
    {
        public string adres;
        public int liczba;
        public Form1()
        {
            InitializeComponent();
        }
        private void zmien_Click(object sender, EventArgs e)
        {
            wybor.ShowDialog();
            adres = wybor.SelectedPath;
            liczba = adres.Length;
            string[] pliki = Directory.GetFiles(@adres);
            foreach (string slowo in pliki)
            {
                FileInfo fin = new FileInfo(@slowo);
                if (fin.Name.Contains(wyraz.Text))
                {
                 fin.MoveTo(@slowo.Remove(liczba+1,wyraz.Text.Length));
                }
            }
            MessageBox.Show("Zakonczone powodzeniem");
        }

    }
}
