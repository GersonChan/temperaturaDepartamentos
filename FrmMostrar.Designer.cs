﻿namespace temperaturaDepartamentos
{
    partial class FrmMostrar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaMasAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaMasBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPromedio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(217, 306);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaturaMasAltaToolStripMenuItem,
            this.temperaturaMasBajaToolStripMenuItem});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // temperaturaMasAltaToolStripMenuItem
            // 
            this.temperaturaMasAltaToolStripMenuItem.Name = "temperaturaMasAltaToolStripMenuItem";
            this.temperaturaMasAltaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.temperaturaMasAltaToolStripMenuItem.Text = "Temperatura mas alta";
            this.temperaturaMasAltaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaMasAltaToolStripMenuItem_Click);
            // 
            // temperaturaMasBajaToolStripMenuItem
            // 
            this.temperaturaMasBajaToolStripMenuItem.Name = "temperaturaMasBajaToolStripMenuItem";
            this.temperaturaMasBajaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.temperaturaMasBajaToolStripMenuItem.Text = "Temperatura mas baja";
            this.temperaturaMasBajaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaMasBajaToolStripMenuItem_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Enabled = false;
            this.btnPromedio.Location = new System.Drawing.Point(484, 306);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(82, 39);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio de temperatura";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaMasAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaMasBajaToolStripMenuItem;
        private System.Windows.Forms.Button btnPromedio;
    }
}