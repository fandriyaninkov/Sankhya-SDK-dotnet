﻿namespace Sankhya.Enums;

using CrispyWaffle.Attributes;

/// <summary>
/// Enum FiscalInvoiceStatus
/// </summary>
public enum FiscalInvoiceStatus
{
    /// <summary>
    /// The sent
    /// </summary>
    [InternalValue("I")]
    [HumanReadable("Enviada")]
    Sent,

    /// <summary>
    /// The denied
    /// </summary>
    [InternalValue("D")]
    [HumanReadable("Denegada")]
    Denied,

    /// <summary>
    /// The approved
    /// </summary>
    [InternalValue("A")]
    [HumanReadable("Aprovada")]
    Approved,

    /// <summary>
    /// The waiting authorization
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Aguardando autorização")]
    WaitingAuthorization,

    /// <summary>
    /// The waiting correction
    /// </summary>
    [InternalValue("R")]
    [HumanReadable("Aguardando correção")]
    WaitingCorrection,

    /// <summary>
    /// The validation error
    /// </summary>
    [InternalValue("V")]
    [HumanReadable("Com erro de validação")]
    ValidationError,

    /// <summary>
    /// The pending return
    /// </summary>
    [InternalValue("P")]
    [HumanReadable("Pendente de retorno")]
    PendingReturn,

    /// <summary>
    /// The sent dpec
    /// </summary>
    [InternalValue("S")]
    [HumanReadable("Enviada DPEC")]
    SentDpec,

    /// <summary>
    /// The not nfe
    /// </summary>
    [InternalValue("M")]
    [HumanReadable("Não é NF-e")]
    NotNfe,

    /// <summary>
    /// The not nfse
    /// </summary>
    [InternalValue("M")]
    [HumanReadable("Não é NFS-e")]
    NotNfse,

    /// <summary>
    /// The nfe third
    /// </summary>
    [InternalValue("T")]
    [HumanReadable("NF-e terceiro")]
    NfeThird
}