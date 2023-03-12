using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Dictionary<int, string> Persons = new Dictionary<int, string>();

        private void addBtn_Click(object sender, EventArgs e)
        {
            string documento = Doc.Text;
            string nombre = name.Text;

            try
            {
                int id = Int32.Parse(documento);
                if(id == 0)
                {
                    throw new FormatException();
                }
                else if(nombre == "")
                {
                    MessageBox.Show("Nombre no Valido");
                }
                else if(Persons.Count() == 12)
                {
                    MessageBox.Show("No se puede agregar, lista llena");
                }
                else
                {
                    bool keyExist = Persons.ContainsKey(id);
                    try
                    {
                        if (keyExist)
                        {
                            throw new Exception();
                            
                        }
                        else
                        {
                            Persons.Add(id, nombre);
                            listView1.Items.Clear();
                            foreach (var item in Persons)
                            {
                                ListViewItem lista = new ListViewItem(item.Key.ToString());
                                lista.SubItems.Add(item.Value);
                                listView1.Items.Add(lista);
                            }
                            MessageBox.Show("Persona Agregada con exito");
                            Doc.Text = "";
                            name.Text = "";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Documento ya registrado");
                        Doc.Text = "";
                        name.Text = "";
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Documento no valido");
                
            }
            
            

        }
        private void updBtn_Click(object sender, EventArgs e)
        {
            Persons.Clear();
            listView1.Items.Clear();
            
        }

        private void supBtn_Click(object sender, EventArgs e)
        {
         
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                string cod = listView1.SelectedItems[0].SubItems[0].Text;
                Persons.Remove(Int32.Parse(cod));
                lista.Remove();
            }
            

        }

        
    }
}
