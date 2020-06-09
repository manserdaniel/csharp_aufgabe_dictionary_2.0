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
            this.tbEnglish = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.ListBox();
            this.tbEnglisch = new System.Windows.Forms.TextBox();
            this.lbAlphabet = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(294, 112);
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
            this.lbDeEn.Location = new System.Drawing.Point(316, 65);
            this.lbDeEn.Name = "lbDeEn";
            this.lbDeEn.Size = new System.Drawing.Size(80, 20);
            this.lbDeEn.TabIndex = 1;
            this.lbDeEn.Text = "DE <> EN";
            // 
            // tbGerman
            // 
            this.tbGerman.Location = new System.Drawing.Point(12, 59);
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.Size = new System.Drawing.Size(216, 26);
            this.tbGerman.TabIndex = 2;
            // 
            // tbEnglish
            // 
            this.tbEnglish.Location = new System.Drawing.Point(489, 59);
            this.tbEnglish.Name = "tbEnglish";
            this.tbEnglish.Size = new System.Drawing.Size(216, 26);
            this.tbEnglish.TabIndex = 3;
            // 
            // lbTranslation
            // 
            this.lbTranslation.FormattingEnabled = true;
            this.lbTranslation.ItemHeight = 20;
            this.lbTranslation.Location = new System.Drawing.Point(82, 207);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(377, 204);
            this.lbTranslation.TabIndex = 4;
            this.lbTranslation.SelectedIndexChanged += new System.EventHandler(this.lbTranslation_SelectedIndexChanged);
            // 
            // tbEnglisch
            // 
            this.tbEnglisch.Location = new System.Drawing.Point(489, 207);
            this.tbEnglisch.Name = "tbEnglisch";
            this.tbEnglisch.Size = new System.Drawing.Size(216, 26);
            this.tbEnglisch.TabIndex = 5;
            // 
            // lbAlphabet
            // 
            this.lbAlphabet.FormattingEnabled = true;
            this.lbAlphabet.ItemHeight = 20;
            this.lbAlphabet.Location = new System.Drawing.Point(12, 207);
            this.lbAlphabet.Name = "lbAlphabet";
            this.lbAlphabet.Size = new System.Drawing.Size(64, 204);
            this.lbAlphabet.TabIndex = 6;
            this.lbAlphabet.SelectedIndexChanged += new System.EventHandler(this.lbAlphabet_SelectedIndexChanged_1);
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
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbAlphabet);
            this.Controls.Add(this.tbEnglisch);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbEnglish);
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
        private System.Windows.Forms.TextBox tbEnglish;
        private System.Windows.Forms.ListBox lbTranslation;
        private System.Windows.Forms.TextBox tbEnglisch;
        private System.Windows.Forms.ListBox lbAlphabet;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
    }
}

