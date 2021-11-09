using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesarrolloDeInterfaces
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe introducir un nombre");
            }
            else
            {
                this.listNombre.Items.Add(this.txtNombre.Text);
                this.txtNombre.Text = String.Empty;
            }
        }

        private void listNombre_SelectedValueChanged(object sender, EventArgs e)
        {

           if(this.listNombre.SelectedItem == null)
            {
                return;
            }
                this.txtNombre.Text = this.listNombre.SelectedItem.ToString();

            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.listNombre.SelectedItem == null)
            {
                MessageBox.Show("Debes selececcionar antes un nombre de la lista");
            }
            else
            {
                for (int i = this.listNombre.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.listNombre.Items.Remove(this.listNombre.SelectedItems[i]);
                }
                this.txtNombre.Text = String.Empty;
            }
        }

        private void listNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(this.listNombre.SelectedItem != null)
            {
            if(e.KeyCode == Keys.Delete) {
                    for (int i = this.listNombre.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        this.listNombre.Items.Remove(this.listNombre.SelectedItems[i]);
                    }
                    this.txtNombre.Text = String.Empty;
            }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista");

            }
        }
    }
}
