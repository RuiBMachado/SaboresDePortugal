namespace SaboresPortugalGui
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.DefinirPlano = new System.Windows.Forms.Button();
            this.ConsultarDados = new System.Windows.Forms.Button();
            this.EnviarDados = new System.Windows.Forms.Button();
            this.ReceberDados = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DefinirPlano
            // 
            this.DefinirPlano.Location = new System.Drawing.Point(511, 49);
            this.DefinirPlano.Margin = new System.Windows.Forms.Padding(2);
            this.DefinirPlano.Name = "DefinirPlano";
            this.DefinirPlano.Size = new System.Drawing.Size(155, 61);
            this.DefinirPlano.TabIndex = 0;
            this.DefinirPlano.Text = "Definir Plano de Atividades";
            this.DefinirPlano.UseVisualStyleBackColor = true;
            this.DefinirPlano.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultarDados
            // 
            this.ConsultarDados.Location = new System.Drawing.Point(511, 171);
            this.ConsultarDados.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultarDados.Name = "ConsultarDados";
            this.ConsultarDados.Size = new System.Drawing.Size(155, 63);
            this.ConsultarDados.TabIndex = 1;
            this.ConsultarDados.Text = "Consultar Dados Recolhidos";
            this.ConsultarDados.UseVisualStyleBackColor = true;
            this.ConsultarDados.Click += new System.EventHandler(this.ConsultarDados_Click);
            // 
            // EnviarDados
            // 
            this.EnviarDados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EnviarDados.Location = new System.Drawing.Point(511, 276);
            this.EnviarDados.Margin = new System.Windows.Forms.Padding(2);
            this.EnviarDados.Name = "EnviarDados";
            this.EnviarDados.Size = new System.Drawing.Size(155, 77);
            this.EnviarDados.TabIndex = 2;
            this.EnviarDados.Text = "Enviar dados para Mobile";
            this.EnviarDados.UseVisualStyleBackColor = true;
            this.EnviarDados.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReceberDados
            // 
            this.ReceberDados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReceberDados.Location = new System.Drawing.Point(511, 391);
            this.ReceberDados.Margin = new System.Windows.Forms.Padding(2);
            this.ReceberDados.Name = "ReceberDados";
            this.ReceberDados.Size = new System.Drawing.Size(155, 77);
            this.ReceberDados.TabIndex = 3;
            this.ReceberDados.Text = "Receber dados Mobile";
            this.ReceberDados.UseVisualStyleBackColor = true;
            this.ReceberDados.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(810, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReceberDados);
            this.Controls.Add(this.EnviarDados);
            this.Controls.Add(this.ConsultarDados);
            this.Controls.Add(this.DefinirPlano);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabores Portugal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DefinirPlano;
        private System.Windows.Forms.Button ConsultarDados;
        private System.Windows.Forms.Button EnviarDados;
        private System.Windows.Forms.Button ReceberDados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

