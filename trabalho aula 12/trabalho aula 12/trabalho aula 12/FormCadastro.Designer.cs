﻿
namespace trabalho_aula_12
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 75);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(389, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(206, 165);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(389, 27);
            txtPreco.TabIndex = 1;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(206, 228);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(205, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
    }
}