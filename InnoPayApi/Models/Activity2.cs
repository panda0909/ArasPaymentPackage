using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Activity2
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

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

    public decimal? ActualWork { get; set; }

    public decimal? Cpi { get; set; }

    public DateTime? DateActivated { get; set; }

    public DateTime? DateDueAct { get; set; }

    public DateTime? DateDueOriginal { get; set; }

    public DateTime? DateDueSched { get; set; }

    public DateTime? DateDueTarget { get; set; }

    public DateTime? DateEf { get; set; }

    public DateTime? DateEs { get; set; }

    public DateTime? DateLf { get; set; }

    public DateTime? DateLs { get; set; }

    public DateTime? DateResume { get; set; }

    public DateTime? DateStartAct { get; set; }

    public DateTime? DateStartSched { get; set; }

    public DateTime? DateStartTarget { get; set; }

    public DateTime? DateUserEstimate { get; set; }

    public int? DaysRemaining { get; set; }

    public string? DelivRequired { get; set; }

    public string? Description { get; set; }

    public int? EarnedValue { get; set; }

    public int? ExpectedDuration { get; set; }

    public string? IsCritical { get; set; }

    public string? IsMilestone { get; set; }

    public string? IsRequired { get; set; }

    public string? LeadRole { get; set; }

    public string? Message { get; set; }

    public string? Name { get; set; }

    public int? OrigDuration { get; set; }

    public int? PercentCompl { get; set; }

    public int? PlannedValue { get; set; }

    public string? PrevItem { get; set; }

    public string? ProjIndex { get; set; }

    public int? ProjNum { get; set; }

    public decimal? RollupActualWork { get; set; }

    public DateTime? RollupDateStartAct { get; set; }

    public int? RollupPercentCompl { get; set; }

    public int? RollupWorkEst { get; set; }

    public int? RollupWorkEstCurr { get; set; }

    public string? SignoffRequired { get; set; }

    public decimal? Spi { get; set; }

    public string? Status { get; set; }

    public int? WorkEst { get; set; }

    public int? WorkEstCurr { get; set; }

    public int? X { get; set; }

    public int? Y { get; set; }

    public string? ManagedById { get; set; }

    public string? OwnedById { get; set; }

    public string? DelivType { get; set; }

    public virtual ICollection<Activity2Assignment> Activity2Assignments { get; set; } = new List<Activity2Assignment>();

    public virtual ICollection<Activity2Comment> Activity2Comments { get; set; } = new List<Activity2Comment>();

    public virtual ICollection<Activity2Deliverable> Activity2Deliverables { get; set; } = new List<Activity2Deliverable>();

    public virtual ICollection<Activity2Task> Activity2Tasks { get; set; } = new List<Activity2Task>();

    public virtual ICollection<Predecessor> PredecessorRelateds { get; set; } = new List<Predecessor>();

    public virtual ICollection<Predecessor> PredecessorSources { get; set; } = new List<Predecessor>();

    public virtual ICollection<TimeRecord> TimeRecords { get; set; } = new List<TimeRecord>();

    public virtual ICollection<WbsActivity2> WbsActivity2s { get; set; } = new List<WbsActivity2>();
}
