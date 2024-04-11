using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_windows_forms
{
    public partial class Form6 : Form
    {
        public Form6(string nome, string cantor)
        {
            InitializeComponent();
            labelNome.Text = "Nome: " + nome;
            labelCantor.Text = "Cantor(a): " + cantor;

        }

        private void labelNome_Click(object sender, EventArgs e)
        {
        
        }
    }
}
