// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ResearchWebApp.Data;

namespace ResearchWebApp.Migrations
{
    [DbContext(typeof(ResearchDBContext))]
    partial class ResearchDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.EditorialBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EditorialBoards");
                });

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("PaperID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaperID");

                    b.ToTable("Fees");
                });

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Authors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IssueNo")
                        .HasColumnType("int");

                    b.Property<string>("MonthName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaperID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaperID");

                    b.ToTable("Issues");
                });

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.Paper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ISSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Papers");
                });

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.Fee", b =>
                {
                    b.HasOne("ResearchWebApp.BusinessLayer.Paper", "Paper")
                        .WithMany()
                        .HasForeignKey("PaperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResearchWebApp.BusinessLayer.Issue", b =>
                {
                    b.HasOne("ResearchWebApp.BusinessLayer.Paper", "Paper")
                        .WithMany()
                        .HasForeignKey("PaperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
