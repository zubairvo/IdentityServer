using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.AspNetIdentity.AspNetIdentityDb
{
    public partial class SeedIdentityDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d590575-c5a9-47bb-a291-7914ca163bf1", "AQAAAAEAACcQAAAAEHo9h7r1fTkzKyk+fKfnC05AG4hTdg9KXq71NXPGsJ3jH4YSDyI9wn7cuHTl+76A7Q==", "0b95d02b-304f-4b19-b20c-e4760b2937c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f037dfa8-1afa-4d9d-a7ab-dd85da46951e", "AQAAAAEAACcQAAAAEFQLl5sDMC7Wh3ypZ7iZCS+gnA7hm3T0tWED+NJXEhkY8+eWmxiFbkU3USOzKqHlcg==", "1318607a-abe4-44c5-88f4-33c989193387" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d953e31-9eab-44c5-8fe3-1eb9743409ef", "AQAAAAEAACcQAAAAEHoxJM0GwasIH9jXZq34UWomWyiz+BmKYGHNxxxLbBuIxLhPUznHHyKrQF++r46C7g==", "b6766c47-fc45-412f-bd4b-4632036d903f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c60f58d5-4198-44c8-8bea-bd49de5aec70", "AQAAAAEAACcQAAAAEPjeCF2FhUqYotrsRJ6OVlJf2fxoZLjGcJt3u/7qJtPo1g2m90hmGmF/n0m19fAdHg==", "40b421ed-cbd7-460c-a970-2cfbc05e3c0c" });
        }
    }
}
