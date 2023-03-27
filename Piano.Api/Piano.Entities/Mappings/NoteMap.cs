﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Piano.Entities.Mappings;

public class NoteMap : IEntityTypeConfiguration<Note>
{
    public void Configure(EntityTypeBuilder<Note> builder)
    {
        builder.ToTable("Notes");
        builder.HasKey(n => n.Id);

        builder.HasOne(n => n.Student)
               .WithMany(s => s.Notes)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("StudentId");
        builder.HasOne(n => n.Mentor)
               .WithMany()
               .HasForeignKey("MentorId");
        builder.Property(n => n.SessionTopic)
               .HasColumnName("SessionTopic");
        builder.Property(n => n.Text)
               .HasColumnName("Text");
        builder.HasMany(n => n.Links)
               .WithOne(l => l.Note)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("NoteId");
        builder.HasMany(n => n.Attachments)
               .WithOne(a => a.Note)
               .OnDelete(DeleteBehavior.Cascade)
               .HasForeignKey("NoteId");
    }
}