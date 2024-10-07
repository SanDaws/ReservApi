using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservApi.Migrations
{
    /// <inheritdoc />
    public partial class roomspoblation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_Rooms_room_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_room_types_room_type_id",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "rooms");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_room_type_id",
                table: "rooms",
                newName: "IX_rooms_room_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rooms",
                table: "rooms",
                column: "id");

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "avaliability", "max_occupancy_persons", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1u, true, (byte)2, 150.0, "501", 3u },
                    { 2u, true, (byte)2, 150.0, "502", 3u },
                    { 3u, true, (byte)2, 150.0, "503", 3u },
                    { 4u, true, (byte)2, 150.0, "504", 3u },
                    { 5u, true, (byte)1, 50.0, "401", 1u },
                    { 6u, true, (byte)1, 50.0, "402", 1u },
                    { 7u, true, (byte)1, 50.0, "403", 1u },
                    { 8u, true, (byte)1, 50.0, "404", 1u },
                    { 9u, true, (byte)1, 50.0, "405", 1u },
                    { 10u, true, (byte)1, 50.0, "406", 1u },
                    { 11u, true, (byte)1, 50.0, "407", 1u },
                    { 12u, true, (byte)1, 50.0, "408", 1u },
                    { 13u, true, (byte)1, 50.0, "409", 1u },
                    { 14u, true, (byte)2, 80.0, "201", 2u },
                    { 15u, true, (byte)2, 80.0, "202", 2u },
                    { 16u, true, (byte)2, 80.0, "203", 2u },
                    { 17u, true, (byte)2, 80.0, "204", 2u },
                    { 18u, true, (byte)2, 80.0, "205", 2u },
                    { 19u, true, (byte)2, 80.0, "206", 2u },
                    { 20u, true, (byte)2, 80.0, "207", 2u },
                    { 21u, true, (byte)2, 80.0, "208", 2u },
                    { 22u, true, (byte)4, 200.0, "101", 4u },
                    { 23u, true, (byte)4, 200.0, "102", 4u },
                    { 24u, true, (byte)4, 200.0, "103", 4u },
                    { 25u, true, (byte)4, 200.0, "104", 4u },
                    { 26u, true, (byte)4, 200.0, "105", 4u },
                    { 27u, true, (byte)4, 200.0, "102", 4u },
                    { 28u, true, (byte)4, 200.0, "106", 4u },
                    { 29u, true, (byte)4, 200.0, "107", 4u },
                    { 30u, true, (byte)4, 200.0, "108", 4u },
                    { 31u, true, (byte)4, 200.0, "109", 4u },
                    { 32u, true, (byte)4, 200.0, "110", 4u }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_rooms_room_id",
                table: "bookings",
                column: "room_id",
                principalTable: "rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_room_types_room_type_id",
                table: "rooms",
                column: "room_type_id",
                principalTable: "room_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookings_rooms_room_id",
                table: "bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_rooms_room_types_room_type_id",
                table: "rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rooms",
                table: "rooms");

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31u);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32u);

            migrationBuilder.RenameTable(
                name: "rooms",
                newName: "Rooms");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_room_type_id",
                table: "Rooms",
                newName: "IX_Rooms_room_type_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookings_Rooms_room_id",
                table: "bookings",
                column: "room_id",
                principalTable: "Rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_room_types_room_type_id",
                table: "Rooms",
                column: "room_type_id",
                principalTable: "room_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
