using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    SourceUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkill",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkill", x => new { x.ProjectId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "Description", "Name", "SourceUrl" },
                values: new object[] { 1, "테스트설명..", "테스트", null });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Name" },
                values: new object[] { 1, "CSharp" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "SkillId", "Name" },
                values: new object[] { 2, "EntityFramework" });

            migrationBuilder.InsertData(
                table: "ProjectSkill",
                columns: new[] { "ProjectId", "SkillId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProjectSkill",
                columns: new[] { "ProjectId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkill_SkillId",
                table: "ProjectSkill",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectSkill");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Skill");
        }
    }
}
