using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Preference
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string Id { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public string? OwnedById { get; set; }

    public string? ManagedById { get; set; }

    public string? ModifiedById { get; set; }

    public string? State { get; set; }

    public string? CurrentState { get; set; }

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

    public string IdentityId { get; set; } = null!;

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<CmfContenttypegridlayout> CmfContenttypegridlayouts { get; set; } = new List<CmfContenttypegridlayout>();

    public virtual ICollection<CoreGloballayout> CoreGloballayouts { get; set; } = new List<CoreGloballayout>();

    public virtual ICollection<CoreItemgridlayout> CoreItemgridlayouts { get; set; } = new List<CoreItemgridlayout>();

    public virtual ICollection<CoreRelgridlayout> CoreRelgridlayouts { get; set; } = new List<CoreRelgridlayout>();

    public virtual ICollection<PeMainpreference> PeMainpreferences { get; set; } = new List<PeMainpreference>();

    public virtual ICollection<PmProjectcolormap> PmProjectcolormaps { get; set; } = new List<PmProjectcolormap>();

    public virtual ICollection<PmProjectgridlayout> PmProjectgridlayouts { get; set; } = new List<PmProjectgridlayout>();

    public virtual ICollection<Selfservicereportsetting> Selfservicereportsettings { get; set; } = new List<Selfservicereportsetting>();

    public virtual ICollection<SsvcPreference> SsvcPreferences { get; set; } = new List<SsvcPreference>();
}
