using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioA3T2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Estudante> Estudantes = new List<Estudante>();

            Estudantes.Add(new Estudante("Pedro", 18, 1, 10));
            Estudantes.Add(new Estudante("Mariana", 15, 1, 10));
            Estudantes.Add(new Estudante("Joana", 17, 1, 10));
            Estudantes.Add(new Estudante("Ricardo", 20, 1, 10));

            dataGridView.DataSource = Estudantes;
           
        }
    }
}
