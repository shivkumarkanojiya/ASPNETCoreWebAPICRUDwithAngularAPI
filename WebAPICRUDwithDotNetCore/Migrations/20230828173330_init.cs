﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPICRUDwithDotNetCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblDesignation",
                columns: table => new
                {
                    DesignationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDesignation", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "TblEmployee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Doj = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(maxLength: 20, nullable: true),
                    IsMarried = table.Column<int>(nullable: false),
                    IsActive = table.Column<int>(nullable: false),
                    DesignationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblEmployee", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDesignation");

            migrationBuilder.DropTable(
                name: "TblEmployee");
        }
    }
}
