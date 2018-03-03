 namespace Insurance.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Domaine.Entity;



    public partial class EntityContext : DbContext
    {
        public EntityContext()
            : base("name=EntityContext")
        {
        }

        public virtual DbSet<address> address { get; set; }
        public virtual DbSet<agent> agent { get; set; }
        public virtual DbSet<attt> attt { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<contact> contact { get; set; }
        public virtual DbSet<demande> demande { get; set; }
        public virtual DbSet<evenement> evenement { get; set; }
        public virtual DbSet<favoris> favoris { get; set; }
        public virtual DbSet<filtrage> filtrage { get; set; }
        public virtual DbSet<insurance> insurance { get; set; }
        public virtual DbSet<insurancecompany> insurancecompany { get; set; }
        public virtual DbSet<insuranceproduct> insuranceproduct { get; set; }
        public virtual DbSet<insured> insured { get; set; }
        public virtual DbSet<likes> likes { get; set; }
        public virtual DbSet<messages> messages { get; set; }
        public virtual DbSet<participate> participate { get; set; }
        public virtual DbSet<police> police { get; set; }
        public virtual DbSet<reclamation> reclamation { get; set; }
        public virtual DbSet<reponse> reponse { get; set; }
        public virtual DbSet<souscategory> souscategory { get; set; }
        public virtual DbSet<topic> topic { get; set; }
        public virtual DbSet<typecontract> typecontract { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<vehicle> vehicle { get; set; }
        public virtual DbSet<vehicleattt> vehicleattt { get; set; }
        public virtual DbSet<vehicleswreck> vehicleswreck { get; set; }
        public virtual DbSet<sinister> sinister { get; set; }
        public virtual DbSet<report> report { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<address>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<address>()
                .HasMany(e => e.insurance)
                .WithOptional(e => e.address)
                .HasForeignKey(e => e.addresse_id);

            modelBuilder.Entity<agent>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<agent>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<attt>()
                .Property(e => e.matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .Property(e => e.NameCategory)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.website)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.telephone)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.color)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.etat)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.horsePower)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.newMark)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.newMatriculation)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.oldMark)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.oldMatriculation)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<demande>()
                .Property(e => e.vehicle_Matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.Localisation)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .HasMany(e => e.participate)
                .WithRequired(e => e.evenement)
                .HasForeignKey(e => e.idevent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<filtrage>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<insurance>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<insurance>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<insurance>()
                .Property(e => e.nameInsurance)
                .IsUnicode(false);

            modelBuilder.Entity<insurance>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<insurance>()
                .HasMany(e => e.insuranceproduct1)
                .WithOptional(e => e.insurance1)
                .HasForeignKey(e => e.id_In);

            modelBuilder.Entity<insurance>()
                .HasMany(e => e.reclamation)
                .WithOptional(e => e.insurance)
                .HasForeignKey(e => e.insurance_id);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.motDepasse)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.pays)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.slogan)
                .IsUnicode(false);

            modelBuilder.Entity<insurancecompany>()
                .Property(e => e.ville)
                .IsUnicode(false);

            modelBuilder.Entity<insuranceproduct>()
                .Property(e => e.deal)
                .IsUnicode(false);

            modelBuilder.Entity<insuranceproduct>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<insuranceproduct>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<insuranceproduct>()
                .HasMany(e => e.insurance)
                .WithOptional(e => e.insuranceproduct)
                .HasForeignKey(e => e.id_Pro);

            modelBuilder.Entity<insured>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<insured>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<messages>()
                .HasMany(e => e.likes)
                .WithRequired(e => e.messages)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<police>()
                .Property(e => e.vehicle_Matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<reclamation>()
                .Property(e => e.titre)
                .IsUnicode(false);

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
                .HasMany(e => e.favoris)
                .WithRequired(e => e.topic)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<typecontract>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<typecontract>()
                .HasMany(e => e.police)
                .WithOptional(e => e.typecontract)
                .HasForeignKey(e => e.typeContrat_IdTypeContrat);

            modelBuilder.Entity<users>()
                .Property(e => e.adress)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.demande)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.users_id);

            modelBuilder.Entity<users>()
                .HasMany(e => e.favoris)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.iduser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.likes)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.iduser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.messages)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idPosteur);

            modelBuilder.Entity<users>()
                .HasMany(e => e.participate)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.iduser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.police)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.insured_id);

            modelBuilder.Entity<users>()
                .HasMany(e => e.reponse)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idUser);

            modelBuilder.Entity<users>()
                .HasMany(e => e.souscategory)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idUser);

            modelBuilder.Entity<users>()
                .HasMany(e => e.topic)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idCreateur);

            modelBuilder.Entity<users>()
                .HasMany(e => e.vehicle)
                .WithOptional(e => e.users)
                .HasForeignKey(e => e.idInsured);

            modelBuilder.Entity<users>()
                .HasMany(e => e.evenement)
                .WithMany(e => e.users)
                .Map(m => m.ToTable("evenement_users").MapLeftKey("user_id").MapRightKey("events_id"));

            modelBuilder.Entity<vehicle>()
                .Property(e => e.Matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.Color)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.HorsePower)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<vehicle>()
                .HasMany(e => e.demande)
                .WithOptional(e => e.vehicle)
                .HasForeignKey(e => e.vehicle_Matriculation);

            modelBuilder.Entity<vehicle>()
                .HasMany(e => e.police)
                .WithOptional(e => e.vehicle)
                .HasForeignKey(e => e.vehicle_Matriculation);

            modelBuilder.Entity<vehicleattt>()
                .Property(e => e.Matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<vehicleattt>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<vehicleswreck>()
                .Property(e => e.Matriculation)
                .IsUnicode(false);

            modelBuilder.Entity<vehicleswreck>()
                .Property(e => e.Mark)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.dateCreation)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.latitude)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.longitude)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.nameFirstname)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.nameInsurancCompany)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.policyNum)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<sinister>()
                .Property(e => e.urlImage)
                .IsUnicode(false);

            modelBuilder.Entity<report>()
              .Property(e => e.description)
              .IsUnicode(false);
        }
    }
}