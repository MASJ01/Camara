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
using AForge.Video;
using AForge.Video.DirectShow; 

namespace Camara_Web
{
    public partial class Form1 : Form
    {
        public bool existen_dispositivos = false;
        private FilterInfoCollection dispositivo_video; //Identifica las camaras del equipo
        private VideoCaptureDevice fuente_video = null; //SE va a seleccionar la camara

        public Form1()
        {
            InitializeComponent();
            buscar_dispositivos(); 
        }

        public void buscar_dispositivos()
        {
            dispositivo_video = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivo_video.Count == 0)
            {
                existen_dispositivos = false;
                barra_estado.Text = "NO HAY DISPOSITIVOS CONECTADOS";
            }
            else
            {
                existen_dispositivos = true;
                barra_estado.Text = "HAY CAMARAS DISPONIBLES";
                for (int camara = 0; camara < dispositivo_video.Count; camara++)
                {
                    comboBox1.Items.Add(dispositivo_video[camara].Name.ToString()); // COloca el nombre de la camara
                }
                comboBox1.Text = "Selecciona Camara..."; 
            }
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_INICIAR_Click(object sender, EventArgs e)
        {
            if (BTN_INICIAR.Text == "INICIAR")
            {
                if (existen_dispositivos == true)
                {
                    fuente_video = new VideoCaptureDevice(dispositivo_video[comboBox1.SelectedIndex].MonikerString); //Moniker solo extrae el nombre del elemento
                    fuente_video.NewFrame += new NewFrameEventHandler(video_nuevoFrame);
                    fuente_video.Start();
                    BTN_INICIAR.Text = "DETENER";
                    comboBox1.Enabled = false;
                    barra_estado.Text = "LISTO"; 
                }
                else
                {
                    barra_estado.Text = "NO HAY DISPOSITIVOS CONECTADOS";
                }

            }
            else
            {
                if (fuente_video.IsRunning)
                {
                    barra_estado.Text = "DISPOSITIVO DETENIDO";
                    BTN_INICIAR.Text = "INICIAR";
                    PBX_ESPACIO_CAMARA.Image = Properties.Resources.camara; 
                    comboBox1.Enabled = true;
                    if (!(fuente_video == null)) // ! Siginifica negacion
                    {
                        if (fuente_video.IsRunning)
                        {
                            fuente_video.SignalToStop();
                            fuente_video = null; 
                        }
                    }
                }
            }
        }

        public void video_nuevoFrame(object sender, NewFrameEventArgs eventArgas)
        {
            Bitmap imagen = (Bitmap)eventArgas.Frame.Clone();
            PBX_ESPACIO_CAMARA.Image = imagen; 
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            //Se va a guardar por numeros (1,2,3)
            string Nombre = "Imagen";
            int numero_de_fotos;
            string[] Nombre_de_imagen;
            Nombre_de_imagen = Directory.GetFiles(Application.StartupPath + @"\Fotos");
            numero_de_fotos = Nombre_de_imagen.Length;
            int NUMERO_MAYOR = 0; 

            if (numero_de_fotos > 0)
            {
                for (int i = 0; i < numero_de_fotos; i++)//Extraer el numero mayor de imagen
                {
                    string[] Directorio_separado = Nombre_de_imagen[i].Split('\\'); //El split se queda con el ultimo dato, se corta la cadena hasta que encuentre el ultimo slash
                    int Num_Foto = Convert.ToInt16(Directorio_separado[Directorio_separado.Length - 1].Split('.')[0].Replace(Nombre, "").ToString());

                    if (NUMERO_MAYOR < Num_Foto)
                    {
                        NUMERO_MAYOR = Num_Foto;
                    }
                }
                for (int i = 0; i < nud_secuencia.Value; i++)
                {
                    PBX_ESPACIO_CAMARA.Image.Save(Application.StartupPath + @"\Fotos\" + Nombre + (NUMERO_MAYOR + 1 + i) + ".bmp");
                }
            }
            else
            {
                for (int i = 0; i < nud_secuencia.Value; i++)
                {
                    PBX_ESPACIO_CAMARA.Image.Save(Application.StartupPath + @"\Fotos\" + Nombre + i.ToString()+ ".bmp"); //originalmente es 0.bmp
                }
            }

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            cuadro_guardar = new SaveFileDialog();
            if (cuadro_guardar.ShowDialog() == DialogResult.OK) // ShowDialogo nos permite ver algo en el proyecto, otra ventana. Para saber a que le di click, por ejemplo, cuando le das cerrar a un programa y te pregunta si deseas guardar antes de salir.
            {
                if (cuadro_guardar.FileName != "") // File name compara el nombre que inserta el usuario 
                {
                    PBX_ESPACIO_CAMARA.Image.Save(cuadro_guardar.FileName);
                }
            }

                    


            
        }

    }
}
