namespace Proyecto
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.PictureBox();
            this.BtnMax = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnResiz = new System.Windows.Forms.PictureBox();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BarraTitulo.Controls.Add(this.BtnResiz);
            this.BarraTitulo.Controls.Add(this.BtnMin);
            this.BarraTitulo.Controls.Add(this.BtnMax);
            this.BarraTitulo.Controls.Add(this.BtnExit);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.BarraTitulo.TabIndex = 0;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.BtnEmpleados);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 615);
            this.MenuVertical.TabIndex = 1;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(220, 35);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1080, 615);
            this.PanelCentral.TabIndex = 2;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(1261, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 35);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(1216, 0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(39, 35);
            this.BtnMax.TabIndex = 1;
            this.BtnMax.TabStop = false;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(1171, 12);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(39, 29);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnResiz
            // 
            this.BtnResiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResiz.Image = ((System.Drawing.Image)(resources.GetObject("BtnResiz.Image")));
            this.BtnResiz.Location = new System.Drawing.Point(1216, 0);
            this.BtnResiz.Name = "BtnResiz";
            this.BtnResiz.Size = new System.Drawing.Size(39, 35);
            this.BtnResiz.TabIndex = 3;
            this.BtnResiz.TabStop = false;
            this.BtnResiz.Visible = false;
            this.BtnResiz.Click += new System.EventHandler(this.BtnResiz_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(23)))));
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("BtnEmpleados.Image")));
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(6, 79);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(214, 43);
            this.BtnEmpleados.TabIndex = 0;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(225)))));
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 43);
            this.panel1.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnResiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BtnExit;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox BtnMax;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnResiz;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Panel panel1;
    }
}

