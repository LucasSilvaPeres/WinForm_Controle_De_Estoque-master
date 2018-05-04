using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinForm_Controle_De_Estoque.Dados;
using WinForm_Controle_De_Estoque.Dados.DataSetDadosDoBancoTableAdapters;

namespace WinForm_Controle_De_Estoque.Formularios.Cadastros
{
    public partial class FrmCadCategoria : WinForm_Controle_De_Estoque.Formularios.Modelos.FrmBase
    {
        public FrmCadCategoria()
        {
            InitializeComponent();
        }
        public override void Atualiza_Grid()
        {
            try
            {
                this.Text = lblTitulo.Text = "Categoriass de Produtos";
                DataSetDadosDoBanco.CategoriasDataTable dt = new DataSetDadosDoBanco.CategoriasDataTable();
                CategoriasTableAdapter ta = new CategoriasTableAdapter();
                //dt=ta.GetData();
                DataSetDadosDoBanco ds = new DataSetDadosDoBanco();
                ta.Fill(ds.Categorias);
                dataSetDadosDoBancoBindingSource.DataSource = ds.Categorias;
                dgvGrid.DataSource = dataSetDadosDoBancoBindingSource;
                bindingNavigator1.BindingSource = dataSetDadosDoBancoBindingSource;

                //Configuração das colunas do DataGridView
                dgvGrid.Columns[0].HeaderText = "ID";
                dgvGrid.Columns[0].Width = 50;
                dgvGrid.Columns[1].HeaderText = "Nome da categoria";
                dgvGrid.Columns[1].Width = 300;

                //Carrega a combo com as colunas
                if (cmbColuna.Items.Count == 0)
                {
                    foreach (DataColumn coluna in ds.Categorias.Columns)
                    {
                        cmbColuna.Items.Add(coluna.ColumnName);
                    }

                }
                dtGenerico = ds.Categorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override void CarregaValores()
        {
            try
            {
                txtCodigo.Text = dgvGrid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvGrid.CurrentRow.Cells["cat_Descricao"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public override bool Salvar()
        {
            bool bSalvar = false;
            CategoriasTableAdapter ta = new CategoriasTableAdapter();
            if (sStatus == StatusCadastro.scIncluindo)
            {
                bSalvar = (ta.Insert(txtNome.Text) > 0);
            }
            else if (sStatus == StatusCadastro.scAlterando)
            {
                bSalvar = (ta.Update(txtNome.Text, nCodGenerico) > 0);
            }
            return bSalvar;
        }
        public override bool Excluir()
        {
            bool bExcluir = false;
            CategoriasTableAdapter ta = new CategoriasTableAdapter();
            bExcluir = (ta.Delete(nCodGenerico) > 0);
            return bExcluir;
        }
    }
}
