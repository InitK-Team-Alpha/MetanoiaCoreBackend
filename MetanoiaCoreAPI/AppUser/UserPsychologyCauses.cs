using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetanoiaCoreAPI.AppUser

{

    public class UserPsychologyCauses
    {
        public int ID { get; set; }

        public bool RelationshipProblem { get; set; }

        public bool FamilyConflict { get; set; }

        public bool LossingSomeone { get; set; }

        public bool Rape { get; set; }

        public bool SexualAbuse { get; set; }

        public bool WorkProblem { get; set; }

        public bool ClingtoSomething { get; set; }



    }
    public class UserPsychologyCausesConfiguration : IEntityTypeConfiguration<UserPsychologyCauses>
    {
        public void Configure(EntityTypeBuilder<UserPsychologyCauses> builder)
        {
            builder.ToTable("userpsychologycauses");

            builder.HasKey(p => p.ID);
            builder.Property(p => p.RelationshipProblem).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.FamilyConflict).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.LossingSomeone).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Rape).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.SexualAbuse).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.WorkProblem).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.ClingtoSomething).HasColumnType("varchar(50)").IsRequired();

        }
    }




}