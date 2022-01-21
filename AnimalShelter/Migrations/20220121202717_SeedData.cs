using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Color", "Gender", "Location", "Name", "Type", "Weight" },
                values: new object[,]
                {
                    { 1, 4, "Scottish Fold", "Grey", "Male", "The Cattery", "Bart", "Cat", 7.0 },
                    { 2, 16, "Russian Blue", "Grey", "Male", "The Cattery", "Indy", "Cat", 8.3000000000000007 },
                    { 3, 8, "American Shorthair", "Black", "Male", "The Cattery", "Peeve", "Cat", 6.9000000000000004 },
                    { 4, 16, "American Shorthair", "Tabby", "Male", "The Cattery", "Buzz", "Cat", 7.7999999999999998 },
                    { 5, 9, "Maine Coon", "Orange and White", "Female", "The Cattery", "Lily", "Cat", 8.8000000000000007 },
                    { 6, 5, "Australian Cattle Dog Mix", "Black and White", "Male", "The Blue Room", "Pete", "Dog", 43.0 },
                    { 7, 6, "Hound", "Brown", "Male", "The Red Room", "Buster", "Dog", 55.700000000000003 },
                    { 8, 4, "Golden Retriever", "Brown", "Female", "The Red Room", "Amy", "Dog", 61.5 },
                    { 9, 3, "Australian Shepherd", "Black and White", "Female", "The Blue Room", "Lucy", "Dog", 38.700000000000003 },
                    { 10, 8, "Maltese", "White", "Female", "The Yellow Room", "Jazz", "Dog", 15.6 },
                    { 11, 9, "Pomperdoodle", "Black", "Female", "The Yellow Room", "Xena", "Dog", 14.800000000000001 },
                    { 12, 1, "Goldendoodle", "Brown", "Male", "The Red Room", "Oliver", "Dog", 23.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);
        }
    }
}
