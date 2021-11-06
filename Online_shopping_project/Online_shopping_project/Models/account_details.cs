//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;

//namespace Online_shopping_project.Models
//{
//    public partial class account_details
//    {
//        public int ID { get; set; }
//        [Required(ErrorMessage = "This field is mandatory")]
//        [DataType(DataType.Text)]
//        [RegularExpression("^[a-zA-Z']{1,50}", ErrorMessage = "Please enter valid Name")]
//        [DisplayName("Name")]
//        public string Name { get; set; }
//        [Required(ErrorMessage = "This field is mandatory")]
//        [DisplayName("Address")]
//        public string address { get; set; }
//        [Required(ErrorMessage = "This field is mandatory")]
//        [DataType(DataType.PhoneNumber)]
//        [RegularExpression(@"^d{10}$", ErrorMessage = "Please enter valid phone number")]
//        [DisplayName("Phone Number")]
//        public long ph_number { get; set; }
//        [DataType(DataType.PhoneNumber)]
//        [DisplayName("Alternate Phone Number")]
//        [RegularExpression(@"^d{10}$", ErrorMessage = "Please enter valid phone number")]
//        public long alt_ph_number { get; set; }
//        [Required(ErrorMessage = "This field is mandatory")]
//        [DataType(DataType.PostalCode)]
//        [DisplayName("Pin Code")]
//        [MaxLength(6),
//       MinLength(6, ErrorMessage = "Please Enter a Valid Pin Code")]
//        public long pin_code { get; set; }
//        [Required(ErrorMessage = "This field is mandatory")]
//        [DataType(DataType.Text)]
//        [DisplayName("City")]
//        public string city { get; set; }
//    }
//}
namespace Online_shopping_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;

    public partial class account_details
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.Text)]
        [RegularExpression("^[a-zA-Z']{1,50}", ErrorMessage = "Please enter valid Name")]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [DisplayName("Address")]
        public string address { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^d{10}$", ErrorMessage = "Please enter valid phone number")]
        [DisplayName("Phone Number")]
        public long ph_number { get; set; }
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Alternate Phone Number")]
        [RegularExpression(@"^d{10}$", ErrorMessage = "Please enter valid phone number")]
        public long alt_ph_number { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.PostalCode)]
        [DisplayName("Pin Code")]
        [MaxLength(6),
       MinLength(6, ErrorMessage = "Please Enter a Valid Pin Code")]
        public long pin_code { get; set; }
        [Required(ErrorMessage = "This field is mandatory")]
        [DataType(DataType.Text)]
        [DisplayName("City")]
        public string city { get; set; }
    }
}