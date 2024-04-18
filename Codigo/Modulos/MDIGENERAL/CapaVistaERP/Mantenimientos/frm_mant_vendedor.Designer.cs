
namespace CapaVistaERP.Mantenimientos
{
    partial class frm_mant_vendedor
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estatus = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.TextBox();
            this.dirrecion = new System.Windows.Forms.TextBox();
            this.nombre_cl = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 40;
            this.label7.Tag = "estatus_cliente";
            this.label7.Text = "estatus vededor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 39;
            this.label6.Tag = "telefono_cliente";
            this.label6.Text = "telefono vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 38;
            this.label5.Tag = "direcciion_cliente";
            this.label5.Text = "Direccion vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 37;
            this.label4.Tag = "nit_cliente";
            this.label4.Text = "nit vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "codigo_Vendedor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 308);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 168);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Tag = "vendedor";
            // 
            // estatus
            // 
            this.estatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estatus.Location = new System.Drawing.Point(521, 237);
            this.estatus.Margin = new System.Windows.Forms.Padding(2);
            this.estatus.Name = "estatus";
            this.estatus.Size = new System.Drawing.Size(151, 26);
            this.estatus.TabIndex = 33;
            this.estatus.Tag = "estatus_vededor";
            // 
            // telefono
            // 
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(521, 151);
            this.telefono.Margin = new System.Windows.Forms.Padding(2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(151, 26);
            this.telefono.TabIndex = 32;
            this.telefono.Tag = "telefono_vededor";
            // 
            // nit
            // 
            this.nit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nit.Location = new System.Drawing.Point(260, 237);
            this.nit.Margin = new System.Windows.Forms.Padding(2);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(151, 26);
            this.nit.TabIndex = 31;
            this.nit.Tag = "nit_vendedor";
            // 
            // dirrecion
            // 
            this.dirrecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirrecion.Location = new System.Drawing.Point(260, 151);
            this.dirrecion.Margin = new System.Windows.Forms.Padding(2);
            this.dirrecion.Name = "dirrecion";
            this.dirrecion.Size = new System.Drawing.Size(151, 26);
            this.dirrecion.TabIndex = 30;
            this.dirrecion.Tag = "direccion_vededor";
            // 
            // nombre_cl
            // 
            this.nombre_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_cl.Location = new System.Drawing.Point(69, 231);
            this.nombre_cl.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_cl.Name = "nombre_cl";
            this.nombre_cl.Size = new System.Drawing.Size(151, 26);
            this.nombre_cl.TabIndex = 29;
            this.nombre_cl.Tag = "nombre_vededor";
            // 
            // id_cliente
            // 
            this.id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(69, 151);
            this.id_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(151, 26);
            this.id_cliente.TabIndex = 28;
            this.id_cliente.Tag = "codigo_vendedor";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(11, 24);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 41;
            // 
            // frm_mant_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.estatus);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.dirrecion);
            this.Controls.Add(this.nombre_cl);
            this.Controls.Add(this.id_cliente);
            this.Name = "frm_mant_vendedor";
            this.Text = "frm_mant_vendedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox estatus;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.TextBox dirrecion;
        private System.Windows.Forms.TextBox nombre_cl;
        private System.Windows.Forms.TextBox id_cliente;
        private CapaVista.Navegador navegador1;
    }
}