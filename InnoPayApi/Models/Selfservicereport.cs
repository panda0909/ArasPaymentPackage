﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Selfservicereport
{
    public string? Classification { get; set; }

    public string Id { get; set; } = null!;

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? IsCurrent { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? BaseItemType { get; set; }

    public string? Definition { get; set; }

    public string? Description { get; set; }

    public string? Extension { get; set; }

    public string? Format { get; set; }

    public string? Hidden { get; set; }

    public string? ItemtypeClassification { get; set; }

    public string Name { get; set; } = null!;

    public string? Thumbnail { get; set; }

    public string? Visibility { get; set; }

    public virtual ICollection<Runreportbyuser> Runreportbyusers { get; set; } = new List<Runreportbyuser>();

    public virtual ICollection<Selfservicereportsharedwith> Selfservicereportsharedwiths { get; set; } = new List<Selfservicereportsharedwith>();
}
