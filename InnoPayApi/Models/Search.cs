﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Search
{
    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public int? Generation { get; set; }

    public string? PermissionId { get; set; }

    public string? ManagedById { get; set; }

    public string? OwnedById { get; set; }

    public string? LockedById { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public string? IsCurrent { get; set; }

    public string? State { get; set; }

    public string? Label { get; set; }

    public string? KeyedName { get; set; }

    public string? SearchItemtype { get; set; }

    public string? MajorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? Interactive { get; set; }

    public string? NotLockable { get; set; }

    public string? CurrentState { get; set; }

    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public string? ModifiedById { get; set; }

    public string? MinorRev { get; set; }

    public string? TeamId { get; set; }

    public string? Classification { get; set; }

    public string? Css { get; set; }

    public virtual ICollection<SearchCriterion> SearchCriteria { get; set; } = new List<SearchCriterion>();
}
