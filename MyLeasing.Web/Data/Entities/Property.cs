﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyLeasing.Web.Data.Entities
{
    public class Property
    {
        public int Id { get; set; }

        [Display(Name = "Neighborhood")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Neighborhood { get; set; }

        [Display(Name = "Address")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Square meters")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int SquareMeters { get; set; }

        [Display(Name = "Rooms")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Rooms { get; set; }

        [Display(Name = "Stratum")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public int Stratum { get; set; }

        [Display(Name = "Has Parking Lot?")]
        public bool HasParkingLot { get; set; }

        [Display(Name = "Is Available?")]
        public bool IsAvailable { get; set; }

        public string Remarks { get; set; }

        public PropertyType PropertyType { get; set; }

        public Owner Owner { get; set; }

        public ICollection<PropertyImage> PropertyImages { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public string FirstImage => PropertyImages == null || PropertyImages.Count == 0
        ? "https://pngimage.net/wp-content/uploads/2018/06/image-not-found-png-6-300x200.png"
        : PropertyImages.FirstOrDefault().ImageUrl;
    }
}