﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUsuarios.aspx");
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminVentas.aspx");
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminProductos.aspx");
        }

       

        protected void btnPlatafomas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPlataformas.aspx");
        }

        protected void btnCategorias_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCategorias.aspx");
        }

        protected void btnMarcas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMarca.aspx");
        }

        public void btnLogout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }

        protected void btnGeneros_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminGenero.aspx");
        }
    }
}