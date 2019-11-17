using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Aguila_Curda
{
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
		}

		private void tsmCliente_Click(object sender, EventArgs e)
		{
			frmCliente form = new frmCliente();
			form.Show();
		}

		private void tsmProveedor_Click(object sender, EventArgs e)
		{
			frmProveedor form = new frmProveedor();
			form.Show();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
