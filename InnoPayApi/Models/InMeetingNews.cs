using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class InMeetingNews
{
    public string Id { get; set; } = null!;

    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

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

    public string? InAnsL3 { get; set; }

    public string? InCancelById { get; set; }

    public string? InCancelMemo { get; set; }

    public string? InCancelStatus { get; set; }

    public DateTime? InCancelTime { get; set; }

    public string? InCompany { get; set; }

    public string? InCreator { get; set; }

    public string? InCreatorSno { get; set; }

    public string? InIndex { get; set; }

    public string? InL1 { get; set; }

    public string? InL2 { get; set; }

    public string? InL3 { get; set; }

    public string? InMuid { get; set; }

    public string? InName { get; set; }

    public string? InNewLevels { get; set; }

    public string? InOldSections { get; set; }

    public double? InPayAmount { get; set; }

    public double? InRefundAmount { get; set; }

    public DateTime? InRegdate { get; set; }

    public string? InSectionName { get; set; }

    public string? InSno { get; set; }

    public string? InTeamIndex { get; set; }

    public string? InVerifyById { get; set; }

    public string? InVerifyMemo { get; set; }

    public DateTime? InVerifyTime { get; set; }

    public string? RelatedId { get; set; }

    public string? SourceType { get; set; }
}
