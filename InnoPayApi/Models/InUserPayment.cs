using InnoPayApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace InnoPayApi.Models;

public partial class InUserPayment
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

    public string? TeamId { get; set; }

    public DateTime? InAddTime { get; set; }

    public string? InSourceId { get; set; }

    public string? InCode1 { get; set; }

    public string? InCode2 { get; set; }

    public string? InCode3 { get; set; }

    public string? InCollectionAgency { get; set; }

    public DateTime? InCollectionDate { get; set; }

    public string? InCompany { get; set; }

    public string? InCreator { get; set; }

    public string? InCreatorSno { get; set; }

    public DateTime? InCreditDate { get; set; }

    public string? InCurrentOrg { get; set; }

    public decimal? IndexNumber { get; set; }

    public string? InvoiceUp { get; set; }

    public string? InEdi0 { get; set; }

    public string? InEdi1 { get; set; }

    public double? InFeeAmount { get; set; }

    public string? InGroup { get; set; }

    public string? InMeetingVirtual { get; set; }

    public double? InPayAmountExp { get; set; }

    public double? InPayAmountReal { get; set; }

    public DateTime? InPayDateExp { get; set; }

    public DateTime? InPayDateExp1 { get; set; }

    public DateTime? InPayDateReal { get; set; }

    public string? InPayPhoto { get; set; }

    public string? InRealItems { get; set; }

    public double? InRefundAmount { get; set; }

    public string? InReturnMark { get; set; }

    public string? InWriteNote { get; set; }

    public string? ItemNumber { get; set; }

    public string? MoneyTransfer1 { get; set; }

    public string? MoneyTransfer2 { get; set; }

    public string? MoneyTransfer3 { get; set; }

    public string? MoneyTransfer4 { get; set; }

    public string? MoneyTransfer5 { get; set; }

    public string? MoneyTransfer6 { get; set; }

    public string? MoneyTransfer7 { get; set; }

    public string? MoneyTransfer8 { get; set; }

    public string? MoneyTransfer9 { get; set; }

    public string? MoneyTransfer10 { get; set; }

    public string? PayBool { get; set; }

    public string? RecNumber { get; set; }

    public string? UniformNumbers { get; set; }

    public int? InRealPlayer { get; set; }

    public virtual ICollection<InUserPaymentInvoice> InUserPaymentInvoices { get; set; } = new List<InUserPaymentInvoice>();

    public virtual ICollection<InUserPaymentItem> InUserPaymentItems { get; set; } = new List<InUserPaymentItem>();
}
