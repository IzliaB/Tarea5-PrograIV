namespace SistemaCine
{
    partial class Ticket
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtidpelicula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid_ticket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Pelicula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Función";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de la Pelicula";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(152, 158);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(179, 20);
            this.txtprecio.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(337, 123);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(79, 51);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(337, 69);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(79, 48);
            this.btnconsultar.TabIndex = 9;
            this.btnconsultar.Text = "Buscar Pelicula";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(151, 132);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(179, 20);
            this.dtpfecha.TabIndex = 11;
            // 
            // txtidpelicula
            // 
            this.txtidpelicula.Location = new System.Drawing.Point(152, 96);
            this.txtidpelicula.Name = "txtidpelicula";
            this.txtidpelicula.Size = new System.Drawing.Size(179, 20);
            this.txtidpelicula.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Tickets";
            // 
            // txtid_ticket
            // 
            this.txtid_ticket.Location = new System.Drawing.Point(151, 69);
            this.txtid_ticket.Name = "txtid_ticket";
            this.txtid_ticket.Size = new System.Drawing.Size(179, 20);
            this.txtid_ticket.TabIndex = 14;
            this.txtid_ticket.TextChanged += new System.EventHandler(this.txtid_ticket_TextChanged);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 206);
            this.Controls.Add(this.txtid_ticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidpelicula);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ticket";
            this.Text = "Registrar Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnconsultar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.TextBox txtidpelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid_ticket;
    }
}

