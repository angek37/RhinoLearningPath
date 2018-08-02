using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace HelperMethods.Models.Metadata
{
    [DisplayName("New Person")]
    public partial class PersonMetadata
    {
        [HiddenInput(DisplayValue = false)]
        public int PersonId { set; get; }
        [Display(Name = "First")]
        public string FirstName { set; get; }
        [Display(Name = "Last")]
        public string LastName { set; get; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { set; get; }
        [Display(Name = "Approved")]
        public bool IsApproved { set; get; }
    }
}