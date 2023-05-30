using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class EsIndexqueue
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

    public string? IsReleased { get; set; }

    public string? MinorRev { get; set; }

    public string? NotLockable { get; set; }

    public string? Css { get; set; }

    public int? Generation { get; set; }

    public string? NewVersion { get; set; }

    public string ConfigId { get; set; } = null!;

    public string PermissionId { get; set; } = null!;

    public string? TeamId { get; set; }

    public string? IndexedId { get; set; }

    public DateTime? IndexedIndexedOn { get; set; }

    public DateTime? IndexedModifiedOn { get; set; }

    public string? IndexedType { get; set; }

    public DateTime? IndexingStartedOn { get; set; }

    public string? OperationType { get; set; }

    public string? RootId { get; set; }

    public string? RootType { get; set; }

    public string? Status { get; set; }
}
