﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace GeneticSolver.UI
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
            this.Closed += (s, e) => Application.Current.Shutdown();

            this.tbInput.Focus();
        }

        /// <summary>
        /// Handles the event when the button to copy the output to the clipboard was clicked.
        /// </summary>
        /// <param name="sender"><see cref="Object"/>.</param>
        /// <param name="e"><see cref="RoutedEventArgs"/>.</param>
        private void btnCopyClipboard_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Clipboard.SetText(this.tbOutput.Text);
        }

        /// <summary>
        /// Handles the event when the button to show all amino acids was clicked.
        /// </summary>
        /// <param name="sender"><see cref="Object"/>.</param>
        /// <param name="e"><see cref="RoutedEventArgs"/>.</param>
        private void btnAllAminoAcids_Click(object sender, RoutedEventArgs e)
        {
            new AminoWindow().Show();
        }

        /// <summary>
        /// Handles the event when the text of the input textbox changed.
        /// </summary>
        /// <param name="sender"><see cref="Object"/>.</param>
        /// <param name="e"><see cref="TextChangedEventArgs"/>.</param>
        private void tbInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string baseSequence = new string(tbInput.Text.Trim().ToUpperInvariant().Replace("T", "U").Where(ch => Char.IsLetter(ch)).ToArray());

            IEnumerable<AminoAcid> aminoAcids = this.ContainsStartCodon(baseSequence) ? // Check if start codon is available
                this.TranslateInput(baseSequence, baseSequence.IndexOf(AminoAcid.Met.Combinations.First())) : // If yes, start decoding at start codon position
                this.TranslateInput(baseSequence, 0); // If not, start at the beginning of the input

            tbOutput.Text = string.Join(", ", aminoAcids);
        }

        /// <summary>
        /// Splits the text into <see cref="AminoAcid"/>s.
        /// </summary>
        /// <param name="input">The input to parse.</param>
        /// <param name="startIndex">The index to start parsing at.</param>
        /// <returns>A list of codons.</returns>
        private IEnumerable<AminoAcid> TranslateInput(string input, int startIndex)
        {
            for (int i = 0; i < input.Length; i += 3) // Always walk three (=codon-length) steps
            {
                if ((i + startIndex + 2) < input.Length) // Check if it's safe to substring
                {
                    string codon = input.Substring(i + startIndex, 3); // Get the new codon

                    if (!AminoAcid.Stop.IsValidCombination(codon)) // If input is no stop codon, return it
                    {
                        yield return AminoAcid.AllRnaEncoded.FirstOrDefault(aminoAcid => aminoAcid.Combinations.Any(aminoCombination => codon == aminoCombination));
                    }
                    else
                    {
                        yield return AminoAcid.Stop; // If input is stop codon, return it and break
                        yield break;
                    }
                }
                else
                {
                    yield break;
                }
            }
        }

        /// <summary>
        /// Checks whether the given base sequence contains a start codon.
        /// </summary>
        /// <param name="input">The base sequence to check.</param>
        /// <returns>A boolean indicating whether the input contains a start codon.</returns>
        private bool ContainsStartCodon(string input)
        {
            return AminoAcid.Met.Combinations.Any(codon => input.Contains(codon));
        }
    }
}
