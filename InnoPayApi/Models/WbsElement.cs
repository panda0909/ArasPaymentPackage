using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class WbsElement
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

    public decimal? Cpi { get; set; }

    public string? DelivRequired { get; set; }

    public string? IsTop { get; set; }

    public string? Name { get; set; }

    public string? PrevItem { get; set; }

    public int? ProjNum { get; set; }

    public decimal? RollupActualWork { get; set; }

    public DateTime? RollupDateSchedDue { get; set; }

    public DateTime? RollupDateSchedStart { get; set; }

    public DateTime? RollupDateStartAct { get; set; }

    public int? RollupDuration { get; set; }

    public double? RollupDurationComplSum { get; set; }

    public int? RollupDurationSum { get; set; }

    public int? RollupEarnedValue { get; set; }

    public int? RollupPercentCompl { get; set; }

    public int? RollupPlannedValue { get; set; }

    public string? RollupStatus { get; set; }

    public int? RollupWorkEst { get; set; }

    public int? RollupWorkEstCurr { get; set; }

    public decimal? Spi { get; set; }

    public string? WbsIndex { get; set; }

    public virtual ICollection<SubWb> SubWbRelateds { get; set; } = new List<SubWb>();

    public virtual ICollection<SubWb> SubWbSources { get; set; } = new List<SubWb>();

    public virtual ICollection<WbsActivity2> WbsActivity2s { get; set; } = new List<WbsActivity2>();

    public virtual ICollection<WbsDeliverable> WbsDeliverables { get; set; } = new List<WbsDeliverable>();
}
