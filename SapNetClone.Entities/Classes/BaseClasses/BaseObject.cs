using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SapNetClone.Entities.Classes.BaseClasses;

public class BaseObject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ScaffoldColumn(false)]
    public DateTime CreatedDate { get; set; }
    
    [Browsable(false)]
    [ScaffoldColumn(false)]
    public int? CreateById { get; set; }
    
    [DefaultValue(0)]
    public int? UpdateById { get; set; }

    public DateTime? LastModifiedOn { get; set; }
    public string? LastModifiedName { get; set; }
    
    [DisplayName("Aktif")]
    public bool Active { get; set; }

    [DisplayName("Durum")]
    public string IsActiveString => Active ? "Aktif" : "Pasif";

    [ScaffoldColumn(false)]
    public bool? IsDeleted { get; set; }
}