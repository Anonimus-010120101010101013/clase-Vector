namespace Vector
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
            this.lbValor = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avansadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantparesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarDeMenorAMayorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertirCadaElementoVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementosPrimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementoCapicuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(29, 42);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(31, 13);
            this.lbValor.TabIndex = 0;
            this.lbValor.Text = "Valor";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(29, 83);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(61, 13);
            this.lbResultado.TabIndex = 1;
            this.lbResultado.Text = "Resulatado";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(222, 42);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BtnAdicionar.TabIndex = 2;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(52, 164);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(98, 42);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.avansadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem1});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mostrarToolStripMenuItem.Text = "Basico";
            // 
            // mostrarToolStripMenuItem1
            // 
            this.mostrarToolStripMenuItem1.Name = "mostrarToolStripMenuItem1";
            this.mostrarToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.mostrarToolStripMenuItem1.Text = "Mostrar";
            // 
            // avansadoToolStripMenuItem
            // 
            this.avansadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertirToolStripMenuItem,
            this.cantparesToolStripMenuItem,
            this.ordenarDeMenorAMayorToolStripMenuItem,
            this.eliminarPToolStripMenuItem,
            this.invertirCadaElementoVectorToolStripMenuItem,
            this.elementosPrimosToolStripMenuItem,
            this.elementoCapicuaToolStripMenuItem});
            this.avansadoToolStripMenuItem.Name = "avansadoToolStripMenuItem";
            this.avansadoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.avansadoToolStripMenuItem.Text = "Avansado";
            // 
            // invertirToolStripMenuItem
            // 
            this.invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            this.invertirToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.invertirToolStripMenuItem.Text = "Invertir";
            this.invertirToolStripMenuItem.Click += new System.EventHandler(this.invertirToolStripMenuItem_Click);
            // 
            // cantparesToolStripMenuItem
            // 
            this.cantparesToolStripMenuItem.Name = "cantparesToolStripMenuItem";
            this.cantparesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cantparesToolStripMenuItem.Text = "Cant.pares";
            this.cantparesToolStripMenuItem.Click += new System.EventHandler(this.cantparesToolStripMenuItem_Click);
            // 
            // ordenarDeMenorAMayorToolStripMenuItem
            // 
            this.ordenarDeMenorAMayorToolStripMenuItem.Name = "ordenarDeMenorAMayorToolStripMenuItem";
            this.ordenarDeMenorAMayorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.ordenarDeMenorAMayorToolStripMenuItem.Text = "Ordenar de menor a mayor";
            this.ordenarDeMenorAMayorToolStripMenuItem.Click += new System.EventHandler(this.ordenarDeMenorAMayorToolStripMenuItem_Click);
            // 
            // eliminarPToolStripMenuItem
            // 
            this.eliminarPToolStripMenuItem.Name = "eliminarPToolStripMenuItem";
            this.eliminarPToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eliminarPToolStripMenuItem.Text = "Eliminar P";
            this.eliminarPToolStripMenuItem.Click += new System.EventHandler(this.eliminarPToolStripMenuItem_Click);
            // 
            // invertirCadaElementoVectorToolStripMenuItem
            // 
            this.invertirCadaElementoVectorToolStripMenuItem.Name = "invertirCadaElementoVectorToolStripMenuItem";
            this.invertirCadaElementoVectorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.invertirCadaElementoVectorToolStripMenuItem.Text = "invertirCadaElementoVector";
            this.invertirCadaElementoVectorToolStripMenuItem.Click += new System.EventHandler(this.invertirCadaElementoVectorToolStripMenuItem_Click);
            // 
            // elementosPrimosToolStripMenuItem
            // 
            this.elementosPrimosToolStripMenuItem.Name = "elementosPrimosToolStripMenuItem";
            this.elementosPrimosToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.elementosPrimosToolStripMenuItem.Text = "Elementos Primos";
            this.elementosPrimosToolStripMenuItem.Click += new System.EventHandler(this.elementosPrimosToolStripMenuItem_Click);
            // 
            // elementoCapicuaToolStripMenuItem
            // 
            this.elementoCapicuaToolStripMenuItem.Name = "elementoCapicuaToolStripMenuItem";
            this.elementoCapicuaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.elementoCapicuaToolStripMenuItem.Text = "Elemento Capicua";
            this.elementoCapicuaToolStripMenuItem.Click += new System.EventHandler(this.elementoCapicuaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 301);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem avansadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cantparesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarDeMenorAMayorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertirCadaElementoVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementosPrimosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementoCapicuaToolStripMenuItem;
    }
}

