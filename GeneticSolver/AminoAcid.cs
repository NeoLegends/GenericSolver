using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using GeneticSolver.Resources.AminoAcids;

namespace GeneticSolver
{
    /// <summary>
    /// Represents an amino acid.
    /// </summary>
    [Serializable, DataContract]
    public class AminoAcid
    {
        /// <summary>
        /// Alanine.
        /// </summary>
        public static readonly AminoAcid Ala = new AminoAcid(
            new[] { "GCU", "GCC", "GCA", "GCG" }, 
            Alanine.ShortName,
            Alanine.Name,
            Alanine.Description,
            Alanine.WikipediaLink
        );

        /// <summary>
        /// Arginine.
        /// </summary>
        public static readonly AminoAcid Arg = new AminoAcid(
            new[] { "CGU", "CGC", "CGA", "CGG", "AGA", "AGG" },
            Arginine.ShortName,
            Arginine.Name,
            Arginine.Description,
            Arginine.WikipediaLink
        );

        /// <summary>
        /// Asparagine.
        /// </summary>
        public static readonly AminoAcid Asn = new AminoAcid(
            new[] { "AAU", "AAC" },
            Asparagine.ShortName,
            Asparagine.Name,
            Asparagine.Description,
            Asparagine.WikipediaLink
        );

        /// <summary>
        /// Asparagine.
        /// </summary>
        public static readonly AminoAcid Asp = new AminoAcid(
            new[] { "GAU", "GAC" },
            AsparticAcid.ShortName,
            AsparticAcid.Name,
            AsparticAcid.Description,
            AsparticAcid.WikipediaLink
        );

        /// <summary>
        /// Cysteine.
        /// </summary>
        public static readonly AminoAcid Cys = new AminoAcid(
            new[] { "UGU", "UGC" },
            Cysteine.ShortName,
            Cysteine.Name,
            Cysteine.Description,
            Cysteine.WikipediaLink
        );

        /// <summary>
        /// GlutamicAcid.
        /// </summary>
        public static readonly AminoAcid Glu = new AminoAcid(
            new[] { "GAA", "GAG" },
            GlutamicAcid.ShortName,
            GlutamicAcid.Name,
            GlutamicAcid.Description,
            GlutamicAcid.WikipediaLink
        );

        /// <summary>
        /// Glutamine.
        /// </summary>
        public static readonly AminoAcid Gln = new AminoAcid(
            new[] { "CAA", "CAG" },
            Glutamine.ShortName,
            Glutamine.Name,
            Glutamine.Description,
            Glutamine.WikipediaLink
        );

        /// <summary>
        /// Glycine.
        /// </summary>
        public static readonly AminoAcid Gly = new AminoAcid(
            new[] { "GGU", "GGC", "GGA", "GGG" },
            Glycine.ShortName,
            Glycine.Name,
            Glycine.Description,
            Glycine.WikipediaLink
        );

        /// <summary>
        /// Histidine.
        /// </summary>
        public static readonly AminoAcid His = new AminoAcid(
            new[] { "CAU", "CAC" },
            Histidine.ShortName,
            Histidine.Name,
            Histidine.Description,
            Histidine.WikipediaLink
        );

        /// <summary>
        /// Isoleucine.
        /// </summary>
        public static readonly AminoAcid Ile = new AminoAcid(
            new[] { "AUU", "AUC", "AUA" },
            Isoleucine.ShortName,
            Isoleucine.Name,
            Isoleucine.Description,
            Isoleucine.WikipediaLink
        );

        /// <summary>
        /// Leucine.
        /// </summary>
        public static readonly AminoAcid Leu = new AminoAcid(
            new[] { "UUA", "UUG", "CUU", "CUC", "CUC", "CUG" },
            Leucine.ShortName,
            Leucine.Name,
            Leucine.Description,
            Leucine.WikipediaLink
        );

        /// <summary>
        /// Lysine.
        /// </summary>
        public static readonly AminoAcid Lys = new AminoAcid(
            new[] { "AAA", "AAG" },
            Lysine.ShortName,
            Lysine.Name,
            Lysine.Description,
            Lysine.WikipediaLink
        );

        /// <summary>
        /// Methionine.
        /// </summary>
        public static readonly AminoAcid Met = new AminoAcid(
            new[] { "AUG" },
            Methionine.ShortName,
            Methionine.Name,
            Methionine.Description,
            Methionine.WikipediaLink
        );

        /// <summary>
        /// Phenylalanine.
        /// </summary>
        public static readonly AminoAcid Phe = new AminoAcid(
            new[] { "UUU", "UUC" },
            Phenylalanine.ShortName,
            Phenylalanine.Name,
            Phenylalanine.Description,
            Phenylalanine.WikipediaLink
        );

        /// <summary>
        /// Proline.
        /// </summary>
        public static readonly AminoAcid Pro = new AminoAcid(
            new[] { "CCU", "CCC", "CCA", "CCG" },
            Proline.ShortName,
            Proline.Name,
            Proline.Description,
            Proline.WikipediaLink
        );

