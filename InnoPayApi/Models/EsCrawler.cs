using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class EsCrawler
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

    public string? TeamId { get; set; }

    public string? CrawlerAgent { get; set; }

    public string? CrawlerPaging { get; set; }

    public string? CrawlerParameters { get; set; }

    public int CrawlerPeriod { get; set; }

    public string? CrawlerState { get; set; }

    public int CrawlerThreads { get; set; }

    public string CrawlerType { get; set; } = null!;

    public virtual ICollection<EsCrawlerstate> EsCrawlerstates { get; set; } = new List<EsCrawlerstate>();
}
