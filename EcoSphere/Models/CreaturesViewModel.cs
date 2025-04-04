﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace EcoSphere.Models
{
    public class CreaturesViewModel
    {
        [DisplayName("Creature ID")]
        public int CreatureId { get; set; }
        [DisplayName("Upper Realm ID")]
        public int? UpperRealmId { get; set; }
        [DisplayName("Kingdom ID")]
        public int? KingdomId { get; set; }
        [DisplayName("Phylum ID")]
        public int? PhylumId { get; set; }
        [DisplayName("Class ID")]
        public int? ClassId { get; set; }
        [DisplayName("Order ID")]
        public int? OrderId { get; set; }
        [DisplayName("Family ID")]
        public int? FamilyId { get; set; }
        [DisplayName("Genus ID")]
        public int? GenusId { get; set; }
        [DisplayName("Species ID")]
        public int? SpeciesId { get; set; }
        [DisplayName("Subspecies ID")]
        public int? SubspeciesId { get; set; }
        [DisplayName("IUCN ID")]
        public int? IucnId { get; set; }
        [DisplayName("Author ID")]
        public int? AuthorId { get; set; }
        [DisplayName("ScientificName")]
        public string? ScientificName { get; set; }
        [DisplayName("CommonName")]
        public string? CommonName { get; set; }
        [DisplayName("UpperRealmName")]
        public string? UpperRealmName { get; set; }

        [DisplayName("KingdomName")]
        public string? KingdomName { get; set; }

        [DisplayName("Phylum Name")]
        public string? PhylumName { get; set; }

        [DisplayName("Phylum Name2")]
        public string? PhylumName2 { get; set; }

        [DisplayName("Phylum Scientific Name")]
        public string? PhylumScientificName { get; set; }

        [DisplayName("ClassName")]
        public string? ClassName { get; set; }
        
        [DisplayName("ClassName2")]
        public string? ClassName2 { get; set; }

        [DisplayName("Class Scientific Name")]
        public string? ClassScientificName { get; set; }

        [DisplayName("OrderName")]
        public string? OrderName { get; set; }

        [DisplayName("OrderName2")]
        public string? OrderName2 { get; set; }

        [DisplayName("Order Scientific Name")]
        public string? OrderScientificName { get; set; }

        [DisplayName("FamilyName")]
        public string? FamilyName { get; set; }

        [DisplayName("FamilyName2")]
        public string? FamilyName2 { get; set; }

        [DisplayName("Family Scientific Name")]
        public string? FamilyScientificName { get; set; }

        [DisplayName("GenusName")]
        public string? GenusName { get; set; }

        [DisplayName("GenusName2")]
        public string? GenusName2 { get; set; }

        [DisplayName("Genus Scientific Name")]
        public string? GenusScientificName { get; set; }

        [DisplayName("SpeciesName")]
        public string? SpeciesName { get; set; }
        
        [DisplayName("SpeciesName2")]
        public string? SpeciesName2 { get; set; }

        [DisplayName("Species Scientific Name")]
        public string? SpeciesScientificName { get; set; }

        [DisplayName("SubspeciesName")]
        public string? SubspeciesName { get; set; }
        
        [DisplayName("SubspeciesName2")]
        public string? SubspeciesName2 { get; set; }
        
        [DisplayName("Sunspecies Scientific Name")]
        public string? SubspeciesScientificName { get; set; }

        [DisplayName("IucnCode")]
        public string? IucnCode { get; set; }

        [DisplayName("AuthorName")]
        public string? AuthorName { get; set; }
        
        [DisplayName("AuthorName2")]
        public string? AuthorName2 { get; set; }

        public int SelectedCretureId { get; set; }
        public IEnumerable<SelectListItem> AddCreatures { get; set; } = new List<SelectListItem>();
        
        [DisplayName("Upper Realm")]
        public IEnumerable<SelectListItem> UpperRealmNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Kingdom")]
        public IEnumerable<SelectListItem> KingdomNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Phylum")]
        public IEnumerable<SelectListItem> PhylumNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Class")]
        public IEnumerable<SelectListItem> ClassNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Order")]
        public IEnumerable<SelectListItem> OrderNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Family")]
        public IEnumerable<SelectListItem> FamilyNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Genus")]
        public IEnumerable<SelectListItem> GenusNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Species")]
        public IEnumerable<SelectListItem> SpeciesNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("Subspecies")]
        public IEnumerable<SelectListItem> SubspeciesNamed { get; set; } = new List<SelectListItem>();

        [DisplayName("IUCN")]
        public IEnumerable<SelectListItem> IucnCoded { get; set; } = new List<SelectListItem>();

        [DisplayName("Author")]
        public IEnumerable<SelectListItem> AuthorNamed { get; set; } = new List<SelectListItem>();

    }
}
