using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCreateBase.Migrations
{
    public partial class renommage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Enseignant");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Etudiant");

            migrationBuilder.RenameIndex(
                name: "IX_Students_TeacherId",
                table: "Etudiant",
                newName: "IX_Etudiant_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enseignant",
                table: "Enseignant",
                column: "TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Etudiant",
                table: "Etudiant",
                column: "Studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Etudiant_Enseignant_TeacherId",
                table: "Etudiant",
                column: "TeacherId",
                principalTable: "Enseignant",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Etudiant_Enseignant_TeacherId",
                table: "Etudiant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Etudiant",
                table: "Etudiant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enseignant",
                table: "Enseignant");

            migrationBuilder.RenameTable(
                name: "Etudiant",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Enseignant",
                newName: "Teachers");

            migrationBuilder.RenameIndex(
                name: "IX_Etudiant_TeacherId",
                table: "Students",
                newName: "IX_Students_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Studentid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
