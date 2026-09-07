using Is_a___Has_a.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_a___Has_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_tipocurso.Items.Add("Presencial");
            cmb_tipocurso.Items.Add("Virtual");

            cmb_tipocurso.SelectedIndex = 0;
        }

        private void cmb_tipocurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipocurso.SelectedItem == null)
                return;

            if (cmb_tipocurso.SelectedItem.ToString() == "Presencial")
            {
                label8.Text = "Salón:";
                label9.Text = "Edificio:";
            }
            else if (cmb_tipocurso.SelectedItem.ToString() == "Virtual")
            {
                label8.Text = "Plataforma:";
                label9.Text = "URL:";
            }

            txt_salon.Clear();
            txt_edificio.Clear();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto Profesor
                Profesor profesor = new Profesor(
                    int.Parse(txt_empleado.Text),
                    txt_nomempleado.Text,
                    txt_especialidad.Text
                );

                // Convertir la duración a entero
                int duracion = int.Parse(txt_duracion.Text);

                // Crear el curso
                Curso curso;

                if (cmb_tipocurso.SelectedItem.ToString() == "Presencial")
                {
                    curso = new CursoPresencial(
                        txt_clave.Text,
                        txt_nombrecuso.Text,
                        duracion,
                        profesor,
                        txt_salon.Text,
                        txt_edificio.Text
                    );
                }
                else
                {
                    curso = new CursoVirtual(
                        txt_clave.Text,
                        txt_nombrecuso.Text,
                        duracion,
                        profesor,
                        txt_salon.Text,
                        txt_edificio.Text
                    );
                }

                // Mostrar información en el ListBox
                lst_cursos.Items.Add("--------------------------------");

                string[] informacion = curso.MostrarInformacion().Split('\n');

                foreach (string linea in informacion)
                {
                    lst_cursos.Items.Add(linea);
                }

                lst_cursos.Items.Add("--------------------------------");

                MessageBox.Show("Curso registrado correctamente.");
            }
            catch
            {
                MessageBox.Show("Verifica que los datos estén correctamente capturados.");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_clave.Clear();
            txt_nombrecuso.Clear();
            txt_duracion.Clear();

            txt_salon.Clear();
            txt_edificio.Clear();

            txt_empleado.Clear();
            txt_nomempleado.Clear();
            txt_especialidad.Clear();

            cmb_tipocurso.SelectedIndex = 0;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
