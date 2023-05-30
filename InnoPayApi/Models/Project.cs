using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class Project
{
    public string? Classification { get; set; }

    public string? KeyedName { get; set; }

    public string Id { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string CreatedById { get; set; } = null!;

    public string? ManagedById { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedById { get; set; }

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

    public string? Comments { get; set; }

    public DateTime? DateDueAct { get; set; }

    public DateTime? DateDueSched { get; set; }

    public DateTime? DateDueTarget { get; set; }

    public DateTime? DateStartAct { get; set; }

    public DateTime? DateStartSched { get; set; }

    public DateTime? DateStartTarget { get; set; }

    public string? Description { get; set; }

    public string? FromProjectId { get; set; }

    public string? FromTemplate { get; set; }

    public string? Goals { get; set; }

    public string? Name { get; set; }

    public int? PercentCompl1 { get; set; }

    public int? PercentCompl10 { get; set; }

    public int? PercentCompl11 { get; set; }

    public int? PercentCompl12 { get; set; }

    public int? PercentCompl2 { get; set; }

    public int? PercentCompl3 { get; set; }

    public int? PercentCompl4 { get; set; }

    public int? PercentCompl5 { get; set; }

    public int? PercentCompl6 { get; set; }

    public int? PercentCompl7 { get; set; }

    public int? PercentCompl8 { get; set; }

    public int? PercentCompl9 { get; set; }

    public string ProjectUpdateMode { get; set; } = null!;

    public int? RollupPercentCompl { get; set; }

    public string SchedulingMethod { get; set; } = null!;

    public string SchedulingMode { get; set; } = null!;

    public string? SchedulingType { get; set; }

    public string? Status1 { get; set; }

    public string? Status10 { get; set; }

    public string? Status11 { get; set; }

    public string? Status12 { get; set; }

    public string? Status2 { get; set; }

    public string? Status3 { get; set; }

    public string? Status4 { get; set; }

    public string? Status5 { get; set; }

    public string? Status6 { get; set; }

    public string? Status7 { get; set; }

    public string? Status8 { get; set; }

    public string? Status9 { get; set; }

    public string UpdateMethod { get; set; } = null!;

    public int? ProjectNumber { get; set; }

    public string? OwnedById { get; set; }

    public string? State { get; set; }

    public string? WbsId { get; set; }

    public virtual ICollection<ProgramProject> ProgramProjects { get; set; } = new List<ProgramProject>();

    public virtual ICollection<ProjectDoc> ProjectDocs { get; set; } = new List<ProjectDoc>();

    public virtual ICollection<ProjectPart> ProjectParts { get; set; } = new List<ProjectPart>();

    public virtual ICollection<ProjectTeam> ProjectTeams { get; set; } = new List<ProjectTeam>();

    public virtual ICollection<ProjectTree> ProjectTrees { get; set; } = new List<ProjectTree>();
}
