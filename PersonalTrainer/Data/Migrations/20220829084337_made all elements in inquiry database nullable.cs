using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalTrainer.Data.Migrations
{
    public partial class madeallelementsininquirydatabasenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquiry_AspNetUsers_Id",
                table: "Inquiry");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquiry_Trainers_TrainerId",
                table: "Inquiry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inquiry",
                table: "Inquiry");

            migrationBuilder.RenameTable(
                name: "Inquiry",
                newName: "Inquiries");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiry_TrainerId",
                table: "Inquiries",
                newName: "IX_Inquiries_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiry_Id",
                table: "Inquiries",
                newName: "IX_Inquiries_Id");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Inquiries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Inquiries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Inquiries",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inquiries",
                table: "Inquiries",
                column: "InquiryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_AspNetUsers_Id",
                table: "Inquiries",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_Trainers_TrainerId",
                table: "Inquiries",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_AspNetUsers_Id",
                table: "Inquiries");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_Trainers_TrainerId",
                table: "Inquiries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inquiries",
                table: "Inquiries");

            migrationBuilder.RenameTable(
                name: "Inquiries",
                newName: "Inquiry");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiries_TrainerId",
                table: "Inquiry",
                newName: "IX_Inquiry_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Inquiries_Id",
                table: "Inquiry",
                newName: "IX_Inquiry_Id");

            migrationBuilder.AlterColumn<int>(
                name: "TrainerId",
                table: "Inquiry",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Inquiry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Inquiry",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inquiry",
                table: "Inquiry",
                column: "InquiryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiry_AspNetUsers_Id",
                table: "Inquiry",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiry_Trainers_TrainerId",
                table: "Inquiry",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "TrainerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
