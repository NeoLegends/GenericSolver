using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GeneticSolver.Resources;

namespace GeneticSolver
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.tbInput.Focus();
        }

        /// <summary>
        /// Being called when the text of the input textbox changed.
        /// </summary>
        /// <param name="sender"><see cref="Object"/>.</param>
        /// <param name="e"><see cref="TextChangedEventArgs"/>.</param>
        private void tbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            String codonInput = tbInput.Text.Trim().ToUpperInvariant().Replace(Environment.NewLine, String.Empty).Replace(" ", String.Empty).Replace("T", "U");
            IEnumerable<AminoAcid> aminoAcids = this.GetAminoAcids(this.GetCodons(codonInput));
            
            this.tbOutput.Text = String.Join(", ", aminoAcids.Select(aminoAcid => (aminoAcid != null) ? aminoAcid.ShortName : "Error"));
        }

        /// <summary>
        /// Splits the text into codons and returns null for an incomplete codon.
        /// </summary>
        /// <param name="input">The input to parse.</param>
        /// <returns>A list of codons.</returns>
        private IEnumerable<String> GetCodons(String input)
        {
            for (int i = 0; i < input.Length; i += 3)
            {
                if ((i + 2) < input.Length)
                {
                    yield return input.Substring(i, 3);
                }
                else
                {
                    yield return null;
                }
            }
        }

        /// <summary>
        /// Gets the amino acid to the associated codon in the given collection.
        /// </summary>
        /// <param name="codons">A collection of codons.</param>
        /// <returns>A list of amino acids.</returns>
        private IEnumerable<AminoAcid> GetAminoAcids(IEnumerable<String> codons)
        {
            foreach (String codon in codons)
            {
                yield return AminoAcid.AllRnaEncoded.FirstOrDefault(aminoAcid => aminoAcid.Combinations.Any(aminoCodon => codon == aminoCodon));
            }
        }
    }
}
