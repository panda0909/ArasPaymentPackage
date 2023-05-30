﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Databaseupgradelogfile
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? OwnedById { get; set; }

    public string CreatedById { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? State { get; set; }

    public string? MajorRev { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? NotLockable { get; set; }

    public string? ModifiedById { get; set; }

    public string? LockedById { get; set; }

    public string? MinorRev { get; set; }

    public string? CurrentState { get; set; }

    public string? ManagedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? Behavior { get; set; }

    public string PermissionId { get; set; } = null!;

    public string ConfigId { get; set; } = null!;

    public string? NewVersion { get; set; }

    public string? SourceId { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? RelatedId { get; set; }

    public virtual File? Related { get; set; }

    public virtual Databaseupgrade? Source { get; set; }
}
