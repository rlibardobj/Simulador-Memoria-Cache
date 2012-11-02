/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 08:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace simuladorCache
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualmenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.automáticamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 207);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Reemplazos: ";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fallos: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Aciertos: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(89, 161);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "0";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(89, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "0";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(89, 207);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "0";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.simularToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(598, 24);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// simularToolStripMenuItem
			// 
			this.simularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.manualmenteToolStripMenuItem,
									this.automáticamenteToolStripMenuItem});
			this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
			this.simularToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.simularToolStripMenuItem.Text = "Simular";
			// 
			// manualmenteToolStripMenuItem
			// 
			this.manualmenteToolStripMenuItem.Name = "manualmenteToolStripMenuItem";
			this.manualmenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.manualmenteToolStripMenuItem.Text = "Manualmente";
			// 
			// automáticamenteToolStripMenuItem
			// 
			this.automáticamenteToolStripMenuItem.Name = "automáticamenteToolStripMenuItem";
			this.automáticamenteToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.automáticamenteToolStripMenuItem.Text = "Automáticamente";
			this.automáticamenteToolStripMenuItem.Click += new System.EventHandler(this.AutomáticamenteToolStripMenuItemClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(120, 44);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(26, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Tamaño:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(26, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 16;
			this.label8.Text = "Asociatividad:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(26, 93);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Referencias:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(120, 67);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 18;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(120, 90);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 19;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 291);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "simuladorCache";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripMenuItem automáticamenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manualmenteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
