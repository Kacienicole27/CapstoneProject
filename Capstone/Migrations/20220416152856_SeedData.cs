using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CapstoneProject.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "CategoryId", "CategoryName", "Description" },
            values: new object[,]
            {
                {1, "Art", "Drawings and Paintings" },
                {2, "Design", "Logos, Branding, and Advertisments"},
                {3, "Programs", "Software and Websites"}
            });
            
            
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] {"ProjectId", "Name", "ShortDescription", "LongDescription", "Price", "ImageUrl", "ImageThumbnailUrl", "IsProjectOfTheWeek", "InStock", "CategoryId", "Notes"},
                values:
                new object[,]
                {
                    { 1, "Painting", "Oil on Canvas", "Study of Lilies: Circle 14", 140.00m, "https://i.imgur.com/XtfCnoB.jpg", "https://i.imgur.com/XtfCnoB.jpg", true, true, 1, "Notes" },
                    { 2, "Drawing", "Risograph", "Witch Songs Series: Water and Earth", 80.00m, "https://i.imgur.com/yGbrMKw.jpg", "https://i.imgur.com/yGbrMKw.jpg", false, true, 1, "Notes" },
                    { 3, "Logo", "Trace Education", "Logo proposals", 0.00m, "https://i.imgur.com/pvsduPq.jpg", "https://i.imgur.com/pvsduPq.jpg", true, false, 2, "Notes" },
                    { 4, "Program", "Splendid", "Responsive front end design", 0.00m, "https://i.imgur.com/xL3MBW1.jpg", "https://i.imgur.com/xL3MBW1.jpg", true, false, 3, "Notes" },
                    { 5, "Branding", "Branding Example", "Lorem ipsum dolor sit amet", 0.00m, "https://i.imgur.com/PhQeCKS.jpg", "https://i.imgur.com/PhQeCKS.jpg", false, false, 2, "Notes" },
                    { 6, "Website", "Website Template 1", "Euismod tincidunt ut laoreet", 120.00m, "https://i.imgur.com/csL0oLF.jpg", "https://i.imgur.com/csL0oLF.jpg", false, false, 3, "Notes" },
                    { 7, "Advertisment", "Advertising Example", "Consectetuer adipiscing eli", 0.00m, "https://i.imgur.com/EvDqCho.jpg", "https://i.imgur.com/EvDqCho.jpg", false, false, 2, "Notes" },
                    { 8, "Painting", "Painting Example", "Lorem ipsum dolor sit", 110.00m, "https://i.imgur.com/CghNTh7.jpg", "https://i.imgur.com/CghNTh7.jpg", false, true, 1, "Notes" },
                    { 9, "Program", "Program Example", "Euismod tincidunt ut", 0.00m, "https://i.imgur.com/PhQeCKS.jpg", "https://i.imgur.com/PhQeCKS.jpg", false, false, 3, "Notes" },
                    { 10, "Website", "Website Template 2", "Consectetuer adipiscing eli laoreet", 120.00m, "https://i.imgur.com/csL0oLF.jpg", "https://i.imgur.com/csL0oLF.jpg", false, false, 3, "Notes" },
                    { 11, "Logo", "Logo Example", "Tincidunt ut laoreet amet", 0.00m, "https://i.imgur.com/EvDqCho.jpg", "https://i.imgur.com/EvDqCho.jpg", false, false, 2, "Notes" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 1);
            
            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 2);
            
            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 3);
            
            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 4);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 5);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 6);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 7);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 8);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 9);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 10);

            migrationBuilder.DeleteData(
            table: "Projects",
            keyColumn: "ProjectId",
            keyValue: 11);

            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1);
            
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 2);
            
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 3);
        }
    }
}
