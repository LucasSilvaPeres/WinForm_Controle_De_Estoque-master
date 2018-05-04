using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Formularios.Cadastros;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void MDI_Menu_Load(object sender, EventArgs e)
		{
			staHora.Text = DateTime.Now.ToShortDateString();
			staUsuario.Text = "USUÁRIO ATUAL: " + Properties.Settings.Default.NomeUsuarioLogado.ToUpper();
            Checa_Teclas();
        }

		private void MDI_Menu_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.NumLock)
				staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
			if (e.KeyCode == Keys.CapsLock)
				staCaps.Text = staCaps.Text == "CAP" ? "" : "CAP";
		}
        private void Checa_Teclas()
        {
            //Verifica CAPSLOCK
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                staCaps.Text = "CAP";
                // staCaps.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staCaps.Text = "";
                // staCaps.BorderStyle = Border3DStyle.Sunken;
            }
            //Verifica NUMLOCK
            if (Control.IsKeyLocked(Keys.NumLock))
            {
                staNum.Text = "NUM";
                // staCaps.BorderStyle = Border3DStyle.Raised;
            }
            else
            {
                staNum.Text = "";
                // staCaps.BorderStyle = Border3DStyle.Sunken;
            }
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Deseja Realmente sair?", "Confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				e.Cancel = true;
			else
				Application.ExitThread();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			staHora.Text = DateTime.Now.ToShortTimeString();
		}


		private void toolStripButton3_Click(object sender, EventArgs e)
		{
            if (Properties.Settings.Default.NivelUsuarioLogado != 1)
            {
                MessageBox.Show("Você não tem acesso a este cadastro");
            }
            else
            {
                FrmCadUsuario frmUsuario = new FrmCadUsuario();
                frmUsuario.MdiParent = this;
                frmUsuario.Show();
            }
        }

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			//    frmCadProduto frmProduto = new frmCadProduto();
			//    frmProduto.MdiParent = this;
			//    frmProduto.Show();
		}

		private void toolStripButton10_Click(object sender, EventArgs e)
		{
			//    frmCadVendas frmVendas = new frmCadVendas();
			//    frmVendas.MdiParent = this;
			//    frmVendas.Show();
		}

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCategoria frmCategoria = new FrmCadCategoria();
            frmCategoria.MdiParent = this;
            frmCategoria.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.NivelUsuarioLogado != 1)
            {
                MessageBox.Show("Você não tem acesso a este cadastro");
            }
            else
            {
                FrmCadUsuario frmusuario = new FrmCadUsuario();
                frmusuario.MdiParent = this;
                frmusuario.Show();
            }
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void rascunhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            System.Diagnostics.Process.Start(startInfo);
        }

        private void internetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe", "www.terra.com.br");
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

    }
}
