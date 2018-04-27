using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class frmCadUsuario : WinForm_Controle_De_Estoque.Formularios.Modelos.frmBase
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetDadosDoBanco1.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.dataSetDadosDoBanco1.Usuario);

        }
    }
}
