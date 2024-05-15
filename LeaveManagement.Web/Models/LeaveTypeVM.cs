using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("LeaveTypeId")]
        [Display (Name = "Default number of days")]
        [Required]
        [Range(1,25,ErrorMessage ="pleaseenter a valid number")]
        public int DefaultDays{ get; set; }
    }
}
