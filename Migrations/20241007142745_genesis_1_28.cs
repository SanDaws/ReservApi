using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReservApi.Migrations
{
    /// <inheritdoc />
    public partial class genesis_1_28 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    first_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creation_ate = table.Column<DateOnly>(type: "date", nullable: false),
                    last_update = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    phone_number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birth_day = table.Column<DateOnly>(type: "date", nullable: true),
                    first_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    creation_ate = table.Column<DateOnly>(type: "date", nullable: false),
                    last_update = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_type_id = table.Column<uint>(type: "int unsigned", nullable: false),
                    price_per_night = table.Column<double>(type: "double", nullable: false),
                    avaliability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    max_occupancy_persons = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rooms_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_id = table.Column<uint>(type: "int unsigned", nullable: false),
                    guest_id = table.Column<uint>(type: "int unsigned", nullable: false),
                    employee_id = table.Column<uint>(type: "int unsigned", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    creation_ate = table.Column<DateOnly>(type: "date", nullable: false),
                    last_update = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.id);
                    table.ForeignKey(
                        name: "FK_bookings_Rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "Rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookings_guests_guest_id",
                        column: x => x.guest_id,
                        principalTable: "guests",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "creation_ate", "email", "first_name", "identification_number", "last_name", "last_update", "password" },
                values: new object[,]
                {
                    { 1u, new DateOnly(2024, 10, 7), "urregue@reserve.com", "pablo", "12456783344", "Urregue", new DateOnly(2024, 10, 7), "d815be3e37bcc366211f145014be8fb0498171acd5a0a00c2184cffa6c3fd0c3" },
                    { 2u, new DateOnly(2024, 10, 7), "laura.g@reserve.com", "Laura", "98765432100", "Gonzalez", new DateOnly(2024, 10, 7), "3c9e5983068ffdc39f2badfe7712dd21c3cd0b537c72716b463cc19f041842de" },
                    { 3u, new DateOnly(2024, 10, 7), "carlos.m@reserve.com", "Carlos", "32165498700", "Martinez", new DateOnly(2024, 10, 7), "39bde86e1977224bf7f03caf43f6204bfc8d4aeb5caa0768bc643ed34478f700" },
                    { 4u, new DateOnly(2024, 10, 7), "sofia.r@reserve.com", "Sofia", "45612378901", "Ramirez", new DateOnly(2024, 10, 7), "4b18c6ba678dbe972a4c40a839a098c6736f5778c013bd3b3f25fc4a306aace3" },
                    { 5u, new DateOnly(2024, 10, 7), "javier.h@reserve.com", "Javier", "15975348620", "Hernandez", new DateOnly(2024, 10, 7), "e11da32d8b69eab9a78e748cdb6433091a1843a0e1a321709627977b9a07ea39" },
                    { 6u, new DateOnly(2024, 10, 7), "ana.l@reserve.com", "Ana", "75315948623", "Lopez", new DateOnly(2024, 10, 7), "94f6bfb33224c66c81648579ada56c96e4f7c5eeb6588c6b3c7a4934168208e8" },
                    { 7u, new DateOnly(2024, 10, 7), "miguel.t@reserve.com", "Miguel", "85296374120", "Torres", new DateOnly(2024, 10, 7), "0635ce1702f31561042eec7c294c7bf03b8d51ec6525ee61c7ed372014d97db7" },
                    { 8u, new DateOnly(2024, 10, 7), "isabel.f@reserve.com", "Isabel", "36925814700", "Fernandez", new DateOnly(2024, 10, 7), "b471507e826b8e9fffa77c29cfcc65381405715616657022820f2ebce700268a" },
                    { 9u, new DateOnly(2024, 10, 7), "diego.c@reserve.com", "Diego", "14785236900", "Castro", new DateOnly(2024, 10, 7), "898fc103f32a84035e4d08fe9de6f7b7b6eb2a8ae8fe55c189bdb3732e76dfa5" }
                });

            migrationBuilder.InsertData(
                table: "guests",
                columns: new[] { "id", "birth_day", "creation_ate", "email", "first_name", "identification_number", "last_name", "last_update", "phone_number" },
                values: new object[,]
                {
                    { 1u, new DateOnly(2014, 12, 1), new DateOnly(2024, 10, 7), "urregue@reserve.com", "pablo", "12456783344", "Urregue", new DateOnly(2024, 10, 7), "+52 3122321246" },
                    { 2u, new DateOnly(1990, 5, 15), new DateOnly(2024, 10, 7), "laura.g@reserve.com", "Laura", "98765432100", "Gonzalez", new DateOnly(2024, 10, 7), "+52 3122321247" },
                    { 3u, new DateOnly(1985, 8, 22), new DateOnly(2024, 10, 7), "carlos.m@reserve.com", "Carlos", "32165498700", "Martinez", new DateOnly(2024, 10, 7), "+52 3122321248" },
                    { 4u, new DateOnly(2000, 2, 10), new DateOnly(2024, 10, 7), "sofia.r@reserve.com", "Sofia", "45612378901", "Ramirez", new DateOnly(2024, 10, 7), "+52 3122321249" },
                    { 5u, new DateOnly(1975, 11, 30), new DateOnly(2024, 10, 7), "javier.h@reserve.com", "Javier", "15975348620", "Hernandez", new DateOnly(2024, 10, 7), "+52 3122321250" },
                    { 6u, new DateOnly(1995, 4, 5), new DateOnly(2024, 10, 7), "ana.l@reserve.com", "Ana", "75315948623", "Lopez", new DateOnly(2024, 10, 7), "+52 3122321251" },
                    { 7u, new DateOnly(1980, 7, 19), new DateOnly(2024, 10, 7), "miguel.t@reserve.com", "Miguel", "85296374120", "Torres", new DateOnly(2024, 10, 7), "+52 3122321252" },
                    { 8u, new DateOnly(1992, 1, 25), new DateOnly(2024, 10, 7), "isabel.f@reserve.com", "Isabel", "36925814700", "Fernandez", new DateOnly(2024, 10, 7), "+52 3122321253" },
                    { 9u, new DateOnly(1988, 9, 12), new DateOnly(2024, 10, 7), "diego.c@reserve.com", "Diego", "14785236900", "Castro", new DateOnly(2024, 10, 7), "+52 3122321254" }
                });

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1u, "Una acogedora habitación básica con una cama individual, ideal para viajeros solos", "habitacion simple" },
                    { 2u, "ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos", "habitacion DOBLE" },
                    { 3u, "espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad", "suite" },
                    { 4u, "diseñada para familias, con espacio adicional y varias camas para una estancia cómoda", "habitacion Familiar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_employee_id",
                table: "bookings",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_guest_id",
                table: "bookings",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_bookings_room_id",
                table: "bookings",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_identification_number",
                table: "employees",
                column: "identification_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_guests_identification_number",
                table: "guests",
                column: "identification_number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_room_type_id",
                table: "Rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "room_types");
        }
    }
}
