using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTemplate.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    SeqId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DeleteUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteFlag = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.SeqId);
                });

            migrationBuilder.CreateTable(
                name: "RoleType",
                columns: table => new
                {
                    SeqId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowguid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DeleteUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteFlag = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleType", x => x.SeqId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    SeqId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowguid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateUser = table.Column<string>(maxLength: 100, nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteDate = table.Column<DateTime>(nullable: true),
                    DeleteUser = table.Column<string>(maxLength: 100, nullable: true),
                    DeleteFlag = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.SeqId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "RoleType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
