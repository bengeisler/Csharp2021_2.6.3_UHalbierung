
namespace UHalbierung
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAnzeigen = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.txtEingabe = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAnzeigen
			// 
			this.btnAnzeigen.Location = new System.Drawing.Point(311, 43);
			this.btnAnzeigen.Name = "btnAnzeigen";
			this.btnAnzeigen.Size = new System.Drawing.Size(75, 23);
			this.btnAnzeigen.TabIndex = 0;
			this.btnAnzeigen.Text = "Anzeigen";
			this.btnAnzeigen.UseVisualStyleBackColor = true;
			this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(12, 11);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 1;
			this.lblAusgabe.Text = "label1";
			// 
			// txtEingabe
			// 
			this.txtEingabe.Location = new System.Drawing.Point(311, 8);
			this.txtEingabe.Name = "txtEingabe";
			this.txtEingabe.Size = new System.Drawing.Size(75, 20);
			this.txtEingabe.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 311);
			this.Controls.Add(this.txtEingabe);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnAnzeigen);
			this.Name = "Form1";
			this.Text = "Halbierung";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAnzeigen;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.TextBox txtEingabe;
	}
}

