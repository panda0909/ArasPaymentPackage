using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Spfield
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

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

    public string? PropertyHidden { get; set; }

    public string? PropertyHidden2 { get; set; }

    public int? PropertyKeyedOrder { get; set; }

    public string? PropertyLabel { get; set; }

    public int? PropertyLength { get; set; }

    public string? PropertyName { get; set; }

    public string? PropertyType { get; set; }

    public string? SpFieldName { get; set; }

    public string? SpFieldType { get; set; }

    public string? SpGuid { get; set; }

    public string? RelatedId { get; set; }

    public virtual Spdocumentlibrarydefinition? Source { get; set; }
}