        /// <summary>
        /// Serine.
        /// </summary>
        public static readonly AminoAcid Ser = new AminoAcid(
            new[] { "UCU", "UCC", "UCA", "UCG", "AGU", "AGC" },
            Serine.ShortName,
            Serine.Name,
            Serine.Description,
            Serine.WikipediaLink
        );

        /// <summary>
        /// Stop codon.
        /// </summary>
        public static readonly AminoAcid Stop = new AminoAcid(
            new[] { "UAA", "UAG", "UGA" },
            StopCodon.ShortName,
            StopCodon.Name,
            StopCodon.Description,
            StopCodon.WikipediaLink
        );

        /// <summary>
        /// Threonine.
        /// </summary>
        public static readonly AminoAcid Thr = new AminoAcid(
            new[] { "ACU", "ACC", "ACA", "ACG" },
            Threonine.ShortName,
            Threonine.Name,
            Threonine.Description,
            Threonine.WikipediaLink
        );

        /// <summary>
        /// Tryptophan.
        /// </summary>
        public static readonly AminoAcid Trp = new AminoAcid(
            new[] { "UGG" },
            Tryptophan.ShortName,
            Tryptophan.Name,
            Tryptophan.Description,
            Tryptophan.WikipediaLink
        );

        /// <summary>
        /// Tyrosine.
        /// </summary>
        public static readonly AminoAcid Tyr = new AminoAcid(
            new[] { "UAU", "UAC" },
            Tyrosine.ShortName,
            Tyrosine.Name,
            Tyrosine.Description,
            Tyrosine.WikipediaLink
        );

        /// <summary>
        /// Valine.
        /// </summary>
        public static readonly AminoAcid Val = new AminoAcid(
            new[] { "GUU", "GUC", "GUA", "GUG" },
            Valine.ShortName,
            Valine.Name,
            Valine.Description,
            Valine.WikipediaLink
        );

        /// <summary>
        /// Contains all RNA-encoded amino acids.
        /// </summary>
        public static readonly IEnumerable<AminoAcid> AllRnaEncoded = new[]
        {
            Ala, Arg, Asn, Asp, Cys, Glu, Gln, Gly, His, Ile, Leu, Lys, Met, Phe, Pro, Ser, Stop, Thr, Trp, Tyr, Val
        };

        /// <summary>
        /// The <see cref="AminoAcid"/>'s mRNA-combinations.
        /// </summary>
        [DataMember]
        public String[] Combinations { get; private set; }

        /// <summary>
        /// The <see cref="AminoAcid"/>'s short name. e.g. Phe
        /// </summary>
        [DataMember]
        public String ShortName { get; private set; }

        /// <summary>
        /// The <see cref="AminoAcid"/>'s full name. e.g. Phenylalanin
        /// </summary>
        [DataMember]
        public String FullName { get; private set; }

        /// <summary>
        /// The <see cref="AminoAcid"/>'s description.
        /// </summary>
        [DataMember]
        public String Description { get; private set; }

        /// <summary>
        /// The <see cref="AminoAcid"/>'s wikipedia entry.
        /// </summary>
        [DataMember]
        public String WikipediaLink { get; private set; }

        /// <summary>
        /// Initializes a new <see cref="AminoAcid"/>.
        /// </summary>
        /// <param name="combinations">The amino acid's mRNA-combinations.</param>
        /// <param name="shortName">The <see cref="AminoAcid"/>'s short name. e.g. Phe</param>
        /// <param name="fullName">The <see cref="AminoAcid"/>'s full name. e.g. Phenylalanin</param>
        /// <param name="description">The <see cref="AminoAcid"/>'s description.</param>
        /// <param name="wikipediaLink">The <see cref="AminoAcid"/>'s wikipedia entry.</param>
        private AminoAcid(
                String[] combinations,
                String shortName,
                String fullName,
                String description,
                String wikipediaLink
            )
        {
            this.Combinations = combinations;
            this.ShortName = shortName;
            this.FullName = fullName;
            this.Description = description;
            this.WikipediaLink = wikipediaLink;
        }

        /// <summary>
        /// Checks whether the given base sequence is a valid codon for the amino acid.
        /// </summary>
        /// <param name="combination">The base sequence to check.</param>
        /// <returns>A boolean indicating whether the given codon is a valid sequence of the amino acid.</returns>
        public bool IsValidCombination(String combination)
        {
            if (combination == null)
                throw new ArgumentNullException("combination");
            if (combination.Length != 3)
                throw new ArgumentOutOfRangeException("The combination was not a base triplet.");

            return this.Combinations.Any(codon => codon == combination);
        }

        /// <summary>
        /// Converts the <see cref="AminoAcid"/> to a <see cref="String"/> returning it's short name.
        /// </summary>
        /// <returns>The <see cref="AminoAcid"/>'s short name.</returns>
        public override string ToString()
        {
            return this.ShortName;
        }
    }
}
