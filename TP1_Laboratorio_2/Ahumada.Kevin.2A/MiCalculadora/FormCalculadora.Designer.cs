namespace MiCalculadora
{
    partial class FormCalculadora
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
            this.txt_Operando1 = new System.Windows.Forms.TextBox();
            this.txt_Operando2 = new System.Windows.Forms.TextBox();
            this.cbo_Operador = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Operar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_ConvertBin = new System.Windows.Forms.Button();
            this.btn_ConvertDec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Operando1
            // 
            this.txt_Operando1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operando1.Location = new System.Drawing.Point(12, 12);
            this.txt_Operando1.Name = "txt_Operando1";
            this.txt_Operando1.Size = new System.Drawing.Size(239, 33);
            this.txt_Operando1.TabIndex = 0;
            this.txt_Operando1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Operando2
            // 
            this.txt_Operando2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Operando2.Location = new System.Drawing.Point(327, 12);
            this.txt_Operando2.Name = "txt_Operando2";
            this.txt_Operando2.Size = new System.Drawing.Size(239, 33);
            this.txt_Operando2.TabIndex = 2;
            this.txt_Operando2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_Operador
            // 
            this.cbo_Operador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Operador.FormattingEnabled = true;
            this.cbo_Operador.Location = new System.Drawing.Point(257, 12);
            this.cbo_Operador.Name = "cbo_Operador";
            this.cbo_Operador.Size = new System.Drawing.Size(64, 33);
            this.cbo_Operador.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lbl_Result);
            this.panel1.Controls.Add(this.txt_Operando1);
            this.panel1.Controls.Add(this.cbo_Operador);
            this.panel1.Controls.Add(this.txt_Operando2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 90);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Result
            // 
            this.lbl_Result.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Result.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(12, 48);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Result.Size = new System.Drawing.Size(554, 35);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Operar
            // 
            this.btn_Operar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Operar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Operar.Location = new System.Drawing.Point(12, 96);
            this.btn_Operar.Name = "btn_Operar";
            this.btn_Operar.Size = new System.Drawing.Size(181, 40);
            this.btn_Operar.TabIndex = 5;
            this.btn_Operar.Text = "Operar";
            this.btn_Operar.UseVisualStyleBackColor = false;
            this.btn_Operar.Click += new System.EventHandler(this.Btn_Operar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Limpiar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(198, 96);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(181, 40);
            this.btn_Limpiar.TabIndex = 6;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(385, 96);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(181, 40);
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_ConvertBin
            // 
            this.btn_ConvertBin.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConvertBin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvertBin.Location = new System.Drawing.Point(12, 142);
            this.btn_ConvertBin.Name = "btn_ConvertBin";
            this.btn_ConvertBin.Size = new System.Drawing.Size(274, 40);
            this.btn_ConvertBin.TabIndex = 8;
            this.btn_ConvertBin.Text = "Convertir a Binario";
            this.btn_ConvertBin.UseVisualStyleBackColor = false;
            this.btn_ConvertBin.Click += new System.EventHandler(this.Btn_ConvertBin_Click);
            // 
            // btn_ConvertDec
            // 
            this.btn_ConvertDec.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConvertDec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConvertDec.Location = new System.Drawing.Point(292, 142);
            this.btn_ConvertDec.Name = "btn_ConvertDec";
            this.btn_ConvertDec.Size = new System.Drawing.Size(274, 40);
            this.btn_ConvertDec.TabIndex = 9;
            this.btn_ConvertDec.Text = "Convertir a Decimal";
            this.btn_ConvertDec.UseVisualStyleBackColor = false;
            this.btn_ConvertDec.Click += new System.EventHandler(this.Btn_ConvertDec_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(579, 189);
            this.Controls.Add(this.btn_ConvertDec);
            this.Controls.Add(this.btn_ConvertBin);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Operar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Ahumada Kevin del Curso  2°A";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Operando1;
        private System.Windows.Forms.TextBox txt_Operando2;
        private System.Windows.Forms.ComboBox cbo_Operador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Operar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_ConvertBin;
        private System.Windows.Forms.Button btn_ConvertDec;
    }
}

