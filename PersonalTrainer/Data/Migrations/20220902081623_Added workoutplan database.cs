using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalTrainer.Data.Migrations
{
    public partial class Addedworkoutplandatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workoutPlans",
                columns: table => new
                {
                    WorkoutPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InquiryId = table.Column<int>(type: "int", nullable: false),
                    TrainderId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeekOf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exercise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Set = table.Column<int>(type: "int", nullable: false),
                    Rep = table.Column<int>(type: "int", nullable: false),
                    RepUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workoutPlans", x => x.WorkoutPlanId);
                    table.ForeignKey(
                        name: "FK_workoutPlans_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_workoutPlans_Inquiries_InquiryId",
                        column: x => x.InquiryId,
                        principalTable: "Inquiries",
                        principalColumn: "InquiryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_workoutPlans_Trainers_TrainderId",
                        column: x => x.TrainderId,
                        principalTable: "Trainers",
                        principalColumn: "TrainerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_workoutPlans_Id",
                table: "workoutPlans",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_workoutPlans_InquiryId",
                table: "workoutPlans",
                column: "InquiryId");

            migrationBuilder.CreateIndex(
                name: "IX_workoutPlans_TrainderId",
                table: "workoutPlans",
                column: "TrainderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workoutPlans");
        }
    }
}
