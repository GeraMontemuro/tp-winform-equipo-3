﻿namespace TPWinForm_equipo_3
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnListado = new System.Windows.Forms.Button();
            this.btnsalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.Color.Transparent;
            this.btnListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListado.FlatAppearance.BorderSize = 0;
            this.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListado.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.ForeColor = System.Drawing.Color.Transparent;
            this.btnListado.Location = new System.Drawing.Point(19, 379);
            this.btnListado.Margin = new System.Windows.Forms.Padding(2);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(240, 57);
            this.btnListado.TabIndex = 0;
            this.btnListado.Text = "VER LISTADO";
            this.btnListado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnsalida
            // 
            this.btnsalida.BackColor = System.Drawing.Color.Transparent;
            this.btnsalida.FlatAppearance.BorderSize = 0;
            this.btnsalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalida.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalida.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalida.Location = new System.Drawing.Point(81, 481);
            this.btnsalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(178, 41);
            this.btnsalida.TabIndex = 1;
            this.btnsalida.Text = "SALIR";
            this.btnsalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalida.UseVisualStyleBackColor = false;
            this.btnsalida.Click += new System.EventHandler(this.btnsalida_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(526, 547);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.btnListado);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 586);
            this.MinimumSize = new System.Drawing.Size(542, 586);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnsalida;
    }
}