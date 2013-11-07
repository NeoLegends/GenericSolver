using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GeneticSolver.UI
{
    /// <summary>
    /// Interaktionslogik für AminoWindow.xaml
    /// </summary>
    public partial class AminoWindow : Window
    {
        /// <summary>
        /// Contains all listed amino acids.
        /// </summary>
        private ObservableCollection<ListBoxItem> aminoAcidSource = new ObservableCollection<ListBoxItem>();

        /// <summary>
        /// Initializes a new <see cref="AminoWindow"/>.
        /// </summary>
        public AminoWindow()
        {
            InitializeComponent();
            ScrollViewer.SetVerticalScrollBarVisibility(this.lbAminoAcidList, ScrollBarVisibility.Disabled);

            foreach (AminoAcid aminoAcid in AminoAcid.AllRnaEncoded)
            {
                ListBoxItem item = new ListBoxItem();
                item.Style = (Style)Application.Current.FindResource("LbiStyleAminoAcidHeader");
                item.Content = aminoAcid.FullName;
                item.Selected += (s, e) =>
                {
                    lbAminoAcidFullName.Content = aminoAcid.FullName;
                    lbAminoAcidShortName.Content = aminoAcid.ShortName;
                    tblAminoAcidDescription.Text = aminoAcid.Description;
                    lbWikipediaLink.Content = aminoAcid.WikipediaLink;
                };

                aminoAcidSource.Add(item);
            }

            this.lbAminoAcidList.ItemsSource = aminoAcidSource;
            this.aminoAcidSource[0].IsSelected = true;
        }

        private void btnOpenWikipediaArticle_Click(object sender, RoutedEventArgs e)
        {
            Process.Start((String)lbWikipediaLink.Content);
        }
    }
}
