namespace SistemaCine
{
    partial class Consulta
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
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.n_id_ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.AllowUserToAddRows = false;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n_id_ticket,
            this.p_pelicula});
            this.dgvconsulta.Location = new System.Drawing.Point(0, 1);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(241, 156);
            this.dgvconsulta.TabIndex = 0;
            this.dgvconsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconsulta_CellContentClick);
            // 
            // n_id_ticket
            // 
            this.n_id_ticket.DataPropertyName = "id_pelicula";
            this.n_id_ticket.HeaderText = "#";
            this.n_id_ticket.Name = "n_id_ticket";
            this.n_id_ticket.ReadOnly = true;
            // 
            // p_pelicula
            // 
            this.p_pelicula.DataPropertyName = "Pelicula";
            this.p_pelicula.HeaderText = "Pelicula";
            this.p_pelicula.Name = "p_pelicula";
            this.p_pelicula.ReadOnly = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 165);
            this.Controls.Add(this.dgvconsulta);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_id_ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_pelicula;
    }
}