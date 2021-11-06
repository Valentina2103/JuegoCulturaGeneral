using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCulturaGeneral
{
    public partial class Form1 : Form
    {
        int resultado = 0;
        int seleccion = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pregunta1();
        }
        private void Pregunta1()
        {
            if (MessageBox.Show("Bienvenida/o a un pequeño juego que te dara a conocer que tanto sabes sobre cultura general", "Cultura General 🌎", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.label1.Text = "Pregunta 1";
                this.label2.Text = "¿Cuál es el océano más grande del mundo?";
                this.radioButton1.Text = "Océano Pacífico";
                this.radioButton2.Text = "Océano Índico";
                this.radioButton3.Text = "Océano Atlántico";
                Image img = Image.FromFile("../../images/oceano.jpg");
                pictureBox1.Image = img;
            }
            else
            {
                Application.Exit();
            }
        }
        private void Pregunta2()
        {
            this.label1.Text = "Pregunta 2";
            this.label2.Text = "¿Cuál es el nombre de especie de los seres humanos?";
            this.radioButton1.Text = "Homo sapiens";
            this.radioButton2.Text = "Homo sapiens sapiens";
            this.radioButton3.Text = "Homo erectus";
            Image img = Image.FromFile("../../images/homo.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta3()
        {
            this.label1.Text = "Pregunta 3";
            this.label2.Text = "¿Cuál es el animal más grande de la Tierra?";
            this.radioButton1.Text = "La orca";
            this.radioButton2.Text = "La ballena azul";
            this.radioButton3.Text = "La ballena gris";
            Image img = Image.FromFile("../../images/animales1.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }

        private void Pregunta4()
        {
            this.label1.Text = "Pregunta 4";
            this.label2.Text = "¿Cuánto duró “La Guerra de los Cien Años”?";
            this.radioButton1.Text = "100 años";
            this.radioButton2.Text = "200 años";
            this.radioButton3.Text = "116 años";
            Image img = Image.FromFile("../../images/100.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta5()
        {
            this.label1.Text = "Pregunta 5";
            this.label2.Text = "¿Cuál es el país más grande?";
            this.radioButton1.Text = "Rusia";
            this.radioButton2.Text = "Brasil";
            this.radioButton3.Text = "China";
            Image img = Image.FromFile("../../images/bolamundo.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta6()
        {
            this.label1.Text = "Pregunta 6";
            this.label2.Text = "¿Cuál es el videojuego más vendido de la historia?";
            this.radioButton1.Text = "Grand Theft Auto V";
            this.radioButton2.Text = "Minecraft";
            this.radioButton3.Text = "Pac-Man";
            Image img = Image.FromFile("../../images/videojuego.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta7()
        {
            this.label1.Text = "Pregunta 7";
            this.label2.Text = "¿Cuál es el metal más caro del mundo?";
            this.radioButton1.Text = "Oro";
            this.radioButton2.Text = "Platino";
            this.radioButton3.Text = "Rodio";
            Image img = Image.FromFile("../../images/metal.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta8()
        {
            this.label1.Text = "Pregunta 8";
            this.label2.Text = "¿Cómo se llama el animal más rápido del mundo?";
            this.radioButton1.Text = "Guepardo";
            this.radioButton2.Text = "Halcón peregrino";
            this.radioButton3.Text = "Escarabajo tigre";
            Image img = Image.FromFile("../../images/ANIMALES.png");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta9()
        {
            this.label1.Text = "Pregunta 9";
            this.label2.Text = "¿Cuál es la cascada más alta del mundo?";
            this.radioButton1.Text = "El Salto del Ángel";
            this.radioButton2.Text = "Cataratas de Iguazú";
            this.radioButton3.Text = "Cataratas del Niágara";
            Image img = Image.FromFile("../../images/cascada.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Pregunta10()
        {
            this.label1.Text = "Pregunta 10";
            this.label2.Text = "¿Cuál es la obra más importante de la literatura en español?";
            this.radioButton1.Text = "El Principito";
            this.radioButton2.Text = "Don Quijote de la Mancha";
            this.radioButton3.Text = "Cien años de soledad";
            Image img = Image.FromFile("../../images/libros.jpg");
            pictureBox1.Image = img;
            seleccion++;
        }
        private void Limpiar()
        {
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == false &&
            this.radioButton2.Checked == false &&
            this.radioButton3.Checked == false)
            {
                MessageBox.Show("Debes seleccionar una respuesta", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                switch (seleccion)
                {
                    case 1:
                        if (this.radioButton1.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta2();
                        break;

                    case 2:
                        if (this.radioButton2.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta3();
                        break;

                    case 3:
                        if (this.radioButton2.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta4();
                        break;

                    case 4:
                        if (this.radioButton3.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta5();
                        break;

                    case 5:
                        if (this.radioButton1.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta6();
                        break;

                    case 6:
                        if (this.radioButton2.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta7();
                        break;

                    case 7:
                        if (this.radioButton3.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta8();
                        break;

                    case 8:
                        if (this.radioButton1.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta9();
                        break;

                    case 9:
                        if (this.radioButton1.Checked == true)
                        {
                            resultado++;
                        }
                        Limpiar();
                        Pregunta10();
                        break;

                    case 10:
                        if (this.radioButton2.Checked == true)
                        {
                            resultado++;
                        }

                        if (resultado >= 7)
                        {
                            MessageBox.Show("Tus respuestas correctas han sido: " + resultado.ToString(), "Felicitaciones 😄", MessageBoxButtons.OK);
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Tus respuestas correctas han sido: " + resultado.ToString(), "Puedes Mejorar 😬", MessageBoxButtons.OK);
                            Application.Exit();
                        }

                        break;
                    default:
                        break;
                }
            }

        }
    }
}

udeu







