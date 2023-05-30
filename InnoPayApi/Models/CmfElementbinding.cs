﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class CmfElementbinding
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

    public string ItemDeleteBehavior { get; set; } = null!;

    public string NewRowMode { get; set; } = null!;

    public string? OnAfterPick { get; set; }

    public string? OnApplyBinding { get; set; }

    public string ReferenceRequired { get; set; } = null!;

    public string? OnCreateReference { get; set; }

    public string ReferenceType { get; set; } = null!;

    public string ResolutionMode { get; set; } = null!;

    public string? StructureMappingMethod { get; set; }

    public string SynchronizationDirection { get; set; } = null!;

    public string TrackingMode { get; set; } = null!;

    public string? RelatedId { get; set; }

    public virtual ICollection<CmfPropertybinding> CmfPropertybindings { get; set; } = new List<CmfPropertybinding>();

    public virtual CmfElementtype? Source { get; set; }
}
