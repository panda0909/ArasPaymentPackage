using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Databaseupgrade
{
    public string? Classification { get; set; }

    public string? ModifiedById { get; set; }

    public string Id { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? IsCurrent { get; set; }

    public string? KeyedName { get; set; }

    public string? OwnedById { get; set; }

    public string? MajorRev { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? LockedById { get; set; }

    public string? ManagedById { get; set; }

    public string? MinorRev { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? State { get; set; }

    public string? IsReleased { get; set; }

    public string PermissionId { get; set; } = null!;

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? NotLockable { get; set; }

    public string? NewVersion { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public DateTime? AppliedOn { get; set; }

    public string? Description { get; set; }

    public string? IsLatest { get; set; }

    public string? Name { get; set; }

    public string? OsUser { get; set; }

    public string? TargetRelease { get; set; }

    public string? Type { get; set; }

    public string? UpgradeStatus { get; set; }

    public virtual ICollection<Databaseupgradelogfile> Databaseupgradelogfiles { get; set; } = new List<Databaseupgradelogfile>();

    public virtual ICollection<Databaseupgradepatch> Databaseupgradepatches { get; set; } = new List<Databaseupgradepatch>();
}
