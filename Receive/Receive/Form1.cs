using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receive
{
    public partial class Form1 : Form
    {
        SerialPort portSerie;

        public Form1()
        {
            InitializeComponent();
        }

        // Bouton "Lister les ports"
        private void buttonliste_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            else
                MessageBox.Show("Aucun port trouvé.");
        }

        // Bouton "Ouvrir"
        private void buttonouvrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string nomPort = comboBox1.SelectedItem.ToString();

                    portSerie = new SerialPort(nomPort, 9600);
                    portSerie.DataReceived += PortSerie_DataReceived;
                    portSerie.Open();

                    MessageBox.Show("Port ouvert pour la réception !");
                }
                else
                {
                    MessageBox.Show("Choisissez un port.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur ouverture : " + ex.Message);
            }
        }

        // Bouton "Fermer"
        private void buttonfermer_Click(object sender, EventArgs e)
        {
            try
            {
                if (portSerie != null && portSerie.IsOpen)
                {
                    portSerie.Close();
                    MessageBox.Show("Port fermé.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur fermeture : " + ex.Message);
            }
        }

        // Réception des données
        private void PortSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string donnees = portSerie.ReadExisting();

                this.Invoke(new Action(() =>
                {
                    // Exemple : si le message reçu est "2 3"
                    string[] valeurs = donnees.Trim().Split(' ');

                    if (valeurs.Length >= 2)
                    {
                        textBox1.Text = valeurs[0]; // première valeur
                        textBox2.Text = valeurs[1]; // deuxième valeur
                    }
                    else if (valeurs.Length == 1)
                    {
                        textBox1.Text = valeurs[0];
                    }
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur réception : " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
