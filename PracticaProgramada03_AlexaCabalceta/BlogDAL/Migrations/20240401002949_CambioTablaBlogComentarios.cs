using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogDAL.Migrations
{
    /// <inheritdoc />
    public partial class CambioTablaBlogComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreUsuario",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCreacionId",
                table: "Comentarios",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCreacionId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioCreacionId",
                table: "Comentarios",
                column: "UsuarioCreacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UsuarioCreacionId",
                table: "Blogs",
                column: "UsuarioCreacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_UsuarioCreacionId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_AspNetUsers_UsuarioCreacionId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_UsuarioCreacionId",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UsuarioCreacionId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UsuarioCreacionId",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "UsuarioCreacionId",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "NombreUsuario",
                table: "Comentarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
