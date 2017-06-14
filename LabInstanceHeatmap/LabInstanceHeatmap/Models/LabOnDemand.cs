namespace LabInstanceHeatmap
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LabOnDemand : DbContext
    {
        public LabOnDemand()
            : base("name=LabOnDemand")
        {
        }

        public virtual DbSet<LabInstance> LabInstances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LabInstance>()
                .Property(e => e.LtiOutcomeSyncMessage)
                .IsUnicode(false);

            modelBuilder.Entity<LabInstance>()
                .HasMany(e => e.LabInstances1)
                .WithOptional(e => e.LabInstance1)
                .HasForeignKey(e => e.SharedClassEnvironmentId);
        }
    }
}
