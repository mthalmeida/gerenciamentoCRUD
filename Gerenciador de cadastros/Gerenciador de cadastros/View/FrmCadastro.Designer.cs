namespace Gerenciador_de_cadastros.View
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.maskedTextBoxEndereco = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxEmail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLogin = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDocumento = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDescricao = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePickerDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonVisualizarOcularSenha = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBoxEndereco
            // 
            this.maskedTextBoxEndereco.Location = new System.Drawing.Point(12, 220);
            this.maskedTextBoxEndereco.Name = "maskedTextBoxEndereco";
            this.maskedTextBoxEndereco.Size = new System.Drawing.Size(576, 20);
            this.maskedTextBoxEndereco.TabIndex = 7;
            this.maskedTextBoxEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxEndereco_KeyPress);
            // 
            // maskedTextBoxEmail
            // 
            this.maskedTextBoxEmail.Location = new System.Drawing.Point(139, 167);
            this.maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            this.maskedTextBoxEmail.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBoxEmail.TabIndex = 6;
            this.maskedTextBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxEmail_KeyPress);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(12, 167);
            this.maskedTextBoxTelefone.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxTelefone.TabIndex = 5;
            // 
            // maskedTextBoxSenha
            // 
            this.maskedTextBoxSenha.Location = new System.Drawing.Point(165, 105);
            this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
            this.maskedTextBoxSenha.Size = new System.Drawing.Size(156, 20);
            this.maskedTextBoxSenha.TabIndex = 3;
            this.maskedTextBoxSenha.UseSystemPasswordChar = true;
            this.maskedTextBoxSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxSenha_KeyPress);
            // 
            // maskedTextBoxLogin
            // 
            this.maskedTextBoxLogin.Location = new System.Drawing.Point(12, 105);
            this.maskedTextBoxLogin.Name = "maskedTextBoxLogin";
            this.maskedTextBoxLogin.Size = new System.Drawing.Size(147, 20);
            this.maskedTextBoxLogin.TabIndex = 2;
            this.maskedTextBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxLogin_KeyPress);
            // 
            // maskedTextBoxDocumento
            // 
            this.maskedTextBoxDocumento.Location = new System.Drawing.Point(359, 44);
            this.maskedTextBoxDocumento.Mask = "000.000.000-00";
            this.maskedTextBoxDocumento.Name = "maskedTextBoxDocumento";
            this.maskedTextBoxDocumento.Size = new System.Drawing.Size(229, 20);
            this.maskedTextBoxDocumento.TabIndex = 1;
            this.maskedTextBoxDocumento.ValidatingType = typeof(int);
            // 
            // maskedTextBoxDescricao
            // 
            this.maskedTextBoxDescricao.Location = new System.Drawing.Point(12, 44);
            this.maskedTextBoxDescricao.Name = "maskedTextBoxDescricao";
            this.maskedTextBoxDescricao.Size = new System.Drawing.Size(341, 20);
            this.maskedTextBoxDescricao.TabIndex = 0;
            this.maskedTextBoxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxDescricao_KeyPress);
            // 
            // dateTimePickerDataNascimento
            // 
            this.dateTimePickerDataNascimento.Location = new System.Drawing.Point(351, 105);
            this.dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            this.dateTimePickerDataNascimento.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerDataNascimento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de nascimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Endereço";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonVisualizarOcularSenha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBoxEndereco);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maskedTextBoxDocumento);
            this.groupBox1.Controls.Add(this.maskedTextBoxEmail);
            this.groupBox1.Controls.Add(this.maskedTextBoxDescricao);
            this.groupBox1.Controls.Add(this.maskedTextBoxTelefone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerDataNascimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBoxLogin);
            this.groupBox1.Controls.Add(this.maskedTextBoxSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de usuário";
            // 
            // buttonVisualizarOcularSenha
            // 
            this.buttonVisualizarOcularSenha.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_visualizar_arquivo_16;
            this.buttonVisualizarOcularSenha.Location = new System.Drawing.Point(318, 103);
            this.buttonVisualizarOcularSenha.Name = "buttonVisualizarOcularSenha";
            this.buttonVisualizarOcularSenha.Size = new System.Drawing.Size(27, 24);
            this.buttonVisualizarOcularSenha.TabIndex = 17;
            this.buttonVisualizarOcularSenha.UseVisualStyleBackColor = true;
            this.buttonVisualizarOcularSenha.Click += new System.EventHandler(this.buttonVisualizarOcularSenha_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelId.Location = new System.Drawing.Point(21, 18);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(23, 17);
            this.labelId.TabIndex = 17;
            this.labelId.Text = "ID";
            this.labelId.Visible = false;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(537, 339);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 19;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(456, 339);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Image = global::Gerenciador_de_cadastros.Properties.Resources.icons8_remover_32__1_;
            this.buttonExcluir.Location = new System.Drawing.Point(568, 18);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(38, 38);
            this.buttonExcluir.TabIndex = 21;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Visible = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLogin;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDocumento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDescricao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonVisualizarOcularSenha;
    }
}