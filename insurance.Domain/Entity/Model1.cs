namespace insurance.Domain.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model14")
        {
        }

        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<filtrage> filtrage { get; set; }
        public virtual DbSet<messages> messages { get; set; }
        public virtual DbSet<reponse> reponse { get; set; }
        public virtual DbSet<souscategory> souscategory { get; set; }
        public virtual DbSet<topic> topic { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.NameCategory)
                .IsUnicode(false);

            modelBuilder.Entity<filtrage>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .HasMany(e => e.user1)
                .WithMany(e => e.messages1)
                .Map(m => m.ToTable("likes", "insurance").MapLeftKey("idMessage").MapRightKey("idUser"));

            modelBuilder.Entity<reponse>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<souscategory>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<topic>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<topic>()
                .Property(e => e.sujet)
                .IsUnicode(false);

            modelBuilder.Entity<topic>()
                .HasMany(e => e.user1)
                .WithMany(e => e.topic1)
                .Map(m => m.ToTable("favoris", "insurance").MapLeftKey("idTopic").MapRightKey("idUser"));

            modelBuilder.Entity<user>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.messages)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.idPosteur);

            modelBuilder.Entity<user>()
                .HasMany(e => e.reponse)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.souscategory)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.idUser);

            modelBuilder.Entity<user>()
                .HasMany(e => e.topic)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.idCreateur);
        }
    }
}
