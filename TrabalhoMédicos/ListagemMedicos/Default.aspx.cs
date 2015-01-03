using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrabMaroquioAV2;

namespace ListagemMedicos
{
    public partial class Default : System.Web.UI.Page
    {
        private bool carregado = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["q"] != null)
            {
                if (!carregado)
                {
                    string ParametroBusca = Request.QueryString["q"];
                    Dados.LimparTudo();
                    Dados.LoadingTudo();
                    divBusca.Visible = true;
                    divResultado.Visible = true;
                    spnBusca.InnerText = "\"" + ParametroBusca + "\"";
                    gvMedicos.DataSource = Dados.TodosMedicos.Where(
                        x => x.NomeMed.ToUpper().Contains(ParametroBusca.ToUpper()));
                    gvMedicos.DataBind();
                }
            }
            else
            {
                divResultado.Visible = false;
                divBusca.Visible = true;
            }
            carregado = true;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx?q=" + txtBusca.Text);
        }
    }
}