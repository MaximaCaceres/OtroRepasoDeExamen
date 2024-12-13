using ExamenFinalTUP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ExamenFinalTUP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = Application.StartupPath + "\\datos.bin";//*****************
        Presupuesto pre;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    pre = bf.Deserialize(fs) as Presupuesto;
                }
                finally
                {
                    if(fs!=null)fs.Close();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs,pre);
            }
            finally
            {
                if (fs != null) fs.Close();    
            }
        }

        private void btnIm_Click(object sender, EventArgs e)
        {
            OpenFileDialog Im = new OpenFileDialog();
            Im.Filter = "ficheros csv|*.csv";

            if (Im.ShowDialog() == DialogResult.OK)
            {
                string path = Im.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string linea = sr.ReadLine();
                    while(sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        string[] dat = linea.Split(';');
                        if (dat.Length == 5)//********* para saber si es mesa o banco
                        {
                            Mesa m = new Mesa();
                            m.Leer(linea);
                        }
                        else if(dat.Length == 3)
                        {
                            Banco b = new Banco();
                            b.Leer(linea);
                        }
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(sr != null) sr.Close();
                    if(fs != null) fs.Close();
                }
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            SaveFileDialog Ex = new SaveFileDialog();
            Ex.Filter = "ficheros csv|*.csv";
            if (Ex.ShowDialog()==DialogResult.OK)
            {
                string path = Ex.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate,FileAccess.Write);
                    sw = new StreamWriter(fs);
                    Producto p = null;
                    sw.WriteLine("Codigo;precioBase;Largo;Ancho;Grosor");//*******No olvidar.
                    for(int i =0; i < pre.CantidadPro; i++)
                    {
                        p = pre[i];
                        sw.WriteLine(p.Escribir());
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if(sw!= null) sw.Close();
                    if(fs != null) fs.Close();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(tbxPrecioB.Text);
            double ancho = Convert.ToDouble(tbxAncho.Text);
            int codigo = Convert.ToInt32(tbxCode.Text);
            double largo = Convert.ToInt32(tbxLargo.Text);
            double grosor = Convert.ToDouble(tbxGrosor.Text);
            Producto p = null;
            if (rbxMesa.Checked)//*****************para saber que crear.
            {
                p = new Mesa(precio,largo,ancho,grosor);
                
            }
            else if(rbxBanco.Checked)
            {
                p = new Banco(precio, largo);
            }
            cbxProd.Items.Add(p);
            pre.AgregarProducto(p);
        }

        private void btnPresu_Click(object sender, EventArgs e)
        {
            string nombre = tbxNom.Text;
            string dir = tbxDir.Text;
            pre = new Presupuesto(nombre, dir);//solo creo el presupuesto.
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Producto p = cbxProd.SelectedItem as Producto;//para crear el prod mediante el cbx.
            pre.QuitarProducto(p);
            MessageBox.Show("Se elimino el producto seleccionado");
        }

        private void btnCerrarPre_Click(object sender, EventArgs e)
        {
            double tot = pre.Precio;
            MessageBox.Show($"El precio final es: {tot:f2}");
        }
    }
}
