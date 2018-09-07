namespace DesktopApp
{
    partial class BaseForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.pnlBotoesPesquisa = new System.Windows.Forms.Panel();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.btnSairPesquisa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tpManutencao = new System.Windows.Forms.TabPage();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.pnlBotoesManutencao = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSairManutencao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tcPrincipal.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.pnlBotoesPesquisa.SuspendLayout();
            this.tpManutencao.SuspendLayout();
            this.pnlBotoesManutencao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPrincipal.Controls.Add(this.tpPesquisa);
            this.tcPrincipal.Controls.Add(this.tpManutencao);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.ImageList = this.imageList1;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(800, 450);
            this.tcPrincipal.TabIndex = 2;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvPesquisa);
            this.tpPesquisa.Controls.Add(this.pnlBotoesPesquisa);
            this.tpPesquisa.ImageKey = "search.png";
            this.tpPesquisa.Location = new System.Drawing.Point(4, 26);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(792, 420);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa de Registros...";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AllowUserToOrderColumns = true;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPesquisa.Location = new System.Drawing.Point(3, 3);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(786, 374);
            this.dgvPesquisa.TabIndex = 1;
            // 
            // pnlBotoesPesquisa
            // 
            this.pnlBotoesPesquisa.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoesPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotoesPesquisa.Controls.Add(this.lblPesquisar);
            this.pnlBotoesPesquisa.Controls.Add(this.btnSairPesquisa);
            this.pnlBotoesPesquisa.Controls.Add(this.btnPesquisar);
            this.pnlBotoesPesquisa.Controls.Add(this.txtPesquisar);
            this.pnlBotoesPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoesPesquisa.Location = new System.Drawing.Point(3, 377);
            this.pnlBotoesPesquisa.Name = "pnlBotoesPesquisa";
            this.pnlBotoesPesquisa.Size = new System.Drawing.Size(786, 40);
            this.pnlBotoesPesquisa.TabIndex = 0;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(238, 13);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // btnSairPesquisa
            // 
            this.btnSairPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairPesquisa.ImageKey = "back.png";
            this.btnSairPesquisa.ImageList = this.imageList1;
            this.btnSairPesquisa.Location = new System.Drawing.Point(4, 6);
            this.btnSairPesquisa.Name = "btnSairPesquisa";
            this.btnSairPesquisa.Size = new System.Drawing.Size(68, 26);
            this.btnSairPesquisa.TabIndex = 2;
            this.btnSairPesquisa.Text = "&Sair";
            this.btnSairPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSairPesquisa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "pencil.png");
            this.imageList1.Images.SetKeyName(2, "binoculars.png");
            this.imageList1.Images.SetKeyName(3, "back.png");
            this.imageList1.Images.SetKeyName(4, "success.png");
            this.imageList1.Images.SetKeyName(5, "error.png");
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageKey = "binoculars.png";
            this.btnPesquisar.ImageList = this.imageList1;
            this.btnPesquisar.Location = new System.Drawing.Point(691, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 26);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(300, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(385, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // tpManutencao
            // 
            this.tpManutencao.Controls.Add(this.pnlControles);
            this.tpManutencao.Controls.Add(this.pnlBotoesManutencao);
            this.tpManutencao.ImageKey = "pencil.png";
            this.tpManutencao.Location = new System.Drawing.Point(4, 26);
            this.tpManutencao.Name = "tpManutencao";
            this.tpManutencao.Padding = new System.Windows.Forms.Padding(3);
            this.tpManutencao.Size = new System.Drawing.Size(792, 420);
            this.tpManutencao.TabIndex = 1;
            this.tpManutencao.Text = "Manutenção...";
            // 
            // pnlControles
            // 
            this.pnlControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControles.Location = new System.Drawing.Point(3, 3);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(786, 374);
            this.pnlControles.TabIndex = 2;
            // 
            // pnlBotoesManutencao
            // 
            this.pnlBotoesManutencao.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoesManutencao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBotoesManutencao.Controls.Add(this.btnCancelar);
            this.pnlBotoesManutencao.Controls.Add(this.btnSairManutencao);
            this.pnlBotoesManutencao.Controls.Add(this.btnSalvar);
            this.pnlBotoesManutencao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoesManutencao.Location = new System.Drawing.Point(3, 377);
            this.pnlBotoesManutencao.Name = "pnlBotoesManutencao";
            this.pnlBotoesManutencao.Size = new System.Drawing.Size(786, 40);
            this.pnlBotoesManutencao.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageKey = "error.png";
            this.btnCancelar.ImageList = this.imageList1;
            this.btnCancelar.Location = new System.Drawing.Point(596, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 26);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSairManutencao
            // 
            this.btnSairManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairManutencao.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairManutencao.ImageKey = "back.png";
            this.btnSairManutencao.ImageList = this.imageList1;
            this.btnSairManutencao.Location = new System.Drawing.Point(4, 6);
            this.btnSairManutencao.Name = "btnSairManutencao";
            this.btnSairManutencao.Size = new System.Drawing.Size(68, 26);
            this.btnSairManutencao.TabIndex = 2;
            this.btnSairManutencao.Text = "&Sair";
            this.btnSairManutencao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSairManutencao.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ImageKey = "success.png";
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(691, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 26);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcPrincipal);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBase";
            this.tcPrincipal.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.pnlBotoesPesquisa.ResumeLayout(false);
            this.pnlBotoesPesquisa.PerformLayout();
            this.tpManutencao.ResumeLayout(false);
            this.pnlBotoesManutencao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpManutencao;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlBotoesPesquisa;
        private System.Windows.Forms.Button btnSairPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Panel pnlBotoesManutencao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSairManutencao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlControles;
    }
}

