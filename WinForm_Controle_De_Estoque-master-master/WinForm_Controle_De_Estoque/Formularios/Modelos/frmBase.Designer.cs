namespace WinForm_Controle_De_Estoque.Formularios.Modelos
{
	partial class frmBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <Par name="disposing">true if managed resources should be disposed; otherwise, false.</Par>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lblModo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageLista = new System.Windows.Forms.TabPage();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.txtPar2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPar1 = new System.Windows.Forms.TextBox();
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.lblPar1 = new System.Windows.Forms.Label();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.lblPar2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.LinkLabel();
            this.grpDgrv = new System.Windows.Forms.GroupBox();
            this.dataSetDadosDoBanco1 = new WinForm_Controle_De_Estoque.Dados.DataSetDadosDoBanco();
            this.dataSetDadosDoBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.grbPesquisa.SuspendLayout();
            this.grpDgrv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBanco1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Controls.Add(this.btnIncluir);
            this.panel1.Location = new System.Drawing.Point(529, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(165, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(84, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(3, 3);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblModo.Location = new System.Drawing.Point(12, 25);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(34, 13);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Modo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageLista);
            this.tabControl1.Controls.Add(this.tabPageCadastro);
            this.tabControl1.Location = new System.Drawing.Point(3, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 252);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // TabPageLista
            // 
            this.TabPageLista.Controls.Add(this.dgvGrid);
            this.TabPageLista.Controls.Add(this.bindingNavigator1);
            this.TabPageLista.Location = new System.Drawing.Point(4, 22);
            this.TabPageLista.Name = "TabPageLista";
            this.TabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageLista.Size = new System.Drawing.Size(750, 226);
            this.TabPageLista.TabIndex = 0;
            this.TabPageLista.Text = "Lista";
            this.TabPageLista.UseVisualStyleBackColor = true;
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(-1, 31);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(750, 195);
            this.dgvGrid.TabIndex = 1;
            this.dgvGrid.SelectionChanged += new System.EventHandler(this.dgvGrid_SelectionChanged);
            this.dgvGrid.DoubleClick += new System.EventHandler(this.dgvGrid_DoubleClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.AliceBlue;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(744, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(750, 226);
            this.tabPageCadastro.TabIndex = 1;
            this.tabPageCadastro.Text = "Cadastro";
            this.tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.ImageKey = "(nenhum/a)";
            this.btnPesquisar.Location = new System.Drawing.Point(12, 352);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.ImageKey = "(nenhum/a)";
            this.btnFechar.Location = new System.Drawing.Point(621, 352);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(145, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.btnLocalizar);
            this.grbPesquisa.Controls.Add(this.txtPar2);
            this.grbPesquisa.Controls.Add(this.label3);
            this.grbPesquisa.Controls.Add(this.txtPar1);
            this.grbPesquisa.Controls.Add(this.cmbColuna);
            this.grbPesquisa.Controls.Add(this.lblPar1);
            this.grbPesquisa.Controls.Add(this.cmbBuscar);
            this.grbPesquisa.Controls.Add(this.lblPar2);
            this.grbPesquisa.Controls.Add(this.label4);
            this.grbPesquisa.Location = new System.Drawing.Point(12, 381);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(754, 67);
            this.grbPesquisa.TabIndex = 6;
            this.grbPesquisa.TabStop = false;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(628, 5);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(126, 62);
            this.btnLocalizar.TabIndex = 22;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtPar2
            // 
            this.txtPar2.Location = new System.Drawing.Point(506, 33);
            this.txtPar2.Name = "txtPar2";
            this.txtPar2.Size = new System.Drawing.Size(100, 20);
            this.txtPar2.TabIndex = 21;
            this.txtPar2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPar2_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Coluna";
            // 
            // txtPar1
            // 
            this.txtPar1.Location = new System.Drawing.Point(369, 33);
            this.txtPar1.Name = "txtPar1";
            this.txtPar1.Size = new System.Drawing.Size(100, 20);
            this.txtPar1.TabIndex = 20;
            this.txtPar1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPar1_Validating);
            // 
            // cmbColuna
            // 
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Location = new System.Drawing.Point(9, 32);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(140, 21);
            this.cmbColuna.TabIndex = 14;
            // 
            // lblPar1
            // 
            this.lblPar1.AutoSize = true;
            this.lblPar1.Location = new System.Drawing.Point(366, 16);
            this.lblPar1.Name = "lblPar1";
            this.lblPar1.Size = new System.Drawing.Size(64, 13);
            this.lblPar1.TabIndex = 19;
            this.lblPar1.Text = "Parâmetro 1";
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Location = new System.Drawing.Point(158, 32);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(140, 21);
            this.cmbBuscar.TabIndex = 15;
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // lblPar2
            // 
            this.lblPar2.AutoSize = true;
            this.lblPar2.Location = new System.Drawing.Point(503, 16);
            this.lblPar2.Name = "lblPar2";
            this.lblPar2.Size = new System.Drawing.Size(64, 13);
            this.lblPar2.TabIndex = 18;
            this.lblPar2.Text = "Parâmetro 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Buscar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(73, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.TabStop = true;
            this.lblTitulo.Text = "Nome do form";
            // 
            // grpDgrv
            // 
            this.grpDgrv.Controls.Add(this.tabControl1);
            this.grpDgrv.Location = new System.Drawing.Point(12, 77);
            this.grpDgrv.Name = "grpDgrv";
            this.grpDgrv.Size = new System.Drawing.Size(766, 269);
            this.grpDgrv.TabIndex = 8;
            this.grpDgrv.TabStop = false;
            // 
            // dataSetDadosDoBanco1
            // 
            this.dataSetDadosDoBanco1.DataSetName = "DataSetDadosDoBanco";
            this.dataSetDadosDoBanco1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(364, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 58);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 52);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(787, 460);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grpDgrv);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBase_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TabPageLista.ResumeLayout(false);
            this.TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.grpDgrv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBanco1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDadosDoBancoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.DataGridView dgvGrid;
		public System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ErrorProvider errErro;
		public System.Windows.Forms.ComboBox cmbColuna;
        public System.Windows.Forms.LinkLabel lblTitulo;
        private System.Windows.Forms.GroupBox grpDgrv;
		public Dados.DataSetDadosDoBanco dataSetDadosDoBanco1;
		public System.Windows.Forms.BindingSource dataSetDadosDoBancoBindingSource;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Label lblModo;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage TabPageLista;
        public System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.GroupBox grbPesquisa;
        public System.Windows.Forms.TextBox txtPar2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPar1;
        public System.Windows.Forms.Label lblPar1;
        public System.Windows.Forms.ComboBox cmbBuscar;
        public System.Windows.Forms.Label lblPar2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnLocalizar;
        public System.Windows.Forms.TabPage tabPageCadastro;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}