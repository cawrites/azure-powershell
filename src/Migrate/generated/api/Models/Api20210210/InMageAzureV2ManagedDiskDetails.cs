namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMageAzureV2 Managed disk details.</summary>
    public partial class InMageAzureV2ManagedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ManagedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageAzureV2ManagedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="ReplicaDiskType" /> property.</summary>
        private string _replicaDiskType;

        /// <summary>The replica disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ReplicaDiskType { get => this._replicaDiskType; set => this._replicaDiskType = value; }

        /// <summary>Backing field for <see cref="SeedManagedDiskId" /> property.</summary>
        private string _seedManagedDiskId;

        /// <summary>Seed managed disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SeedManagedDiskId { get => this._seedManagedDiskId; set => this._seedManagedDiskId = value; }

        /// <summary>Creates an new <see cref="InMageAzureV2ManagedDiskDetails" /> instance.</summary>
        public InMageAzureV2ManagedDiskDetails()
        {

        }
    }
    /// InMageAzureV2 Managed disk details.
    public partial interface IInMageAzureV2ManagedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskEncryptionSet ARM ID.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The replica disk type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The replica disk type.",
        SerializedName = @"replicaDiskType",
        PossibleTypes = new [] { typeof(string) })]
        string ReplicaDiskType { get; set; }
        /// <summary>Seed managed disk Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Seed managed disk Id.",
        SerializedName = @"seedManagedDiskId",
        PossibleTypes = new [] { typeof(string) })]
        string SeedManagedDiskId { get; set; }

    }
    /// InMageAzureV2 Managed disk details.
    internal partial interface IInMageAzureV2ManagedDiskDetailsInternal

    {
        /// <summary>The DiskEncryptionSet ARM ID.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The disk id.</summary>
        string DiskId { get; set; }
        /// <summary>The replica disk type.</summary>
        string ReplicaDiskType { get; set; }
        /// <summary>Seed managed disk Id.</summary>
        string SeedManagedDiskId { get; set; }

    }
}