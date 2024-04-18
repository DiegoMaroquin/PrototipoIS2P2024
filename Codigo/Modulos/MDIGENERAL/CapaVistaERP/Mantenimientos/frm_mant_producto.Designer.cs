
namespace CapaVistaERP.Mantenimientos
{
    partial class frm_mant_producto
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.telefono_cl = new System.Windows.Forms.TextBox();
            this.correo_cl = new System.Windows.Forms.TextBox();
            this.direccion_cl = new System.Windows.Forms.TextBox();
            this.apellido_cl = new System.Windows.Forms.TextBox();
            this.nombre_cl = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaVista.Navegador();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 38;
            this.label7.Tag = "estatus_cliente";
            this.label7.Text = "estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 37;
            this.label4.Tag = "nit_cliente";
            this.label4.Text = "codigo linea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nombre producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "codigo_producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 294);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(767, 168);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Tag = "producto";
            // 
            // telefono_cl
            // 
            this.telefono_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_cl.Location = new System.Drawing.Point(516, 253);
            this.telefono_cl.Margin = new System.Windows.Forms.Padding(2);
            this.telefono_cl.Name = "telefono_cl";
            this.telefono_cl.Size = new System.Drawing.Size(151, 26);
            this.telefono_cl.TabIndex = 33;
            this.telefono_cl.Tag = "estatus_producto";
            // 
            // correo_cl
            // 
            this.correo_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_cl.Location = new System.Drawing.Point(516, 167);
            this.correo_cl.Margin = new System.Windows.Forms.Padding(2);
            this.correo_cl.Name = "correo_cl";
            this.correo_cl.Size = new System.Drawing.Size(151, 26);
            this.correo_cl.TabIndex = 32;
            this.correo_cl.Tag = "codigo_marca";
            // 
            // direccion_cl
            // 
            this.direccion_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_cl.Location = new System.Drawing.Point(255, 247);
            this.direccion_cl.Margin = new System.Windows.Forms.Padding(2);
            this.direccion_cl.Name = "direccion_cl";
            this.direccion_cl.Size = new System.Drawing.Size(151, 26);
            this.direccion_cl.TabIndex = 31;
            this.direccion_cl.Tag = "codigo_linea";
            // 
            // apellido_cl
            // 
            this.apellido_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_cl.Location = new System.Drawing.Point(255, 167);
            this.apellido_cl.Margin = new System.Windows.Forms.Padding(2);
            this.apellido_cl.Name = "apellido_cl";
            this.apellido_cl.Size = new System.Drawing.Size(151, 26);
            this.apellido_cl.TabIndex = 30;
            this.apellido_cl.Tag = "apellido_cl";
            // 
            // nombre_cl
            // 
            this.nombre_cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_cl.Location = new System.Drawing.Point(64, 247);
            this.nombre_cl.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_cl.Name = "nombre_cl";
            this.nombre_cl.Size = new System.Drawing.Size(151, 26);
            this.nombre_cl.TabIndex = 29;
            this.nombre_cl.Tag = "nombre_producto";
            // 
            // id_cliente
            // 
            this.id_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(64, 167);
            this.id_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(151, 26);
            this.id_cliente.TabIndex = 28;
            this.id_cliente.Tag = "codigo_pruducto";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(13, 29);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(751, 78);
            this.navegador1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 41;
            this.label6.Tag = "telefono_cliente";
            this.label6.Text = "codigo marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 40;
            this.label5.Tag = "direcciion_producto";
            this.label5.Text = "esistencias producto";
            // 
            // frm_mant_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.telefono_cl);
            this.Controls.Add(this.correo_cl);
            this.Controls.Add(this.direccion_cl);
            this.Controls.Add(this.apellido_cl);
            this.Controls.Add(this.nombre_cl);
            this.Controls.Add(this.id_cliente);
            this.Name = "frm_mant_producto";
            this.Text = "frm_mant_producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox telefono_cl;
        private System.Windows.Forms.TextBox correo_cl;
        private System.Windows.Forms.TextBox direccion_cl;
        private System.Windows.Forms.TextBox apellido_cl;
        private System.Windows.Forms.TextBox nombre_cl;
        private System.Windows.Forms.TextBox id_cliente;
        private CapaVista.Navegador navegador1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}