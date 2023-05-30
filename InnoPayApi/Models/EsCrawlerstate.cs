using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class EsCrawlerstate
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

    public DateTime? CaFinish { get; set; }

    public DateTime? CaStart { get; set; }

    public string? CurrentAction { get; set; }

    public int? CurrentlyProcessed { get; set; }

    public string? Errors { get; set; }

    public string? HasErrors { get; set; }

    public string? IsIterationFinished { get; set; }

    public string? NextAction { get; set; }

    public DateTime? LastUpdate { get; set; }

    public int? TotalToProcess { get; set; }

    public string? RelatedId { get; set; }

    public virtual EsCrawler? Source { get; set; }
}
