using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CashMachine;

namespace CashMachine.Migrations
{
    [DbContext(typeof(EntitiesContext))]
    partial class EntitiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CashMachine.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Name");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("CashMachine.Model.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Balance");

                    b.Property<int>("ClientID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Number");

                    b.HasKey("ID");

                    b.HasAnnotation("Relational:DiscriminatorProperty", "Discriminator");

                    b.HasAnnotation("Relational:DiscriminatorValue", "Account");
                });

            modelBuilder.Entity("CashMachine.Model.CheckingAccount", b =>
                {
                    b.HasBaseType("CashMachine.Model.Account");


                    b.HasAnnotation("Relational:DiscriminatorValue", "CheckingAccount");
                });

            modelBuilder.Entity("CashMachine.Model.InvestimentAccount", b =>
                {
                    b.HasBaseType("CashMachine.Model.Account");


                    b.HasAnnotation("Relational:DiscriminatorValue", "InvestimentAccount");
                });

            modelBuilder.Entity("CashMachine.Model.SavingsAccount", b =>
                {
                    b.HasBaseType("CashMachine.Model.Account");


                    b.HasAnnotation("Relational:DiscriminatorValue", "SavingsAccount");
                });

            modelBuilder.Entity("CashMachine.Model.Account", b =>
                {
                    b.HasOne("CashMachine.Client")
                        .WithMany()
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("CashMachine.Model.CheckingAccount", b =>
                {
                });

            modelBuilder.Entity("CashMachine.Model.InvestimentAccount", b =>
                {
                });

            modelBuilder.Entity("CashMachine.Model.SavingsAccount", b =>
                {
                });
        }
    }
}
