using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //if(textbox1.Text==String.Empty)
                MessageBox.Show("Nome vazio!!!");
            else
                MessageBox.Show(textBox1.Text, "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Não escolheu curso!");
            else
                MessageBox.Show("Curso:" + comboBox1.SelectedItem.ToString());

            if (SEMESTRE.SelectedIndex == -1)
                MessageBox.Show("Não escolheu o semestre!");
            else
                MessageBox.Show("Semestre: " + SEMESTRE.SelectedItem.ToString());

            //if (checkBox1.Checked)
            //    MessageBox.Show("É casado!");
            //else
            //    MessageBox.Show("Não é casado!");

            if (checkBox1.CheckState == CheckState.Checked)
                MessageBox.Show("É casado");

            else
                if (checkBox1.CheckState == CheckState.Unchecked)
                    MessageBox.Show("Não é casado!");
                else
                    MessageBox.Show("estado civil inderteminado");

            if (radioButton1.Checked)
                MessageBox.Show("escolheu masculino");
            else
                MessageBox.Show("escolheu feminino");

            for (var x = 0; x <= checkedListBox1.SelectedItems.Count-1; x++)
                MessageBox.Show("Selecionado" + checkedListBox1.SelectedItems[x].ToString());

            for (var x = 0; x <= checkedListBox1.SelectedItems.Count - 1; x++)
                MessageBox.Show("Selecionado" + checkedListBox1.CheckedItems[x].ToString());



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SEMESTRE.Items.Add("1º semestre");
            SEMESTRE.Items.Add("2º semestre");
            SEMESTRE.Items.Add("3º semestre");
            SEMESTRE.Items.Add("4º semestre");
            SEMESTRE.Items.Add("5º semestre");
            SEMESTRE.Items.Add("6º semestre");
            SEMESTRE.Items.Add("7º semestre");
            SEMESTRE.Items.Add("8º semestre");
        }
                
    }
}
