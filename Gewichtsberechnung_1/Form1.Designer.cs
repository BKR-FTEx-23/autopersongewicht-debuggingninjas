namespace Gewichtsberechnung_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstPersonen = new ListBox();
            txtGewichtPerson = new TextBox();
            btnPersonHinzufügen = new Button();
            btnAusgewähltePersonentfernen = new Button();
            txtAutoGewicht = new TextBox();
            SuspendLayout();
            // 
            // lstPersonen
            // 
            lstPersonen.FormattingEnabled = true;
            lstPersonen.Location = new Point(441, 7);
            lstPersonen.Name = "lstPersonen";
            lstPersonen.Size = new Size(347, 244);
            lstPersonen.TabIndex = 0;
            // 
            // txtGewichtPerson
            // 
            txtGewichtPerson.Location = new Point(6, 8);
            txtGewichtPerson.Name = "txtGewichtPerson";
            txtGewichtPerson.Size = new Size(429, 27);
            txtGewichtPerson.TabIndex = 1;
            // 
            // btnPersonHinzufügen
            // 
            btnPersonHinzufügen.Location = new Point(6, 41);
            btnPersonHinzufügen.Name = "btnPersonHinzufügen";
            btnPersonHinzufügen.Size = new Size(429, 108);
            btnPersonHinzufügen.TabIndex = 2;
            btnPersonHinzufügen.Text = "Eingegebenes Gewicht hinzufügen";
            btnPersonHinzufügen.UseVisualStyleBackColor = true;
            btnPersonHinzufügen.Click += btnPersonHinzufügen_Click;
            // 
            // btnAusgewähltePersonentfernen
            // 
            btnAusgewähltePersonentfernen.Location = new Point(6, 155);
            btnAusgewähltePersonentfernen.Name = "btnAusgewähltePersonentfernen";
            btnAusgewähltePersonentfernen.Size = new Size(429, 96);
            btnAusgewähltePersonentfernen.TabIndex = 3;
            btnAusgewähltePersonentfernen.Text = "Ausgewählte Person entfernen";
            btnAusgewähltePersonentfernen.UseVisualStyleBackColor = true;
            btnAusgewähltePersonentfernen.Click += btnAusgewähltePersonentfernen_Click;
            // 
            // txtAutoGewicht
            // 
            txtAutoGewicht.Location = new Point(6, 261);
            txtAutoGewicht.Name = "txtAutoGewicht";
            txtAutoGewicht.Size = new Size(765, 27);
            txtAutoGewicht.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 316);
            Controls.Add(txtAutoGewicht);
            Controls.Add(btnAusgewähltePersonentfernen);
            Controls.Add(btnPersonHinzufügen);
            Controls.Add(txtGewichtPerson);
            Controls.Add(lstPersonen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPersonen;
        private TextBox txtGewichtPerson;
        private Button btnPersonHinzufügen;
        private Button btnAusgewähltePersonentfernen;
        private TextBox txtAutoGewicht;
    }
}
