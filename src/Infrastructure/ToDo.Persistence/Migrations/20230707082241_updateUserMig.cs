
#nullable disable

namespace ToDo.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateUserMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3752), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3757), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3805), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3816), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3870), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8152), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8183), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8214), new DateTime(2023, 7, 7, 1, 22, 40, 635, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5831), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5852), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Birthday", "CreateDate", "LastModify", "Password" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1775), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1779), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Birthday", "CreateDate", "LastModify", "Password" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1802), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1812), "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Birthday", "CreateDate", "LastModify", "Password" },
                values: new object[] { new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1844), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 7, 7, 1, 22, 40, 636, DateTimeKind.Local).AddTicks(1854), "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2547), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2595), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Plans",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreateDate", "LastModify", "Time" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2637), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2639), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9532), new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "1" },
                columns: new[] { "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9545), new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Birthday", "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7368), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7374), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Birthday", "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7389), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7392), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Birthday", "CreateDate", "LastModify" },
                values: new object[] { new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7405), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7408), new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7410) });
        }
    }
}
