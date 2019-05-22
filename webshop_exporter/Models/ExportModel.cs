﻿using System;
using webshop_exporter.CSV;

namespace webshop_exporter.Models
{
    public class ExportModel
    {
        [Header("ART.nr")]
        public string Id { get; set; }

        public string Parent { get; set; }

        [Header("Pris (exkl moms)")]
        public string Price { get; set; }

        [Header("Titel")]
        public string Title { get; set; }

        [Header("Huvudkategori")]
        public string Category { get; set; }

        [Header("Underkategori")]
        public string SubCategory { get; set; }

        [Header("Alternativ")]
        public string Alternative { get; set; }

        [Header("Attribut för variant 1")]
        public string AttributeVariant1 { get; set; }

        [Header("Attribut för variant 1")]
        public string AttributeVariant2 { get; set; }

        public string Drift { get; set; }

        public string Material { get; set; }

        [Header("Vattentålighet")]
        public string WaterResistance { get; set; }

        [Header("Funktionalitet")]
        public string Functionality { get; set; }

        [Header("Vikt (g)")]
        public string Weight { get; set; }

        [Header("Mått (mm)")]
        public string Measurment { get; set; }

        [Header("Kort beskrivning")]
        public string Description { get; set; }

        [Header("Allmän text")]
        public string Text { get; set; }

        [Header("Bild-1")]
        public string Image1 { get; set; }

        [Header("Bild-2")]
        public string Image2 { get; set; }

        [Header("Bild-3")]
        public string Image3 { get; set; }

        [Header("Bild-4")]
        public string Image4 { get; set; }

        [Header("Bild-5")]
        public string Image5 { get; set; }

        [Header("Bifogad PDF-Broschyr")]
        public string PdfFolder { get; set; }

        [Header("Bifogad PDF Monteringsinstruktion")]
        public string PdfAssemblyInstructions { get; set; }

        [Header("Bifogad PDF-Manual")]
        public string PdfManual { get; set; }
    }
}
