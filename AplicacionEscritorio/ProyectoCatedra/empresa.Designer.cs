namespace ProyectoCatedra
{
    partial class empresa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtDevo = new System.Windows.Forms.TextBox();
            this.btnBuscarD = new System.Windows.Forms.Button();
            this.btnMostra = new System.Windows.Forms.Button();
            this.dtgDevo = new System.Windows.Forms.DataGridView();
            this.btnM = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 470);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empresa";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 423);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnV);
            this.tabPage1.Controls.Add(this.txtCompra);
            this.tabPage1.Controls.Add(this.btnB);
            this.tabPage1.Controls.Add(this.btnMostrar);
            this.tabPage1.Controls.Add(this.dtgCompras);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comprar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnM);
            this.tabPage2.Controls.Add(this.txtDevo);
            this.tabPage2.Controls.Add(this.btnBuscarD);
            this.tabPage2.Controls.Add(this.btnMostra);
            this.tabPage2.Controls.Add(this.dtgDevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devoluciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgCompras
            // 
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompras.Location = new System.Drawing.Point(4, 111);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.Size = new System.Drawing.Size(706, 276);
            this.dtgCompras.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(7, 23);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(168, 44);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Compras";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(204, 23);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(168, 44);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "Buscar Compras";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(387, 34);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(281, 23);
            this.txtCompra.TabIndex = 3;
            // 
            // txtDevo
            // 
            this.txtDevo.Location = new System.Drawing.Point(388, 25);
            this.txtDevo.Name = "txtDevo";
            this.txtDevo.Size = new System.Drawing.Size(281, 23);
            this.txtDevo.TabIndex = 7;
            // 
            // btnBuscarD
            // 
            this.btnBuscarD.Location = new System.Drawing.Point(205, 14);
            this.btnBuscarD.Name = "btnBuscarD";
            this.btnBuscarD.Size = new System.Drawing.Size(168, 44);
            this.btnBuscarD.TabIndex = 6;
            this.btnBuscarD.Text = "Buscar Devoluciones";
            this.btnBuscarD.UseVisualStyleBackColor = true;
            this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(8, 14);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(168, 44);
            this.btnMostra.TabIndex = 5;
            this.btnMostra.Text = "Mostrar Devoluciones";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // dtgDevo
            // 
            this.dtgDevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevo.Location = new System.Drawing.Point(5, 102);
            this.dtgDevo.Name = "dtgDevo";
            this.dtgDevo.Size = new System.Drawing.Size(706, 276);
            this.dtgDevo.TabIndex = 4;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(205, 64);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(168, 32);
            this.btnM.TabIndex = 8;
            this.btnM.Text = "Volver al menu";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(204, 73);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(168, 32);
            this.btnV.TabIndex = 9;
            this.btnV.Text = "Volver al menu";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 494);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empresa";
            this.Text = "empresa";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.TextBox txtDevo;
        private System.Windows.Forms.Button btnBuscarD;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.DataGridView dtgDevo;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnV;
    }
}