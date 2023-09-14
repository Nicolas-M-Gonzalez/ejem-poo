namespace registro_personas
{
    partial class registro1
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
            this.btn1aceptar = new System.Windows.Forms.Button();
            this.btn2cancelar = new System.Windows.Forms.Button();
            this.lblapeliido = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.listresult = new System.Windows.Forms.ListView();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1aceptar
            // 
            this.btn1aceptar.Location = new System.Drawing.Point(48, 352);
            this.btn1aceptar.Name = "btn1aceptar";
            this.btn1aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn1aceptar.TabIndex = 0;
            this.btn1aceptar.Text = "aceptar";
            this.btn1aceptar.UseVisualStyleBackColor = true;
            this.btn1aceptar.Click += new System.EventHandler(this.btn1aceptar_Click);
            // 
            // btn2cancelar
            // 
            this.btn2cancelar.Location = new System.Drawing.Point(218, 352);
            this.btn2cancelar.Name = "btn2cancelar";
            this.btn2cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn2cancelar.TabIndex = 1;
            this.btn2cancelar.Text = "cancelar";
            this.btn2cancelar.UseVisualStyleBackColor = true;
            this.btn2cancelar.Click += new System.EventHandler(this.btn2cancelar_Click);
            // 
            // lblapeliido
            // 
            this.lblapeliido.AutoSize = true;
            this.lblapeliido.Location = new System.Drawing.Point(12, 36);
            this.lblapeliido.Name = "lblapeliido";
            this.lblapeliido.Size = new System.Drawing.Size(62, 13);
            this.lblapeliido.TabIndex = 2;
            this.lblapeliido.Text = "APELLIDO:";
            // 
            // txtapellido
            // 
            this.txtapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido.Location = new System.Drawing.Point(80, 33);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(256, 20);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.TextChanged += new System.EventHandler(this.txtapellido_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 79);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(80, 79);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(256, 20);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtedad
            // 
            this.txtedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtedad.Location = new System.Drawing.Point(80, 127);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 6;
            this.txtedad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            // 
            // lbledad
            // 
            this.lbledad.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(29, 134);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(40, 13);
            this.lbledad.TabIndex = 7;
            this.lbledad.Text = "EDAD:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Location = new System.Drawing.Point(80, 171);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(256, 20);
            this.txtdireccion.TabIndex = 8;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(5, 178);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(69, 13);
            this.lbldireccion.TabIndex = 9;
            this.lbldireccion.Text = "DIRECCION:";
            // 
            // listresult
            // 
            this.listresult.AllowColumnReorder = true;
            this.listresult.HideSelection = false;
            this.listresult.Location = new System.Drawing.Point(12, 238);
            this.listresult.Name = "listresult";
            this.listresult.Scrollable = false;
            this.listresult.Size = new System.Drawing.Size(324, 97);
            this.listresult.TabIndex = 10;
            this.listresult.UseCompatibleStateImageBehavior = false;
            this.listresult.SelectedIndexChanged += new System.EventHandler(this.listresult_SelectedIndexChanged);
            this.listresult.CausesValidationChanged += new System.EventHandler(this.listresult_CausesValidationChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(9, 224);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(76, 13);
            this.lblresultado.TabIndex = 11;
            this.lblresultado.Text = "RESULTADO:";
            // 
            // registro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.listresult);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblapeliido);
            this.Controls.Add(this.btn2cancelar);
            this.Controls.Add(this.btn1aceptar);
            this.Name = "registro1";
            this.Text = "registro personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1aceptar;
        private System.Windows.Forms.Button btn2cancelar;
        private System.Windows.Forms.Label lblapeliido;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.ListView listresult;
        private System.Windows.Forms.Label lblresultado;
    }
}

