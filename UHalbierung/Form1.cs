using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHalbierung
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnAnzeigen_Click(object sender, EventArgs e)
		{
			// Text aus Textfeld einlesen, konvertieren, in einer
			// Variablen eines passenden Datentyps speichern
			double eingabe = Convert.ToDouble(txtEingabe.Text);

			// Bestehenden Text des Labels löschen
			lblAusgabe.Text = "";

			// Passende Schleife wählen, Schleifenbedingung wählen
			while (eingabe > 0.001)
			{
				// Division durchführen
				eingabe = eingabe / 2;

				// Ergebnis ausgeben, Zeilenumbruch  nicht vergessen
				lblAusgabe.Text += (eingabe / 2) + "\n";
			}
		}
	}
}
