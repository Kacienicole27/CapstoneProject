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
                    { 1, "Painting", "Painting Description", "Painting Description", 15.95m, "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", true, true, 1, "Notes" },
                    { 2, "Drawing", "Drawing Description", "Drawing Description", 15.95m, "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", true, true, 1, "Notes" },
                    { 3, "Logo", "Logo Description", "Logo Description", 15.95m, "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", true, true, 2, "Notes" },
                    { 4, "Program", "Program Description", "Program Description", 15.95m, "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", "https://t4.ftcdn.net/jpg/00/53/45/31/360_F_53453175_hVgYVz0WmvOXPd9CNzaUcwcibiGao3CL.jpg", true, true, 2, "Notes" }
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
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1);
            
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1);
            
            migrationBuilder.DeleteData(
            table: "Categories",
            keyColumn: "CategoryId",
            keyValue: 1);
        }
    }
}
