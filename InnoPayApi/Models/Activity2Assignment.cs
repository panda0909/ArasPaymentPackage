﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Activity2Assignment
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

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

    public string? ClosedBy { get; set; }

    public DateTime? ClosedOn { get; set; }

    public DateTime? DateStartAct { get; set; }

    public string? IsComplete { get; set; }

    public int? PercentCompl { get; set; }

    public int? PercentLoad { get; set; }

    public string? Role { get; set; }

    public int? WorkEst { get; set; }

    public int? WorkEstCurrent { get; set; }

    public int? WorkEtc { get; set; }

    public string? RelatedId { get; set; }

    public string? State { get; set; }

    public virtual Identity? Related { get; set; }

    public virtual Activity2? Source { get; set; }
}
