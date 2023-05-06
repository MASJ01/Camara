namespace Camara_Web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_secuencia = new System.Windows.Forms.NumericUpDown();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_INICIAR = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PBX_ESPACIO_CAMARA = new System.Windows.Forms.PictureBox();
            this.barra_estado = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.cuadro_guardar = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secuencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_ESPACIO_CAMARA)).BeginInit();
            this.barra_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.BTN_SAVE);
            this.groupBox1.Controls.Add(this.nud_secuencia);
            this.groupBox1.Controls.Add(this.BTN_GUARDAR);
            this.groupBox1.Controls.Add(this.BTN_INICIAR);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PBX_ESPACIO_CAMARA);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAMARA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nud_secuencia
            // 
            this.nud_secuencia.Location = new System.Drawing.Point(341, 400);
            this.nud_secuencia.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_secuencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_secuencia.Name = "nud_secuencia";
            this.nud_secuencia.Size = new System.Drawing.Size(63, 20);
            this.nud_secuencia.TabIndex = 5;
            this.nud_secuencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.Location = new System.Drawing.Point(6, 447);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(272, 38);
            this.BTN_GUARDAR.TabIndex = 4;
            this.BTN_GUARDAR.Text = "CAPTURAR IMAGEN";
            this.BTN_GUARDAR.UseVisualStyleBackColor = true;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_INICIAR
            // 
            this.BTN_INICIAR.Location = new System.Drawing.Point(439, 397);
            this.BTN_INICIAR.Name = "BTN_INICIAR";
            this.BTN_INICIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_INICIAR.TabIndex = 3;
            this.BTN_INICIAR.Text = "INICIAR";
            this.BTN_INICIAR.UseVisualStyleBackColor = true;
            this.BTN_INICIAR.Click += new System.EventHandler(this.BTN_INICIAR_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 356);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECCIONA CAMARA A ACTIVAR:";
            // 
            // PBX_ESPACIO_CAMARA
            // 
            this.PBX_ESPACIO_CAMARA.BackgroundImage = global::Camara_Web.Properties.Resources.camara;
            this.PBX_ESPACIO_CAMARA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_ESPACIO_CAMARA.Location = new System.Drawing.Point(19, 29);
            this.PBX_ESPACIO_CAMARA.Name = "PBX_ESPACIO_CAMARA";
            this.PBX_ESPACIO_CAMARA.Size = new System.Drawing.Size(495, 302);
            this.PBX_ESPACIO_CAMARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_ESPACIO_CAMARA.TabIndex = 0;
            this.PBX_ESPACIO_CAMARA.TabStop = false;
            // 
            // barra_estado
            // 
            this.barra_estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.barra_estado.Location = new System.Drawing.Point(0, 529);
            this.barra_estado.Name = "barra_estado";
            this.barra_estado.Size = new System.Drawing.Size(650, 22);
            this.barra_estado.TabIndex = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "LISTO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.Location = new System.Drawing.Point(352, 447);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(162, 38);
            this.BTN_SAVE.TabIndex = 6;
            this.BTN_SAVE.Text = "GUARDAR";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 551);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barra_estado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_secuencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_ESPACIO_CAMARA)).EndInit();
            this.barra_estado.ResumeLayout(false);
            this.barra_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_INICIAR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBX_ESPACIO_CAMARA;
        private System.Windows.Forms.StatusStrip barra_estado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nud_secuencia;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.SaveFileDialog cuadro_guardar;
    }
}

