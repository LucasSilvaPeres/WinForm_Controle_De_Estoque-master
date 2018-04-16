﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Controle_De_Estoque.Formularios.Sistema
{
	public partial class MDI_Menu : Form
	{
		public MDI_Menu()
		{
			InitializeComponent();
		}

		private void MDI_Menu_Load(object sender, EventArgs e)
		{
			staHora.Text = DateTime.Now.ToShortDateString();
			staUsuario.Text = "USUÁRIO ATUAL: " + Properties.Settings.Default.NomeUsuarioLogado.ToUpper();
			//Checa_Teclas();
		}

		private void MDI_Menu_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.NumLock)
				staNum.Text = staNum.Text == "NUM" ? "" : "NUM";
			if (e.KeyCode == Keys.CapsLock)
				staCaps.Text = staCaps.Text == "CAP" ? "" : "CAP";

			//Checa_Teclas();
		}
		//private void Checa_Teclas()
		//{
		//	//Verifica CAPSLOCK
		//	if (Control.IsKeyLocked(Keys.CapsLock))
		//	{
		//		staCaps.Text = "CAP";
		//		// staCaps.BorderStyle = Border3DStyle.Raised;
		//	}
		//	else
		//	{
		//		staCaps.Text = "";
		//		// staCaps.BorderStyle = Border3DStyle.Sunken;
		//	}
		//	//Verifica NUMLOCK
		//	if (Control.IsKeyLocked(Keys.NumLock))
		//	{
		//		staNum.Text = "NUM";
		//		// staCaps.BorderStyle = Border3DStyle.Raised;
		//	}
		//	else
		//	{
		//		staNum.Text = "";
		//		// staCaps.BorderStyle = Border3DStyle.Sunken;
		//	}
		//}

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
		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			//frmCadCategoria frmCategoria = new frmCadCategoria();
			//frmCategoria.MdiParent = this;
			//frmCategoria.Show();
		}


		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			//if (Properties.Settings.Default.NivelUsuarioLogado != 1)
			//{
			//    MessageBox.Show("Você não tem acesso a este cadastro");
			//}
			//else
			//{
			//    frmCadUsuario frmUsuario = new frmCadUsuario();
			//    frmUsuario.MdiParent = this;
			//    frmUsuario.Show();
			//}
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


		//private void calculadoraToolStripMenuItem_Click(object sender etccccccccc)
		//{
		//    System.Diagnostics.Process.Start("Calc.exe");
		//}
		//private void rascunhoToolStripMenuItem_Click(object sender etccccccccc)
		//{
		//    ProcessStartInfo startInfo = new ProcessStartInfo("Notepad.exe");
		//    startInfo.WindowStyle = ProcessWindowStyle.Maximized;
		//    System.Diagnostics.Process.Start(startInfo);
		//}
		//private void internetToolStripMenuItem_Click(object sender etccccccccc)
		//{
		//    System.Diagnostics.Process.Start("IExplorer.exe", "www.terra.com.br");
		//}
		//private void cascataToolStripMenuItem_Click(object sender etccccccccc)
		//{
		//    this.LayoutMdi(MdiLayout.Cascade);
		//}
		//arranjoVertical
		//    this.LayoutMdi(MdiLayout.TileVertical);
		//arranjoHorizontal
		//    this.LayoutMdi(MdiLayout.TileHorizontal); 




	}
}
