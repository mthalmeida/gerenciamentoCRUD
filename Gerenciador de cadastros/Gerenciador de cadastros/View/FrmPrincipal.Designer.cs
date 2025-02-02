namespace Gerenciador_de_cadastros.View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.dataGridViewPessoas = new System.Windows.Forms.DataGridView();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.maskedTextBoxPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanelBotoes = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonLogs = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRodape = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.flowLayoutPanelBotoes.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPessoas
            // 
            this.dataGridViewPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPessoas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPessoas.Name = "dataGridViewPessoas";
            this.dataGridViewPessoas.ReadOnly = true;
            this.dataGridViewPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPessoas.Size = new System.Drawing.Size(800, 341);
            this.dataGridViewPessoas.TabIndex = 0;
            this.dataGridViewPessoas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoas_CellClick);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Controls.Add(this.buttonPesquisar);
            this.panelSuperior.Controls.Add(this.maskedTextBoxPesquisar);
            this.panelSuperior.Controls.Add(this.flowLayoutPanelBotoes);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(800, 109);
            this.panelSuperior.TabIndex = 4;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_pesquisar_16;
            this.buttonPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesquisar.Location = new System.Drawing.Point(268, 68);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(78, 25);
            this.buttonPesquisar.TabIndex = 7;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // maskedTextBoxPesquisar
            // 
            this.maskedTextBoxPesquisar.Location = new System.Drawing.Point(15, 71);
            this.maskedTextBoxPesquisar.Name = "maskedTextBoxPesquisar";
            this.maskedTextBoxPesquisar.Size = new System.Drawing.Size(247, 20);
            this.maskedTextBoxPesquisar.TabIndex = 6;
            // 
            // flowLayoutPanelBotoes
            // 
            this.flowLayoutPanelBotoes.Controls.Add(this.buttonSair);
            this.flowLayoutPanelBotoes.Controls.Add(this.buttonLogs);
            this.flowLayoutPanelBotoes.Controls.Add(this.buttonAtualizar);
            this.flowLayoutPanelBotoes.Controls.Add(this.buttonRelatorio);
            this.flowLayoutPanelBotoes.Controls.Add(this.buttonAdicionar);
            this.flowLayoutPanelBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelBotoes.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelBotoes.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBotoes.Name = "flowLayoutPanelBotoes";
            this.flowLayoutPanelBotoes.Padding = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.flowLayoutPanelBotoes.Size = new System.Drawing.Size(800, 62);
            this.flowLayoutPanelBotoes.TabIndex = 5;
            this.flowLayoutPanelBotoes.WrapContents = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSair.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_sair_32;
            this.buttonSair.Location = new System.Drawing.Point(739, 13);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(38, 38);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonLogs
            // 
            this.buttonLogs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogs.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_log_32;
            this.buttonLogs.Location = new System.Drawing.Point(695, 13);
            this.buttonLogs.Name = "buttonLogs";
            this.buttonLogs.Size = new System.Drawing.Size(38, 38);
            this.buttonLogs.TabIndex = 5;
            this.buttonLogs.UseVisualStyleBackColor = false;
            this.buttonLogs.Click += new System.EventHandler(this.buttonLogs_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAtualizar.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_synchronize_32;
            this.buttonAtualizar.Location = new System.Drawing.Point(651, 13);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(38, 38);
            this.buttonAtualizar.TabIndex = 1;
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRelatorio.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_termos_e_condições_32;
            this.buttonRelatorio.Location = new System.Drawing.Point(607, 13);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(38, 38);
            this.buttonRelatorio.TabIndex = 3;
            this.buttonRelatorio.UseVisualStyleBackColor = false;
            this.buttonRelatorio.Click += new System.EventHandler(this.buttonRelatorio_Click);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionar.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_adicionar_32;
            this.buttonAdicionar.Location = new System.Drawing.Point(563, 13);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(38, 38);
            this.buttonAdicionar.TabIndex = 2;
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.panelInferior);
            this.panelGrid.Controls.Add(this.dataGridViewPessoas);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 109);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(800, 341);
            this.panelGrid.TabIndex = 5;
            // 
            // panelInferior
            // 
            this.panelInferior.Controls.Add(this.flowLayoutPanel1);
            this.panelInferior.Controls.Add(this.labelRodape);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 305);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(800, 36);
            this.panelInferior.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 0);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // labelRodape
            // 
            this.labelRodape.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRodape.Location = new System.Drawing.Point(12, 7);
            this.labelRodape.Name = "labelRodape";
            this.labelRodape.Size = new System.Drawing.Size(788, 23);
            this.labelRodape.TabIndex = 1;
            this.labelRodape.Text = "labelTextoRodape";
            this.labelRodape.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Gerenciamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoas)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.flowLayoutPanelBotoes.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPessoas;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBotoes;
        private System.Windows.Forms.Label labelRodape;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonLogs;
    }
}