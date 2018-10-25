using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2b
{
    public partial class FRM_Exo2b : Form
    {
        private Int32 rechercheCaractere(String zone, char caractereRecherche)
        {
            Int32 longZone;
            Int32 i;
            char caractereElementaire;
            Int32 nbrOccurences;

            nbrOccurences = 0;
            longZone = zone.Length;

            for (i = 0; i < longZone; i++)
            {
                caractereElementaire = zone[i];
                if (caractereElementaire == caractereRecherche)
                {
                    nbrOccurences++;
                }
            }
            return nbrOccurences;
        }
        public FRM_Exo2b()
        {
            InitializeComponent();
        }

        private void Btn_Lancer_Recherche_Click(object sender, EventArgs e)
        {
            Int32 nombreOccurences;
            nombreOccurences = 0;

            if (this.Txt_Lettre_Recherchee.Text.Length == 0)
            {
                MessageBox.Show("Vous n'avez pas renseigné le caractère à rechercher");
                this.Txt_Lettre_Recherchee.Focus();
            }
            else
            {
                this.Txt_Lettre_Recherchee.Text = this.Txt_Lettre_Recherchee.Text.Substring(0, 1).ToLower();

                if (this.Chk_Phrase1.Checked)
                {
                    nombreOccurences += rechercheCaractere(this.Txt_Phrase1.Text.ToLower(), Char.Parse(this.Txt_Lettre_Recherchee.Text));
                }

                if (this.Chk_Phrase2.Checked)
                {
                    nombreOccurences += rechercheCaractere(this.Txt_Phrase2.Text.ToLower(), Char.Parse(this.Txt_Phrase2.Text));
                }

                if (this.Chk_Phrase3.Checked)
                {
                    nombreOccurences += rechercheCaractere(this.Txt_Phrase3.Text.ToLower(), Char.Parse(this.Txt_Phrase3.Text));
                }

                this.Txt_Nombre_Occurences.Text = nombreOccurences.ToString();
            }

        }
    }
}
