namespace Wörterbuch
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
            this.btnAddWord = new System.Windows.Forms.Button();
            this.lbDeEn = new System.Windows.Forms.Label();
            this.tbGerman = new System.Windows.Forms.TextBox();
            this.tbEnglishIn = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.ListBox();
            this.tbEnglishOut = new System.Windows.Forms.TextBox();
            this.lbAlphabet = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDutchOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDutchIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(311, 55);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(128, 35);
            this.btnAddWord.TabIndex = 0;
            this.btnAddWord.Text = "Hinzufügen";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAdd);
            // 
            // lbDeEn
            // 
            this.lbDeEn.AutoSize = true;
            this.lbDeEn.Location = new System.Drawing.Point(234, 59);
            this.lbDeEn.Name = "lbDeEn";
            this.lbDeEn.Size = new System.Drawing.Size(32, 20);
            this.lbDeEn.TabIndex = 1;
            this.lbDeEn.Text = "DE";
            // 
            // tbGerman
            // 
            this.tbGerman.Location = new System.Drawing.Point(12, 59);
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.Size = new System.Drawing.Size(216, 26);
            this.tbGerman.TabIndex = 2;
            // 
            // tbEnglishIn
            // 
            this.tbEnglishIn.Location = new System.Drawing.Point(489, 59);
            this.tbEnglishIn.Name = "tbEnglishIn";
            this.tbEnglishIn.Size = new System.Drawing.Size(216, 26);
            this.tbEnglishIn.TabIndex = 3;
            // 
            // lbTranslation
            // 
            this.lbTranslation.FormattingEnabled = true;
            this.lbTranslation.ItemHeight = 20;
            this.lbTranslation.Location = new System.Drawing.Point(82, 207);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(377, 204);
            this.lbTranslation.TabIndex = 4;
            this.lbTranslation.SelectedIndexChanged += new System.EventHandler(this.lbTranslation_SelectedIndexChanged_1);
            // 
            // tbEnglishOut
            // 
            this.tbEnglishOut.Location = new System.Drawing.Point(489, 207);
            this.tbEnglishOut.Name = "tbEnglishOut";
            this.tbEnglishOut.Size = new System.Drawing.Size(216, 26);
            this.tbEnglishOut.TabIndex = 5;
            // 
            // lbAlphabet
            // 
            this.lbAlphabet.FormattingEnabled = true;
            this.lbAlphabet.ItemHeight = 20;
            this.lbAlphabet.Location = new System.Drawing.Point(12, 207);
            this.lbAlphabet.Name = "lbAlphabet";
            this.lbAlphabet.Size = new System.Drawing.Size(64, 204);
            this.lbAlphabet.TabIndex = 6;
            this.lbAlphabet.SelectedIndexChanged += new System.EventHandler(this.lbAlphabet_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(600, 376);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 35);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(489, 376);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(105, 35);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(82, 175);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(377, 26);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Suchen";
            // 
            // tbDutchOut
            // 
            this.tbDutchOut.Location = new System.Drawing.Point(489, 239);
            this.tbDutchOut.Name = "tbDutchOut";
            this.tbDutchOut.Size = new System.Drawing.Size(216, 26);
            this.tbDutchOut.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "EN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "NL";
            // 
            // tbDutchIn
            // 
            this.tbDutchIn.Location = new System.Drawing.Point(489, 91);
            this.tbDutchIn.Name = "tbDutchIn";
            this.tbDutchIn.Size = new System.Drawing.Size(216, 26);
            this.tbDutchIn.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "NL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "EN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ausgabe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Eingabe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDutchIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDutchOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbAlphabet);
            this.Controls.Add(this.tbEnglishOut);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbEnglishIn);
            this.Controls.Add(this.tbGerman);
            this.Controls.Add(this.lbDeEn);
            this.Controls.Add(this.btnAddWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label lbDeEn;
        private System.Windows.Forms.TextBox tbGerman;
        private System.Windows.Forms.TextBox tbEnglishIn;
        private System.Windows.Forms.ListBox lbTranslation;
        private System.Windows.Forms.TextBox tbEnglishOut;
        private System.Windows.Forms.ListBox lbAlphabet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDutchOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDutchIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

