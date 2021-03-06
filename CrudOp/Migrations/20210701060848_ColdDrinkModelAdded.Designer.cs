// <auto-generated />
using CrudOp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudOp.Migrations
{
    [DbContext(typeof(dbAkijFoodContext))]
    [Migration("20210701060848_ColdDrinkModelAdded")]
    partial class ColdDrinkModelAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrudOp.Models.ColdDrink", b =>
                {
                    b.Property<int>("intColdDrinksId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("numQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("numUnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("strColdDrinksName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("intColdDrinksId");

                    b.ToTable("ColdDrinks");
                });
#pragma warning restore 612, 618
        }
    }
}
