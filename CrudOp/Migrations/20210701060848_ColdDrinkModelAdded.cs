﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudOp.Migrations
{
    public partial class ColdDrinkModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColdDrinks",
                columns: table => new
                {
                    intColdDrinksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strColdDrinksName = table.Column<string>(nullable: true),
                    numQuantity = table.Column<decimal>(nullable: false),
                    numUnitPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColdDrinks", x => x.intColdDrinksId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColdDrinks");
        }
    }
}
