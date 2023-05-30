﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class LifeCycleTransition
{
    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string FromState { get; set; } = null!;

    public string? GetComment { get; set; }

    public string? Label { get; set; }

    public string? PostAction { get; set; }

    public string? PreAction { get; set; }

    public string? Role { get; set; }

    public string? Segments { get; set; }

    public string ToState { get; set; } = null!;

    public int? X { get; set; }

    public int? Y { get; set; }

    public string? Behavior { get; set; }

    public string ConfigId { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Css { get; set; }

    public string? CurrentState { get; set; }

    public int? Generation { get; set; }

    public string Id { get; set; } = null!;

    public string? IsCurrent { get; set; }

    public string? IsReleased { get; set; }

    public string? KeyedName { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? ManagedById { get; set; }

    public string? MinorRev { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? NewVersion { get; set; }

    public string? NotLockable { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public string? RelatedId { get; set; }

    public int? SortOrder { get; set; }

    public string SourceId { get; set; } = null!;

    public string? State { get; set; }

    public virtual ICollection<ActivityTemplateTransition> ActivityTemplateTransitions { get; set; } = new List<ActivityTemplateTransition>();

    public virtual ICollection<ActivityTransition> ActivityTransitions { get; set; } = new List<ActivityTransition>();

    public virtual LifeCycleMap Source { get; set; } = null!;

    public virtual ICollection<TransitionEmail> TransitionEmails { get; set; } = new List<TransitionEmail>();
}
