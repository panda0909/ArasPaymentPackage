﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class WorkflowProcessPath
{
    public string? KeyedName { get; set; }

    public string? Classification { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? CurrentState { get; set; }

    public string? ModifiedById { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? IsCurrent { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? RelatedId { get; set; }

    public string? SourceId { get; set; }

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string? Css { get; set; }

    public string? Authentication { get; set; }

    public string? IsComplete { get; set; }

    public string? IsDefault { get; set; }

    public string? IsDisabled { get; set; }

    public string? IsOverride { get; set; }

    public string? Label { get; set; }

    public string? Name { get; set; }

    public string? Segments { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? ManagedById { get; set; }

    public string? NewVersion { get; set; }

    public string? OwnedById { get; set; }

    public string? PermissionId { get; set; }

    public virtual ICollection<WorkflowProcessPathPost> WorkflowProcessPathPosts { get; set; } = new List<WorkflowProcessPathPost>();

    public virtual ICollection<WorkflowProcessPathPre> WorkflowProcessPathPres { get; set; } = new List<WorkflowProcessPathPre>();
}
