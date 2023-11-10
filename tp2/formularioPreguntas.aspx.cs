using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp2
{
    public partial class formularioPreguntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string checkCiudades = "";

            if (this.CheckBox1.Checked)
            {
                checkCiudades += this.LabelCordoba.Text + " 1 ";
            }
            else
            {
                checkCiudades += this.LabelCordoba.Text + " 0 ";
            }

            if (this.CheckBox2.Checked)
            {
                checkCiudades += this.LabelTucuman.Text + " 1 ";
            }
            else
            {
                checkCiudades += this.LabelTucuman.Text + " 0 ";
            }

            if (this.CheckBox3.Checked)
            {
                checkCiudades += this.LabelMendoza.Text + " 1 ";
            }
            else
            {
                checkCiudades += this.LabelMendoza.Text + " 0 ";
            }

            if (this.CheckBox4.Checked)
            {
                checkCiudades += this.LabelCatamarca.Text + " 1 ";
            }
            else
            {
                checkCiudades += this.LabelCatamarca.Text + " 0 ";
            }


            string radioVolver = "";



            if (this.RadioButton1.Checked)
            {
                radioVolver += this.LabelSi.Text + " 1 ";
            }
            else
            {
                radioVolver += this.LabelSi.Text + " 0 ";
            }

            if (this.RadioButton2.Checked)
            {
                radioVolver += this.LabelNo.Text + " 1 ";
            }
            else
            {
                radioVolver += this.LabelNo.Text + " 0 ";
            }

            if (this.RadioButton3.Checked)
            {
                radioVolver += this.LabelQuizas.Text + " 1";
            }
            else
            {
                radioVolver += this.LabelQuizas.Text + " 0";
            }


            StreamWriter streamWriter = new StreamWriter($"{Server.MapPath(".")}/encuesta.txt", true);
            streamWriter.WriteLine(LabelPregunta1.Text);
            streamWriter.WriteLine(checkCiudades);
            streamWriter.WriteLine(LabelPregunta2.Text);
            streamWriter.WriteLine(radioVolver);
            streamWriter.Close();
            mensaje.Text = $"Agregado, ruta de encuesta.txt {Server.MapPath(".")} .";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("respuestas.aspx");
        }
    }
}