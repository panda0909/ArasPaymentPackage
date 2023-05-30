using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class PartSubmissionWarrant
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

    public string? AddEngChanges { get; set; }

    public string? Application { get; set; }

    public string? Buyer { get; set; }

    public string? CaChangeLevel { get; set; }

    public DateTime? CaDate { get; set; }

    public string? CheckingAidNumber { get; set; }

    public string? CompanyInfo { get; set; }

    public string? CustomerName { get; set; }

    public string? DiscrepancySubmission { get; set; }

    public string? DwgNumber { get; set; }

    public string? EcnSubmission { get; set; }

    public DateTime? EngChangeDate { get; set; }

    public string? EngChangeLevel { get; set; }

    public string? IfOther { get; set; }

    public string? InitialSubmission { get; set; }

    public string? LocationChange { get; set; }

    public string? MaterialChange { get; set; }

    public string? MfgLocation { get; set; }

    public string? OtherChange { get; set; }

    public string? PartName { get; set; }

    public string? PartNumber { get; set; }

    public string? PartProcessing { get; set; }

    public string? PlasticPartsIso { get; set; }

    public string? PoNumber { get; set; }

    public string? PswNumber { get; set; }

    public string? ResponsibleOfficial { get; set; }

    public string? RestrictedSubstances { get; set; }

    public string? ResultsAppearance { get; set; }

    public string? ResultsComments { get; set; }

    public string? ResultsDimensional { get; set; }

    public string? ResultsFunctional { get; set; }

    public string? ResultsSpecs { get; set; }

    public string? ResultsStatistical { get; set; }

    public string? SafetyReqItem { get; set; }

    public string? SubAppearance { get; set; }

    public string? SubDimensional { get; set; }

    public string? SubMaterials { get; set; }

    public string? SubmissionLevel { get; set; }

    public string? SupplierChange { get; set; }

    public string? ToolingInactiveSubmission { get; set; }

    public string? ToolingSubmission { get; set; }

    public double? Weight { get; set; }

    public virtual ICollection<PartPsw> PartPsws { get; set; } = new List<PartPsw>();

    public virtual ICollection<PpapPackage> PpapPackages { get; set; } = new List<PpapPackage>();
}
