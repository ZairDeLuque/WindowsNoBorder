namespace WindowsNoBorder_ZDLS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBar_Titulo = new System.Windows.Forms.Panel();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBar_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar_Titulo
            // 
            this.panelBar_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBar_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelBar_Titulo.Controls.Add(this.minimizar);
            this.panelBar_Titulo.Controls.Add(this.maximizar);
            this.panelBar_Titulo.Controls.Add(this.cerrar);
            this.panelBar_Titulo.Controls.Add(this.title);
            this.panelBar_Titulo.Location = new System.Drawing.Point(0, 0);
            this.panelBar_Titulo.Name = "panelBar_Titulo";
            this.panelBar_Titulo.Size = new System.Drawing.Size(1008, 23);
            this.panelBar_Titulo.TabIndex = 0;
            this.panelBar_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minimizar.ForeColor = System.Drawing.Color.White;
            this.minimizar.Location = new System.Drawing.Point(915, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(27, 23);
            this.minimizar.TabIndex = 3;
            this.minimizar.Text = "-";
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maximizar.ForeColor = System.Drawing.Color.White;
            this.maximizar.Location = new System.Drawing.Point(948, 0);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(27, 23);
            this.maximizar.TabIndex = 2;
            this.maximizar.Text = "[]";
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(981, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(27, 23);
            this.cerrar.TabIndex = 1;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(478, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 13);
            this.title.TabIndex = 1;
            this.title.Text = "[TITULO]";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelContenedor.Location = new System.Drawing.Point(0, 23);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1008, 488);
            this.panelContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBar_Titulo);
            this.Name = "Form1";
            this.Text = "WindowsNoBorder | ZairDeLuque Studios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panelBar_Titulo.ResumeLayout(false);
            this.panelBar_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBar_Titulo;
        private Label title;
        private Button cerrar;
        private Button minimizar;
        private Button maximizar;
        private Panel panelContenedor;
    }
}