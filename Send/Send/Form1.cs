using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Send
{
    public partial class Form1 : Form
    {
        // ✅ Nouveau dictionnaire pour gérer plusieurs ports
        Dictionary<string, SerialPort> portsOuverts = new Dictionary<string, SerialPort>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string nomPort = comboBox1.SelectedItem.ToString();

                    if (portsOuverts.ContainsKey(nomPort) && portsOuverts[nomPort].IsOpen)
                    {
                        string message1 = textBox1.Text;
                        string message2 = textBox2.Text;

                        // Concaténation + ajout d’un séparateur (ex: espace ou retour chariot)
                        string messageComplet = message1 + " " + message2;

                        // ✅ Conversion en bytes avec encodage UTF8 (ou ASCII si nécessaire)
                        byte[] buffer = Encoding.UTF8.GetBytes(messageComplet);

                        // ✅ Envoi du tableau de bytes
                        portsOuverts[nomPort].Write(buffer, 0, buffer.Length);

                        MessageBox.Show("Message envoyé : " + messageComplet);
                    }
                    else
                    {
                        MessageBox.Show("Le port n'est pas ouvert.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir un port.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'envoi : " + ex.Message);
            }
        }


        // ✅ Bouton "Lister les ports"
        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Aucun port série détecté.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ✅ Bouton "Ouvrir le port"
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string nomPort = comboBox1.SelectedItem.ToString();

                    if (!portsOuverts.ContainsKey(nomPort))
                    {
                        SerialPort port = new SerialPort(nomPort, 9600);
                        port.Open();
                        portsOuverts[nomPort] = port;
                        MessageBox.Show($"Port {nomPort} ouvert !");
                    }
                    else
                    {
                        MessageBox.Show($"Le port {nomPort} est déjà ouvert.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir un port.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // ✅ Bouton "Fermer le port"
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    string nomPort = comboBox1.SelectedItem.ToString();

                    if (portsOuverts.ContainsKey(nomPort) && portsOuverts[nomPort].IsOpen)
                    {
                        portsOuverts[nomPort].Close();
                        portsOuverts.Remove(nomPort);
                        MessageBox.Show($"Port {nomPort} fermé.");
                    }
                    else
                    {
                        MessageBox.Show($"Le port {nomPort} est déjà fermé.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez choisir un port.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
