/*
 * Creado por SharpDevelop.
 * Usuario: rlibardobj
 * Fecha: 30/10/2012
 * Hora: 08:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace simuladorCache
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		controladorPrograma controlador;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string dato=Convert.ToString(int.Parse(textBox1.Text),2);
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
		void EjecutarToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void AutomáticamenteToolStripMenuItemClick(object sender, EventArgs e)
		{
			controlador=new controladorPrograma(textBox1.Text,"1",textBox3.Text,textBox2.Text);
			controlador.emulacionAutomatica();
			label4.Text=controlador.hits.ToString();
			label5.Text=controlador.misses.ToString();
			label6.Text=controlador.reemplazos.ToString();
		}
	}
}
