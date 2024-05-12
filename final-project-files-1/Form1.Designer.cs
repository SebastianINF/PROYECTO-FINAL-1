namespace final_project_files_1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eNTEROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarDigitosIgualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarDigitosDiferentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarOrdenadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADENASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grabarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorApellidoPaternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separarArchivoPorApellidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDimensionar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNTEROSToolStripMenuItem,
            this.cADENASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eNTEROSToolStripMenuItem
            // 
            this.eNTEROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarToolStripMenuItem,
            this.leerToolStripMenuItem,
            this.cargarRandomToolStripMenuItem,
            this.seleccionarDigitosIgualesToolStripMenuItem,
            this.seleccionarDigitosDiferentesToolStripMenuItem,
            this.toolStripMenuItem2});
            this.eNTEROSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.eNTEROSToolStripMenuItem.Name = "eNTEROSToolStripMenuItem";
            this.eNTEROSToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.eNTEROSToolStripMenuItem.Text = "ENTEROS";
            // 
            // grabarToolStripMenuItem
            // 
            this.grabarToolStripMenuItem.Name = "grabarToolStripMenuItem";
            this.grabarToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.grabarToolStripMenuItem.Text = "Grabar";
            this.grabarToolStripMenuItem.Click += new System.EventHandler(this.grabarToolStripMenuItem_Click);
            // 
            // leerToolStripMenuItem
            // 
            this.leerToolStripMenuItem.Name = "leerToolStripMenuItem";
            this.leerToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.leerToolStripMenuItem.Text = "Leer";
            this.leerToolStripMenuItem.Click += new System.EventHandler(this.leerToolStripMenuItem_Click);
            // 
            // cargarRandomToolStripMenuItem
            // 
            this.cargarRandomToolStripMenuItem.Name = "cargarRandomToolStripMenuItem";
            this.cargarRandomToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.cargarRandomToolStripMenuItem.Text = "Cargar Random";
            this.cargarRandomToolStripMenuItem.Click += new System.EventHandler(this.cargarRandomToolStripMenuItem_Click);
            // 
            // seleccionarDigitosIgualesToolStripMenuItem
            // 
            this.seleccionarDigitosIgualesToolStripMenuItem.Name = "seleccionarDigitosIgualesToolStripMenuItem";
            this.seleccionarDigitosIgualesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.seleccionarDigitosIgualesToolStripMenuItem.Text = "1. Seleccionar Digitos Iguales";
            this.seleccionarDigitosIgualesToolStripMenuItem.Click += new System.EventHandler(this.seleccionarDigitosIgualesToolStripMenuItem_Click);
            // 
            // seleccionarDigitosDiferentesToolStripMenuItem
            // 
            this.seleccionarDigitosDiferentesToolStripMenuItem.Name = "seleccionarDigitosDiferentesToolStripMenuItem";
            this.seleccionarDigitosDiferentesToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.seleccionarDigitosDiferentesToolStripMenuItem.Text = "2. Seleccionar Digitos Diferentes";
            this.seleccionarDigitosDiferentesToolStripMenuItem.Click += new System.EventHandler(this.seleccionarDigitosDiferentesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarOrdenadoToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(299, 26);
            this.toolStripMenuItem2.Text = "3. Unir archivos Ordenados";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cargarOrdenadoToolStripMenuItem
            // 
            this.cargarOrdenadoToolStripMenuItem.Name = "cargarOrdenadoToolStripMenuItem";
            this.cargarOrdenadoToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cargarOrdenadoToolStripMenuItem.Text = "Cargar Ordenado";
            this.cargarOrdenadoToolStripMenuItem.Click += new System.EventHandler(this.cargarOrdenadoToolStripMenuItem_Click);
            // 
            // cADENASToolStripMenuItem
            // 
            this.cADENASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grabarToolStripMenuItem1,
            this.leerToolStripMenuItem1,
            this.ordenarPorApellidoPaternoToolStripMenuItem,
            this.separarArchivoPorApellidosToolStripMenuItem});
            this.cADENASToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cADENASToolStripMenuItem.Name = "cADENASToolStripMenuItem";
            this.cADENASToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cADENASToolStripMenuItem.Text = "CADENAS";
            // 
            // grabarToolStripMenuItem1
            // 
            this.grabarToolStripMenuItem1.Name = "grabarToolStripMenuItem1";
            this.grabarToolStripMenuItem1.Size = new System.Drawing.Size(296, 26);
            this.grabarToolStripMenuItem1.Text = "Grabar";
            this.grabarToolStripMenuItem1.Click += new System.EventHandler(this.grabarToolStripMenuItem1_Click);
            // 
            // leerToolStripMenuItem1
            // 
            this.leerToolStripMenuItem1.Name = "leerToolStripMenuItem1";
            this.leerToolStripMenuItem1.Size = new System.Drawing.Size(296, 26);
            this.leerToolStripMenuItem1.Text = "Leer";
            this.leerToolStripMenuItem1.Click += new System.EventHandler(this.leerToolStripMenuItem1_Click);
            // 
            // ordenarPorApellidoPaternoToolStripMenuItem
            // 
            this.ordenarPorApellidoPaternoToolStripMenuItem.Name = "ordenarPorApellidoPaternoToolStripMenuItem";
            this.ordenarPorApellidoPaternoToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.ordenarPorApellidoPaternoToolStripMenuItem.Text = "4. Ordenar Por Apellido Paterno";
            this.ordenarPorApellidoPaternoToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorApellidoPaternoToolStripMenuItem_Click);
            // 
            // separarArchivoPorApellidosToolStripMenuItem
            // 
            this.separarArchivoPorApellidosToolStripMenuItem.Name = "separarArchivoPorApellidosToolStripMenuItem";
            this.separarArchivoPorApellidosToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.separarArchivoPorApellidosToolStripMenuItem.Text = "5. Separar Archivo Por Apellidos";
            this.separarArchivoPorApellidosToolStripMenuItem.Click += new System.EventHandler(this.separarArchivoPorApellidosToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NRO,
            this.REGISTRO});
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(246, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(416, 359);
            this.dataGridView1.TabIndex = 1;
            // 
            // NRO
            // 
            this.NRO.Frozen = true;
            this.NRO.HeaderText = "NRO";
            this.NRO.Name = "NRO";
            this.NRO.ReadOnly = true;
            this.NRO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NRO.Width = 40;
            // 
            // REGISTRO
            // 
            this.REGISTRO.HeaderText = "REGISTRO";
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.REGISTRO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.REGISTRO.Width = 200;
            // 
            // btnDimensionar
            // 
            this.btnDimensionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDimensionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDimensionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDimensionar.Location = new System.Drawing.Point(763, 349);
            this.btnDimensionar.Name = "btnDimensionar";
            this.btnDimensionar.Size = new System.Drawing.Size(156, 74);
            this.btnDimensionar.TabIndex = 2;
            this.btnDimensionar.Text = "Dimensión";
            this.btnDimensionar.UseVisualStyleBackColor = false;
            this.btnDimensionar.Click += new System.EventHandler(this.btnDimensionar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimpiar.Location = new System.Drawing.Point(763, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 74);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sebastian Cespedes Rodas - 223047333";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1032, 659);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDimensionar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem eNTEROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADENASToolStripMenuItem;
        private System.Windows.Forms.Button btnDimensionar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem cargarRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarDigitosIgualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarDigitosDiferentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cargarOrdenadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grabarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem leerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorApellidoPaternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separarArchivoPorApellidosToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

