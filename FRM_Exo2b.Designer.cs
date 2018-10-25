namespace Exo2b
{
    partial class FRM_Exo2b
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Phrase1 = new System.Windows.Forms.Label();
            this.Lbl_Phrase2 = new System.Windows.Forms.Label();
            this.Lbl_Phrase3 = new System.Windows.Forms.Label();
            this.Lbl_Lettre_Recherchee = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Occurences = new System.Windows.Forms.Label();
            this.Txt_Phrase1 = new System.Windows.Forms.TextBox();
            this.Txt_Phrase2 = new System.Windows.Forms.TextBox();
            this.Txt_Phrase3 = new System.Windows.Forms.TextBox();
            this.Txt_Lettre_Recherchee = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Occurences = new System.Windows.Forms.TextBox();
            this.Gbx_Recherche_Phrases = new System.Windows.Forms.GroupBox();
            this.Chk_Phrase1 = new System.Windows.Forms.CheckBox();
            this.Chk_Phrase2 = new System.Windows.Forms.CheckBox();
            this.Chk_Phrase3 = new System.Windows.Forms.CheckBox();
            this.Gbx_Phrases = new System.Windows.Forms.GroupBox();
            this.Btn_Lancer_Recherche = new System.Windows.Forms.Button();
            this.Gbx_Recherche_Phrases.SuspendLayout();
            this.Gbx_Phrases.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Phrase1
            // 
            this.Lbl_Phrase1.AutoSize = true;
            this.Lbl_Phrase1.Location = new System.Drawing.Point(31, 23);
            this.Lbl_Phrase1.Name = "Lbl_Phrase1";
            this.Lbl_Phrase1.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Phrase1.TabIndex = 0;
            this.Lbl_Phrase1.Text = "Phrase 1";
            // 
            // Lbl_Phrase2
            // 
            this.Lbl_Phrase2.AutoSize = true;
            this.Lbl_Phrase2.Location = new System.Drawing.Point(31, 81);
            this.Lbl_Phrase2.Name = "Lbl_Phrase2";
            this.Lbl_Phrase2.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Phrase2.TabIndex = 1;
            this.Lbl_Phrase2.Text = "Phrase 2";
            // 
            // Lbl_Phrase3
            // 
            this.Lbl_Phrase3.AutoSize = true;
            this.Lbl_Phrase3.Location = new System.Drawing.Point(31, 140);
            this.Lbl_Phrase3.Name = "Lbl_Phrase3";
            this.Lbl_Phrase3.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Phrase3.TabIndex = 2;
            this.Lbl_Phrase3.Text = "Phrase 3";
            // 
            // Lbl_Lettre_Recherchee
            // 
            this.Lbl_Lettre_Recherchee.AutoSize = true;
            this.Lbl_Lettre_Recherchee.Location = new System.Drawing.Point(215, 220);
            this.Lbl_Lettre_Recherchee.Name = "Lbl_Lettre_Recherchee";
            this.Lbl_Lettre_Recherchee.Size = new System.Drawing.Size(97, 13);
            this.Lbl_Lettre_Recherchee.TabIndex = 3;
            this.Lbl_Lettre_Recherchee.Text = "&Lettre à rechercher";
            // 
            // Lbl_Nombre_Occurences
            // 
            this.Lbl_Nombre_Occurences.AutoSize = true;
            this.Lbl_Nombre_Occurences.Location = new System.Drawing.Point(215, 266);
            this.Lbl_Nombre_Occurences.Name = "Lbl_Nombre_Occurences";
            this.Lbl_Nombre_Occurences.Size = new System.Drawing.Size(111, 13);
            this.Lbl_Nombre_Occurences.TabIndex = 4;
            this.Lbl_Nombre_Occurences.Text = "Nombre d\'occurences";
            // 
            // Txt_Phrase1
            // 
            this.Txt_Phrase1.Location = new System.Drawing.Point(135, 20);
            this.Txt_Phrase1.Name = "Txt_Phrase1";
            this.Txt_Phrase1.Size = new System.Drawing.Size(577, 20);
            this.Txt_Phrase1.TabIndex = 5;
            // 
            // Txt_Phrase2
            // 
            this.Txt_Phrase2.Location = new System.Drawing.Point(135, 78);
            this.Txt_Phrase2.Name = "Txt_Phrase2";
            this.Txt_Phrase2.Size = new System.Drawing.Size(577, 20);
            this.Txt_Phrase2.TabIndex = 6;
            // 
            // Txt_Phrase3
            // 
            this.Txt_Phrase3.Location = new System.Drawing.Point(135, 137);
            this.Txt_Phrase3.Name = "Txt_Phrase3";
            this.Txt_Phrase3.Size = new System.Drawing.Size(577, 20);
            this.Txt_Phrase3.TabIndex = 7;
            // 
            // Txt_Lettre_Recherchee
            // 
            this.Txt_Lettre_Recherchee.Location = new System.Drawing.Point(346, 217);
            this.Txt_Lettre_Recherchee.Name = "Txt_Lettre_Recherchee";
            this.Txt_Lettre_Recherchee.Size = new System.Drawing.Size(245, 20);
            this.Txt_Lettre_Recherchee.TabIndex = 8;
            // 
            // Txt_Nombre_Occurences
            // 
            this.Txt_Nombre_Occurences.Location = new System.Drawing.Point(346, 263);
            this.Txt_Nombre_Occurences.Name = "Txt_Nombre_Occurences";
            this.Txt_Nombre_Occurences.ReadOnly = true;
            this.Txt_Nombre_Occurences.Size = new System.Drawing.Size(245, 20);
            this.Txt_Nombre_Occurences.TabIndex = 9;
            // 
            // Gbx_Recherche_Phrases
            // 
            this.Gbx_Recherche_Phrases.Controls.Add(this.Chk_Phrase3);
            this.Gbx_Recherche_Phrases.Controls.Add(this.Chk_Phrase2);
            this.Gbx_Recherche_Phrases.Controls.Add(this.Chk_Phrase1);
            this.Gbx_Recherche_Phrases.Location = new System.Drawing.Point(12, 200);
            this.Gbx_Recherche_Phrases.Name = "Gbx_Recherche_Phrases";
            this.Gbx_Recherche_Phrases.Size = new System.Drawing.Size(126, 95);
            this.Gbx_Recherche_Phrases.TabIndex = 10;
            this.Gbx_Recherche_Phrases.TabStop = false;
            this.Gbx_Recherche_Phrases.Text = "Rechercher dans :";
            // 
            // Chk_Phrase1
            // 
            this.Chk_Phrase1.AutoSize = true;
            this.Chk_Phrase1.Location = new System.Drawing.Point(15, 19);
            this.Chk_Phrase1.Name = "Chk_Phrase1";
            this.Chk_Phrase1.Size = new System.Drawing.Size(68, 17);
            this.Chk_Phrase1.TabIndex = 0;
            this.Chk_Phrase1.Text = "Phrase &1";
            this.Chk_Phrase1.UseVisualStyleBackColor = true;
            // 
            // Chk_Phrase2
            // 
            this.Chk_Phrase2.AutoSize = true;
            this.Chk_Phrase2.Location = new System.Drawing.Point(15, 42);
            this.Chk_Phrase2.Name = "Chk_Phrase2";
            this.Chk_Phrase2.Size = new System.Drawing.Size(68, 17);
            this.Chk_Phrase2.TabIndex = 1;
            this.Chk_Phrase2.Text = "Phrase &2";
            this.Chk_Phrase2.UseVisualStyleBackColor = true;
            // 
            // Chk_Phrase3
            // 
            this.Chk_Phrase3.AutoSize = true;
            this.Chk_Phrase3.Location = new System.Drawing.Point(15, 65);
            this.Chk_Phrase3.Name = "Chk_Phrase3";
            this.Chk_Phrase3.Size = new System.Drawing.Size(68, 17);
            this.Chk_Phrase3.TabIndex = 2;
            this.Chk_Phrase3.Text = "Phrase &3";
            this.Chk_Phrase3.UseVisualStyleBackColor = true;
            // 
            // Gbx_Phrases
            // 
            this.Gbx_Phrases.Controls.Add(this.Txt_Phrase3);
            this.Gbx_Phrases.Controls.Add(this.Txt_Phrase2);
            this.Gbx_Phrases.Controls.Add(this.Txt_Phrase1);
            this.Gbx_Phrases.Controls.Add(this.Lbl_Phrase3);
            this.Gbx_Phrases.Controls.Add(this.Lbl_Phrase2);
            this.Gbx_Phrases.Controls.Add(this.Lbl_Phrase1);
            this.Gbx_Phrases.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Phrases.Name = "Gbx_Phrases";
            this.Gbx_Phrases.Size = new System.Drawing.Size(733, 182);
            this.Gbx_Phrases.TabIndex = 11;
            this.Gbx_Phrases.TabStop = false;
            // 
            // Btn_Lancer_Recherche
            // 
            this.Btn_Lancer_Recherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Lancer_Recherche.Location = new System.Drawing.Point(597, 207);
            this.Btn_Lancer_Recherche.Name = "Btn_Lancer_Recherche";
            this.Btn_Lancer_Recherche.Size = new System.Drawing.Size(148, 38);
            this.Btn_Lancer_Recherche.TabIndex = 12;
            this.Btn_Lancer_Recherche.Text = "Lancer la &recherche";
            this.Btn_Lancer_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Lancer_Recherche.Click += new System.EventHandler(this.Btn_Lancer_Recherche_Click);
            // 
            // FRM_Exo2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 313);
            this.Controls.Add(this.Btn_Lancer_Recherche);
            this.Controls.Add(this.Gbx_Phrases);
            this.Controls.Add(this.Gbx_Recherche_Phrases);
            this.Controls.Add(this.Txt_Nombre_Occurences);
            this.Controls.Add(this.Txt_Lettre_Recherchee);
            this.Controls.Add(this.Lbl_Nombre_Occurences);
            this.Controls.Add(this.Lbl_Lettre_Recherchee);
            this.Name = "FRM_Exo2b";
            this.Text = "Exercice 2b : compter un caractère donné";
            this.Gbx_Recherche_Phrases.ResumeLayout(false);
            this.Gbx_Recherche_Phrases.PerformLayout();
            this.Gbx_Phrases.ResumeLayout(false);
            this.Gbx_Phrases.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Phrase1;
        private System.Windows.Forms.Label Lbl_Phrase2;
        private System.Windows.Forms.Label Lbl_Phrase3;
        private System.Windows.Forms.Label Lbl_Lettre_Recherchee;
        private System.Windows.Forms.Label Lbl_Nombre_Occurences;
        private System.Windows.Forms.TextBox Txt_Phrase1;
        private System.Windows.Forms.TextBox Txt_Phrase2;
        private System.Windows.Forms.TextBox Txt_Phrase3;
        private System.Windows.Forms.TextBox Txt_Lettre_Recherchee;
        private System.Windows.Forms.TextBox Txt_Nombre_Occurences;
        private System.Windows.Forms.GroupBox Gbx_Recherche_Phrases;
        private System.Windows.Forms.CheckBox Chk_Phrase3;
        private System.Windows.Forms.CheckBox Chk_Phrase2;
        private System.Windows.Forms.CheckBox Chk_Phrase1;
        private System.Windows.Forms.GroupBox Gbx_Phrases;
        private System.Windows.Forms.Button Btn_Lancer_Recherche;
    }
}

