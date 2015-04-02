using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace w04b2.Models
{
    [MetadataType(typeof(RegionMetaData))]
   public partial class Region
    {
       public class RegionMetaData
       {
           [Required]
           [StringLength(10)]
           [Display(Name = "Rgn Desc")]
           public string RegionDescription { get; set; }
       }
    }
} 