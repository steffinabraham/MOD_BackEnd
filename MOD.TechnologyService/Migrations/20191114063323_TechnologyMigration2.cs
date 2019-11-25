using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.TechnologyService.Migrations
{
    public partial class TechnologyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "SkillId",
                keyValue: 1233456L);

            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "SkillId",
                keyValue: 123987675L);

            migrationBuilder.InsertData(
                table: "Technology",
                columns: new[] { "SkillId", "Duration", "Fee", "SkillName", "TOC" },
                values: new object[] { 12L, 2, 47890.0, "C++", "iiiii" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technology",
                keyColumn: "SkillId",
                keyValue: 12L);

            migrationBuilder.InsertData(
                table: "Technology",
                columns: new[] { "SkillId", "Duration", "Fee", "SkillName", "TOC" },
                values: new object[] { 1233456L, 6, 40000.0, "C++", "iiiiiiiii" });

            migrationBuilder.InsertData(
                table: "Technology",
                columns: new[] { "SkillId", "Duration", "Fee", "SkillName", "TOC" },
                values: new object[] { 123987675L, 4, 40000.0, "Java", "iiiidffdi" });
        }
    }
}
