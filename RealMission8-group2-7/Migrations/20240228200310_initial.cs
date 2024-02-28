﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealMission8_group2_7.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    task = table.Column<string>(type: "TEXT", nullable: false),
                    duedate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    quadrant = table.Column<string>(type: "TEXT", nullable: false),
                    category = table.Column<int>(type: "INTEGER", nullable: true),
                    completed = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
