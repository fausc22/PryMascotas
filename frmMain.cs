using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMascotas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            List<string> ListaMascotas = new List<string>();

            ClsMascota Mascota1 = new ClsMascota
            {
                nombre = "Guardian",
                edad = "5 años",
                tipoAnimal = "Perro pastor aleman",
                FotoAnimal = Image.FromFile("pastor-aleman1.jpg")
            };

            ListaMascotas.Add(Mascota1.tipoAnimal);
            
            

            ClsMascota Mascota2 = new ClsMascota
            {
                nombre = "Pelos",
                edad = "2 años",
                tipoAnimal = "Gato Persa",
                
            };

            ListaMascotas.Add(Mascota2.tipoAnimal);

            ClsMascota Mascota3 = new ClsMascota
            {
                nombre = "Negrito",
                edad = "3 años",
                tipoAnimal = "Gato Siames",
                
            };

            ListaMascotas.Add(Mascota3.tipoAnimal);

            ClsMascota Mascota4 = new ClsMascota
            {
                nombre = "Pipo",
                edad = "2 años",
                tipoAnimal = "Loro",
                
            };

            ListaMascotas.Add(Mascota4.tipoAnimal);

            ClsMascota Mascota5 = new ClsMascota
            {
                nombre = "Esponjoso",
                edad = "1 año",
                tipoAnimal = "Conejo",
                
            };

            ListaMascotas.Add(Mascota5.tipoAnimal);

            ClsMascota Mascota6 = new ClsMascota
            {
                nombre = "Oscar",
                edad = "6 años",
                tipoAnimal = "Tortuga",
                
            };

            ListaMascotas.Add(Mascota6.tipoAnimal);

            ClsMascota Mascota7 = new ClsMascota
            {
                nombre = "Charito",
                edad = "4 años",
                tipoAnimal = "Perro Golden",
                
            };

            ListaMascotas.Add(Mascota7.tipoAnimal);

            listMascotas.DataSource = ListaMascotas;

         




        }

        private void listMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(ClsMascota.AlimentarMascota());
        }
    }
}
