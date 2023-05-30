using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Wstype
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? SourceId { get; set; }

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string? Alias { get; set; }

    public string? Expand { get; set; }

    public string? IsTop { get; set; }

    public string TypeName { get; set; } = null!;

    public string? RelatedId { get; set; }

    public virtual Wsconfiguration? Source { get; set; }

    public virtual ICollection<Wstypeaction> Wstypeactions { get; set; } = new List<Wstypeaction>();

    public virtual ICollection<Wstypeassociate> WstypeassociateRelateds { get; set; } = new List<Wstypeassociate>();

    public virtual ICollection<Wstypeassociate> WstypeassociateSources { get; set; } = new List<Wstypeassociate>();

    public virtual ICollection<Wstypeproperty> Wstypeproperties { get; set; } = new List<Wstypeproperty>();
}
