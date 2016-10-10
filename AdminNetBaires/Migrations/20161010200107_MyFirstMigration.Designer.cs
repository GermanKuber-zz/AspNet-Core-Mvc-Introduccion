using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AdminNetBaires.Context;

namespace AdminNetBaires.Migrations
{
    [DbContext(typeof(NetBairesContext))]
    [Migration("20161010200107_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("AdminNetBaires.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<TimeSpan>("End");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 5);

                    b.Property<TimeSpan>("Start");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calification");

                    b.Property<string>("Email");

                    b.Property<string>("ExternaId");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Relations.EventOrganizers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventId");

                    b.Property<int>("MemberId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("MemberId");

                    b.ToTable("EventOrganizers");
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Relations.MemberTalk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MemberId");

                    b.Property<int>("TalkId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("TalkId");

                    b.ToTable("MemberTalk");
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<TimeSpan>("End");

                    b.Property<int?>("EventId");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("Start");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Relations.EventOrganizers", b =>
                {
                    b.HasOne("AdminNetBaires.Entities.Event", "Event")
                        .WithMany("Organizers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdminNetBaires.Entities.Member", "Member")
                        .WithMany("Events")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Relations.MemberTalk", b =>
                {
                    b.HasOne("AdminNetBaires.Entities.Member", "Member")
                        .WithMany("Talks")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AdminNetBaires.Entities.Talk", "Talk")
                        .WithMany("Speakers")
                        .HasForeignKey("TalkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdminNetBaires.Entities.Talk", b =>
                {
                    b.HasOne("AdminNetBaires.Entities.Event")
                        .WithMany("Talks")
                        .HasForeignKey("EventId");
                });
        }
    }
}
