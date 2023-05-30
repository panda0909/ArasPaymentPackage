﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Conversionrule
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? CurrentState { get; set; }

    public string? State { get; set; }

    public string? LockedById { get; set; }

    public string? MajorRev { get; set; }

    public string? IsCurrent { get; set; }

    public string? MinorRev { get; set; }

    public string? IsReleased { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string ConfigId { get; set; } = null!;

    public string? NewVersion { get; set; }

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public int? Cutoff { get; set; }

    public int? Delay { get; set; }

    public string? Description { get; set; }

    public string? Enabled { get; set; }

    public int? Timeout { get; set; }

    public string Name { get; set; } = null!;

    public string ConverterType { get; set; } = null!;

    public virtual ICollection<Conversionruleeventhandler> Conversionruleeventhandlers { get; set; } = new List<Conversionruleeventhandler>();

    public virtual ICollection<Conversionruleeventtemplate> Conversionruleeventtemplates { get; set; } = new List<Conversionruleeventtemplate>();

    public virtual ICollection<Conversionrulefiletype> Conversionrulefiletypes { get; set; } = new List<Conversionrulefiletype>();
}
