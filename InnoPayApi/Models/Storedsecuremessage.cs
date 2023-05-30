﻿using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Storedsecuremessage
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

    public string? Behavior { get; set; }

    public int? SortOrder { get; set; }

    public string? TeamId { get; set; }

    public string? Comments { get; set; }

    public decimal? CreatedOnTick { get; set; }

    public DateTime? DisabledOn { get; set; }

    public string? DisabledById { get; set; }

    public string? HighlightedText { get; set; }

    public string ItemConfigId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string ItemKeyedName { get; set; } = null!;

    public string ItemMajorRev { get; set; } = null!;

    public string? ItemState { get; set; }

    public string ItemTypeId { get; set; } = null!;

    public string ItemTypeName { get; set; } = null!;

    public int ItemVersion { get; set; }

    public string? ReplyToId { get; set; }

    public string? SmData { get; set; }

    public string ThreadId { get; set; } = null!;

    public string? RelatedId { get; set; }

    public string? SourceId { get; set; }

    public virtual Board? Source { get; set; }
}
