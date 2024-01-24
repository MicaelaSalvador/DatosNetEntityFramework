using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentEntityFramework.Data.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
           builder.ToTable("Students");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(n => n.StudentName).IsRequired();
            builder.Property(n => n.StudentName).HasMaxLength(250);
            builder.Property(n => n.Address).IsRequired(false).HasMaxLength(500);
            builder.Property(n => n.Email).IsRequired().HasMaxLength(250);

            builder.HasData( new List<Student>()
            {
                 new Student
                {
                    Id = 1,
                    StudentName = "Venkat",
                    Address="India",
                    Email ="venkat@gmail.com",
                    DOB= new DateTime(2024,01,01)
                },
                 new Student
                {
                    Id = 2,
                    StudentName = "Nehanth",
                    Address="India",
                    Email ="nehanth@gmail.com",
                    DOB= new DateTime(2024,01,01)
                }

            });
       }
    }
}
