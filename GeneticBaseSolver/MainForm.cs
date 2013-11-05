using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticBaseSolver
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Lists all aminoic acids bound to a base triplet.
        /// </summary>
        public enum AminoAcids
        {
            Phe,
            Leu,
            Ile,
            MetStart,
            Val,
            Ser,
            Pro,
            Thr,
            Ala,
            Tyr,
            His,
            Gln,
            Asn,
            Lys,
            Asp,
            Glu,
            Cys,
            Trp,
            Arg,
            Gly,

            Stop
        }

        /// <summary>
        /// Contains the aminoic acids with their associated nucleic base code.
        /// </summary>
        public Dictionary<String, AminoAcids> Encoded = new Dictionary<String, AminoAcids>()
        {
            { "UUU", AminoAcids.Phe },
            { "UUC", AminoAcids.Phe },

            { "UUA", AminoAcids.Leu },
            { "UUG", AminoAcids.Leu },
            { "CUU", AminoAcids.Leu },
            { "CUC", AminoAcids.Leu },
            { "CUA", AminoAcids.Leu },
            { "CUG", AminoAcids.Leu },
            
            { "AUU", AminoAcids.Ile },
            { "AUC", AminoAcids.Ile },
            { "AUA", AminoAcids.Ile },

            { "AUG", AminoAcids.MetStart },
            
            { "GUU", AminoAcids.Val },
            { "GUC", AminoAcids.Val },
            { "GUA", AminoAcids.Val },
            { "GUG", AminoAcids.Val },
            
            { "UCU", AminoAcids.Ser },
            { "UCC", AminoAcids.Ser },
            { "UCA", AminoAcids.Ser },
            { "UCG", AminoAcids.Ser },
            
            { "CCU", AminoAcids.Pro },
            { "CCC", AminoAcids.Pro },
            { "CCA", AminoAcids.Pro },
            { "CCG", AminoAcids.Pro },
            
            { "ACU", AminoAcids.Thr },
            { "ACC", AminoAcids.Thr },
            { "ACA", AminoAcids.Thr },
            { "ACG", AminoAcids.Thr },
            
            { "GCU", AminoAcids.Ala },
            { "GCC", AminoAcids.Ala },
            { "GCA", AminoAcids.Ala },
            { "GCG", AminoAcids.Ala },
            
            { "UAU", AminoAcids.Tyr },
            { "UAC", AminoAcids.Tyr },
            
            { "CAU", AminoAcids.His },
            { "CAC", AminoAcids.His },
            
            { "CAA", AminoAcids.Gln },
            { "CAG", AminoAcids.Gln },
            
            { "AAU", AminoAcids.Asn },
            { "AAC", AminoAcids.Asn },
            
            { "AAA", AminoAcids.Lys },
            { "AAG", AminoAcids.Lys },
            
            { "GAU", AminoAcids.Asp },
            { "GAC", AminoAcids.Asp },
            
            { "GAA", AminoAcids.Glu },
            { "GAG", AminoAcids.Glu },
            
            { "UGU", AminoAcids.Cys },
            { "UGC", AminoAcids.Cys },

            { "UGG", AminoAcids.Trp },
            
            { "CGU", AminoAcids.Arg },
            { "CGC", AminoAcids.Arg },
            { "CGA", AminoAcids.Arg },
            { "CGG", AminoAcids.Arg },
            
            { "AGU", AminoAcids.Ser },
            { "AGC", AminoAcids.Ser },
            
            { "AGA", AminoAcids.Arg },
            { "AGG", AminoAcids.Arg },
            
            { "GGU", AminoAcids.Gly },
            { "GGC", AminoAcids.Gly },
            { "GGA", AminoAcids.Gly },
            { "GGG", AminoAcids.Gly },
            
            { "UAA", AminoAcids.Stop },
            { "UAG", AminoAcids.Stop },
            { "UGA", AminoAcids.Stop },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                String input = tbInput.Text.Trim().Replace(Environment.NewLine, String.Empty).Replace(" ", String.Empty); ;
                tbOutput.Text = String.Join(", ", this.GetAminoicAcids(this.GetBaseCombinations(input)));
            }
            catch
            {
                lbError.Visible = true;
            }
        }

        private IEnumerable<String> GetAminoicAcids(IEnumerable<String> baseCombinations)
        {
            foreach (String baseCombination in baseCombinations)
            {
                AminoAcids acid;
                if (this.Encoded.TryGetValue(baseCombination.ToUpperInvariant(), out acid))
                {
                    yield return acid.ToString();
                }
                else
                {
                    yield return null;
                }
            }
        }

        private IEnumerable<String> GetBaseCombinations(String input)
        {
            for (int i = 0; i < input.Length; i += 3)
            {
                yield return input.Substring(i, 3);
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }
    }
}
