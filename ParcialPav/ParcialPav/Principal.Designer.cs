﻿namespace ParcialPav
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consignaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporte1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consignaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consignaToolStripMenuItem
            // 
            this.consignaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeEquipoToolStripMenuItem,
            this.reporte1ToolStripMenuItem});
            this.consignaToolStripMenuItem.Name = "consignaToolStripMenuItem";
            this.consignaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.consignaToolStripMenuItem.Text = "Consigna";
            // 
            // altaDeEquipoToolStripMenuItem
            // 
            this.altaDeEquipoToolStripMenuItem.Name = "altaDeEquipoToolStripMenuItem";
            this.altaDeEquipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeEquipoToolStripMenuItem.Text = "Alta de Equipo";
            this.altaDeEquipoToolStripMenuItem.Click += new System.EventHandler(this.altaDeEquipoToolStripMenuItem_Click);
            // 
            // reporte1ToolStripMenuItem
            // 
            this.reporte1ToolStripMenuItem.Name = "reporte1ToolStripMenuItem";
            this.reporte1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporte1ToolStripMenuItem.Text = "Reporte 1";
            this.reporte1ToolStripMenuItem.Click += new System.EventHandler(this.reporte1ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consignaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporte1ToolStripMenuItem;
    }
}

