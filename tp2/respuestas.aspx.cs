using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp2
{
    public partial class respuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(File.Exists(Server.MapPath(".") + "/encuesta.txt"))
            {
                StreamReader streamReader = new StreamReader($"{Server.MapPath(".")}/encuesta.txt");
                string[] lines = streamReader.ReadToEnd().Split('\n');
                streamReader.Close();
                foreach (string line in lines)
                {
                    Label1.Text += $"{line} <br/>";
                }
            }
            else
            {
                Label1.Text = "No existen datos";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("formularioPreguntas.aspx");
        }
    }
}