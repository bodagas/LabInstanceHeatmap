namespace LabInstanceHeatmap
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LabInstance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LabInstance()
        {
            LabInstances1 = new HashSet<LabInstance>();
        }

        public long Id { get; set; }

        public Guid RegistrationKey { get; set; }

        public int LabProfileId { get; set; }

        public int LabHostId { get; set; }

        public DateTime OriginalStartTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime ExpirationTime { get; set; }

        public DateTime? LastSaveTime { get; set; }

        public DateTime? LaunchTime { get; set; }

        public int? StartupDurationSeconds { get; set; }

        public int StateId { get; set; }

        public int CompletionStatusId { get; set; }

        public long UserId { get; set; }

        public long? ClassId { get; set; }

        [StringLength(800)]
        public string ErrorDetails { get; set; }

        public bool IsEditMode { get; set; }

        public int VmScreenWidth { get; set; }

        public int VmScreenHeight { get; set; }

        public DateTime? LastActivityTime { get; set; }

        public int? CurrentTaskId { get; set; }

        public int? SelectedTaskId { get; set; }

        public int? SelectedMachineId { get; set; }

        public int SelectedNavigationTab { get; set; }

        public int LayoutId { get; set; }

        public int Theme { get; set; }

        public int? LegacyId { get; set; }

        public int LastSaveTriggerTypeId { get; set; }

        public int MaxSaveDays { get; set; }

        public int? PoolMemberId { get; set; }

        public bool InstructorFileChangePending { get; set; }

        [StringLength(4000)]
        public string VirtualMachineDataJson { get; set; }

        public DateTime? LastConsoleSyncTime { get; set; }

        public int RemoteControllerTypeId { get; set; }

        public bool NavigationBarPinned { get; set; }

        public bool TaskBarPinned { get; set; }

        public bool TitleBarPinned { get; set; }

        public int? FileShareId { get; set; }

        public long? StorageUsed { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        public int? ApiConsumerId { get; set; }

        public bool CanBeMarkedComplete { get; set; }

        public int? ExamScore { get; set; }

        public bool? ExamPassed { get; set; }

        public int? EventId { get; set; }

        public int NavigationBarWidth { get; set; }

        public int TaskBarHeight { get; set; }

        public DateTime? PreinstanceStartTime { get; set; }

        public int ExternalEvalSyncStatus { get; set; }

        [StringLength(300)]
        public string ExternalEvalSyncError { get; set; }

        public int ExternalAttendanceSyncStatus { get; set; }

        [StringLength(300)]
        public string ExternalAttendanceSyncError { get; set; }

        [StringLength(512)]
        public string BrowserUserAgent { get; set; }

        public int? SelectedSideBySideResourceId { get; set; }

        public int? LastLatency { get; set; }

        public int? SelectedContentResourceId { get; set; }

        public long? InstanceSubscriptionId { get; set; }

        [StringLength(4000)]
        public string ExamNotes { get; set; }

        public int? ExamMaxPossibleScore { get; set; }

        public int? ExamPassingScore { get; set; }

        public DateTime? ExamScoredTime { get; set; }

        public long? ExamScoredById { get; set; }

        [StringLength(100)]
        public string ExamScoredByName { get; set; }

        public int TotalRunTimeSeconds { get; set; }

        public int? NumTasksComplete { get; set; }

        public int? PercentTasksComplete { get; set; }

        [StringLength(256)]
        public string LtiOutcomeServiceUrl { get; set; }

        [StringLength(256)]
        public string LtiResultSourcedId { get; set; }

        public int LtiOutcomeSyncStatus { get; set; }

        [StringLength(800)]
        public string LtiOutcomeSyncMessage { get; set; }

        public int? AverageLatency { get; set; }

        public bool PublicIpAddressesAssigned { get; set; }

        public int ExperienceLevel { get; set; }

        public long? SharedClassEnvironmentId { get; set; }

        public DateTime? LastStateChange { get; set; }

        public int? RamReservation { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(64)]
        public string Country { get; set; }

        [StringLength(128)]
        public string City { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LabInstance> LabInstances1 { get; set; }

        public virtual LabInstance LabInstance1 { get; set; }
    }
}
