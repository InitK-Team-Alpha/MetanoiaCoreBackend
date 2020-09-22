using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetanoiaCoreAPI.AppUser
{
    public class UserPsychologyEffects
    {
        public int ID { get; set; }



        public bool SleepProblem { get; set; }

        public bool LossofAppetite { get; set; }

        public bool WeightLossORWeightGain { get; set; }

        public bool FocusProblem { get; set; }

        public bool AngerProblem { get; set; }

        public bool ConstantWorry { get; set; }

        public bool LonelinessORIsolation { get; set; }

        public bool FeelingOverWhelmed { get; set; }

        public bool Unhappiness { get; set; }

        public bool SuicidalThoughts { get; set; }

        public bool NoJoy { get; set; }

        public bool FeelingSadORDown { get; set; }

        public bool OveruseOfAlcholAndDrugs { get; set; }

        public bool WithdrawFromFriendsORActivities { get; set; }

        public bool SexDriveChange { get; set; }

        public bool MoodSwing { get; set; }

    }
    public class UserphychologyEffectsConfiguration : IEntityTypeConfiguration<UserPsychologyEffects>
    {
        public void Configure(EntityTypeBuilder<UserPsychologyEffects> builder)
        {
            builder.ToTable("userphychologyeffects");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.SleepProblem).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.LossofAppetite).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.WeightLossORWeightGain).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.FocusProblem).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.AngerProblem).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.ConstantWorry).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.LonelinessORIsolation).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.FeelingOverWhelmed).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Unhappiness).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.SuicidalThoughts).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.NoJoy).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.FeelingSadORDown).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.OveruseOfAlcholAndDrugs).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.WithdrawFromFriendsORActivities).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.SexDriveChange).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.MoodSwing).HasColumnType("varchar(50)").IsRequired();

        }
    }
}