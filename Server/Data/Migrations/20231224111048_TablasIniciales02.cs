using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaIngresoFMP.Server.Data.Migrations
{
    public partial class TablasIniciales02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PruebasSeleccions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspiranteId = table.Column<long>(type: "bigint", nullable: false),
                    PruebasId = table.Column<long>(type: "bigint", nullable: false),
                    Fechainicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fechafinalizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadospruebasId = table.Column<long>(type: "bigint", nullable: false),
                    Calificacion = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechaactualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PruebasSeleccions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PruebasSeleccions_Aspirantes_AspiranteId",
                        column: x => x.AspiranteId,
                        principalTable: "Aspirantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PruebasSeleccions_Estadospruebas_EstadospruebasId",
                        column: x => x.EstadospruebasId,
                        principalTable: "Estadospruebas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PruebasSeleccions_Pruebas_PruebasId",
                        column: x => x.PruebasId,
                        principalTable: "Pruebas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Homenick", "98693 Immanuel Bypass Suite 948", "miss_gonzalo.prohaska_phd@kerlukehammes.info", 0L, "Thad", "416.225.6235 x478" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Ziemann", "80420 Jaden Garden Apt. 683", "aaliyah_krajcik@graham.biz", 7L, "Sonny", "932-074-0314 x642" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Hirthe", "927 Charlie Passage Suite 949", "miss_marguerite_doyle.ii@kub.com", 5L, "Jeffrey", "820.017.3457" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Hilpert", "91117 Santos Ranch Apt. 998", "jerome.bergnaum@stammgrimes.us", 3L, "Bennett", "1-886-196-7026 x65651" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Franecki", "9490 Weston Hills Suite 722", "america_sauer@jacobson.com", 10L, "Kaylie", "852-644-9510 x324" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Batz", "189 Bogan Park Apt. 538", "hailie.veum@osinski.ca", 4L, "Katherine", "290.462.4684 x17391" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Murphy", "36879 Cleta Plains Apt. 423", "joy.rogahn@predovicgoodwin.name", 4L, "Manley", "(894)877-2623" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Bode", "31555 Terrill Brooks Apt. 009", "bethel_heller@schamberger.co.uk", 10L, "Brice", "1-825-381-2555 x126" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Pagac", "784 Pfeffer Green Suite 484", "oscar_giles.russel_iii@steuberreinger.com", 7L, "Ezra", "841-623-8559" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Legros", "4270 Valentine Islands Apt. 718", "owen.von@bartonpouros.name", 1L, "Linda", "1-936-098-9021 x923" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Nombres", "Telefono" },
                values: new object[] { "Hegmann", "70516 Gilbert Extensions Suite 478", "alejandra_flatley@collier.uk", "Orval", "608.246.2288" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Willms", "92307 Kris Ridges Suite 457", "ocie_murphy@doylemohr.ca", 4L, "Daphney", "263-731-3638 x099" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Walker", "0858 Cullen Meadow Suite 550", "laurianne.emmerich@armstrong.uk", 10L, "Ethel", "1-412-226-7876 x163" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Steuber", "14325 Raven Harbors Apt. 657", "gianni_lang@stantongrimes.uk", 4L, "Mikayla", "1-023-870-5768" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Anderson", "4929 Collins Pines Suite 233", "ms_clement_jeanette.volkman_ii@greenholt.uk", 6L, "Vida", "(462)078-8199 x74577" });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Deserunt quasi nam ex totam odit distinctio est et reprehenderit.", "Et illo omnis eum corrupti sint nam." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Iste nemo velit id sunt.", "Nam laboriosam perspiciatis nesciunt voluptas est." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Quia quo rem et et aut iure nemo.", "Modi sed qui vero." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Impedit cupiditate excepturi dolorem qui qui atque soluta.", "Cum sunt blanditiis accusantium quisquam." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ut ab quibusdam quisquam nobis incidunt modi consequuntur recusandae.", "Eos blanditiis necessitatibus labore eos velit et." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ab provident dicta nesciunt porro est.", "Ut aut blanditiis reprehenderit." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Fugit tempora aspernatur aliquid perspiciatis nihil temporibus est totam.", "Ipsam dolore doloremque eaque accusantium." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Voluptas harum repudiandae non.", "Nam sunt sint sit impedit labore unde." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Eum alias quas distinctio incidunt.", "Odio architecto temporibus maiores quibusdam aut voluptatem." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Excepturi est quia cupiditate.", "Quod necessitatibus deserunt doloribus." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Doloremque ut similique sit nihil ut.", "Voluptatum ut nihil voluptates vel aut aut maxime ut." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Dolorem sed voluptatem exercitationem nobis ratione laboriosam dolores.", "Itaque et temporibus error omnis doloremque cupiditate aut tempore beatae." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ut quasi soluta sunt incidunt.", "Eos est rerum omnis amet repellendus non qui iure atque." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ipsum quia et illo.", "Corporis voluptas quas beatae nihil sunt id aperiam consectetur." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Minus occaecati cum cumque voluptas.", "Delectus molestiae deleniti autem." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "maxime", 2L, 3L, "Est cum aut nostrum nisi voluptatem voluptatem." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "aperiam", 2L, 3L, "Laborum labore dolorem ut." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "Nombre" },
                values: new object[] { "accusantium", 4L, "Quisquam illo fugiat voluptatem ut et repellat ex." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "dolores", 3L, 2L, "Nesciunt modi ut et sunt." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "vel", "Quisquam harum placeat culpa quia explicabo." });

            migrationBuilder.InsertData(
                table: "PruebasSeleccions",
                columns: new[] { "Id", "AspiranteId", "Calificacion", "EstadospruebasId", "Fechaactualizacion", "Fechafinalizacion", "Fechainicio", "PruebasId", "Usuario" },
                values: new object[,]
                {
                    { 1L, 4L, 88, 4L, null, new DateTime(2023, 12, 24, 9, 10, 47, 687, DateTimeKind.Local).AddTicks(3097), new DateTime(2023, 12, 24, 6, 10, 47, 687, DateTimeKind.Local).AddTicks(3078), 1L, null },
                    { 2L, 7L, 67, 3L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 12, 24, 6, 11, 47, 687, DateTimeKind.Local).AddTicks(3113), 2L, null },
                    { 3L, 15L, 4, 3L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3121), new DateTime(2023, 12, 24, 6, 12, 47, 687, DateTimeKind.Local).AddTicks(3121), 3L, null },
                    { 4L, 12L, 88, 1L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3129), new DateTime(2023, 12, 24, 6, 13, 47, 687, DateTimeKind.Local).AddTicks(3128), 2L, null },
                    { 5L, 1L, 22, 2L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3278), new DateTime(2023, 12, 24, 6, 14, 47, 687, DateTimeKind.Local).AddTicks(3275), 3L, null },
                    { 6L, 8L, 28, 1L, null, new DateTime(2023, 12, 24, 9, 10, 47, 687, DateTimeKind.Local).AddTicks(3294), new DateTime(2023, 12, 24, 6, 15, 47, 687, DateTimeKind.Local).AddTicks(3293), 4L, null },
                    { 7L, 15L, 97, 3L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3303), new DateTime(2023, 12, 24, 6, 16, 47, 687, DateTimeKind.Local).AddTicks(3303), 5L, null }
                });

            migrationBuilder.InsertData(
                table: "PruebasSeleccions",
                columns: new[] { "Id", "AspiranteId", "Calificacion", "EstadospruebasId", "Fechaactualizacion", "Fechafinalizacion", "Fechainicio", "PruebasId", "Usuario" },
                values: new object[,]
                {
                    { 8L, 12L, 73, 1L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3315), new DateTime(2023, 12, 24, 6, 17, 47, 687, DateTimeKind.Local).AddTicks(3314), 2L, null },
                    { 9L, 8L, 64, 3L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3323), new DateTime(2023, 12, 24, 6, 18, 47, 687, DateTimeKind.Local).AddTicks(3322), 5L, null },
                    { 10L, 9L, 59, 4L, null, new DateTime(2023, 12, 24, 9, 10, 47, 687, DateTimeKind.Local).AddTicks(3333), new DateTime(2023, 12, 24, 6, 19, 47, 687, DateTimeKind.Local).AddTicks(3333), 3L, null },
                    { 11L, 9L, 34, 4L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3341), new DateTime(2023, 12, 24, 6, 20, 47, 687, DateTimeKind.Local).AddTicks(3341), 4L, null },
                    { 12L, 7L, 71, 3L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3349), new DateTime(2023, 12, 24, 6, 21, 47, 687, DateTimeKind.Local).AddTicks(3348), 1L, null },
                    { 13L, 5L, 31, 1L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3357), new DateTime(2023, 12, 24, 6, 22, 47, 687, DateTimeKind.Local).AddTicks(3356), 3L, null },
                    { 14L, 10L, 30, 4L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3367), new DateTime(2023, 12, 24, 6, 23, 47, 687, DateTimeKind.Local).AddTicks(3367), 5L, null },
                    { 15L, 8L, 18, 1L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3376), new DateTime(2023, 12, 24, 6, 24, 47, 687, DateTimeKind.Local).AddTicks(3375), 4L, null },
                    { 16L, 6L, 67, 2L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3384), new DateTime(2023, 12, 24, 6, 25, 47, 687, DateTimeKind.Local).AddTicks(3383), 4L, null },
                    { 17L, 1L, 92, 2L, null, new DateTime(2023, 12, 24, 8, 10, 47, 687, DateTimeKind.Local).AddTicks(3391), new DateTime(2023, 12, 24, 6, 26, 47, 687, DateTimeKind.Local).AddTicks(3391), 4L, null },
                    { 18L, 12L, 14, 4L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3401), new DateTime(2023, 12, 24, 6, 27, 47, 687, DateTimeKind.Local).AddTicks(3400), 1L, null },
                    { 19L, 2L, 67, 2L, null, new DateTime(2023, 12, 24, 9, 10, 47, 687, DateTimeKind.Local).AddTicks(3409), new DateTime(2023, 12, 24, 6, 28, 47, 687, DateTimeKind.Local).AddTicks(3408), 5L, null },
                    { 20L, 12L, 49, 1L, null, new DateTime(2023, 12, 24, 7, 10, 47, 687, DateTimeKind.Local).AddTicks(3419), new DateTime(2023, 12, 24, 6, 29, 47, 687, DateTimeKind.Local).AddTicks(3418), 5L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PruebasSeleccions_AspiranteId",
                table: "PruebasSeleccions",
                column: "AspiranteId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebasSeleccions_EstadospruebasId",
                table: "PruebasSeleccions",
                column: "EstadospruebasId");

            migrationBuilder.CreateIndex(
                name: "IX_PruebasSeleccions_PruebasId",
                table: "PruebasSeleccions",
                column: "PruebasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PruebasSeleccions");

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Buckridge", "5685 Jacky Lake Suite 223", "miss.yesenia_reilly@krajcik.co.uk", 10L, "Autumn", "186.062.1756 x92843" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Kertzmann", "0104 Jakubowski Grove Apt. 505", "ashley.gusikowski.dvm@kohlerfahey.info", 9L, "Noe", "1-817-455-4592 x396" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Huels", "72507 McLaughlin Motorway Suite 017", "mariane.schoen@denesik.com", 9L, "Elsa", "(604)479-2219" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Hettinger", "59228 Mauricio Union Suite 316", "dr.greta_jedidiah.anderson.md@dachschmitt.uk", 5L, "Anita", "707-555-9770 x25845" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Rosenbaum", "32880 Wilderman Street Suite 983", "mr_jalen_kerluke.iv@medhurst.info", 3L, "Raphaelle", "299-585-2226" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Klein", "92084 Jones Square Apt. 843", "kariane.jerde@yostarmstrong.biz", 6L, "Berneice", "1-996-946-5979 x25059" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Welch", "9433 Satterfield Lake Suite 102", "janie_welch@gorczany.co.uk", 8L, "Trycia", "060.623.6687 x4116" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Jacobson", "8507 Weber Hill Suite 515", "emmitt.jewess@dubuquewelch.co.uk", 4L, "Lawrence", "(105)249-8371" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Bogan", "6440 Wilhelm Wells Apt. 886", "dr.jettie.justus.howell.v@witting.co.uk", 6L, "Katrina", "213.317.6741 x736" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Becker", "97171 Johnny Spur Suite 097", "brent_ankunding@nikolaus.ca", 8L, "Domingo", "1-027-602-6731" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Nombres", "Telefono" },
                values: new object[] { "Schiller", "407 Marina Lake Suite 612", "dwight.swaniawski@rowegrady.ca", "Cooper", "(879)212-9377" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Jacobs", "1357 Turner Plains Suite 610", "herta_leo.murphy_i@heathcote.biz", 3L, "Kennedi", "1-196-157-5929 x7711" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Fay", "24785 Destinee Knolls Suite 493", "mrs.peter.bahringer.iii@kessler.co.uk", 3L, "Walker", "(589)073-2349 x5581" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Roob", "511 Izaiah Harbors Suite 002", "friedrich.felipe_christiansen.ii@steuberleffler.name", 5L, "Destiney", "1-178-472-9498 x32595" });

            migrationBuilder.UpdateData(
                table: "Aspirantes",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Apellidos", "Direccion", "Email", "Identificacion", "Nombres", "Telefono" },
                values: new object[] { "Strosin", "8979 Dibbert Fields Suite 966", "petra.kemmer@cummings.com", 7L, "Izabella", "1-022-387-3361 x72755" });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ab vel repellendus quia deserunt ullam iste.", "Aspernatur expedita sit nihil quia." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Non quis omnis et eos accusamus non possimus et ut.", "Modi voluptatibus dolore dolor distinctio." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Accusantium quae enim ut.", "Necessitatibus asperiores molestiae et voluptas quos iure aut." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Corrupti officiis ut saepe quaerat adipisci maiores veritatis.", "Sit omnis eos exercitationem et qui." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Id voluptatem cumque modi dolor magnam aperiam rerum quia.", "Et et magnam natus eum doloribus consequatur voluptatem explicabo." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Quisquam ullam id pariatur a nam similique.", "Voluptates culpa dolorum sed officia iste." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Mollitia aperiam est non ea similique ea at voluptates.", "Est officia dignissimos debitis earum odit aut amet." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Dolore enim doloremque laboriosam dolorem occaecati iusto temporibus.", "Consequatur sit animi placeat voluptas quibusdam." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Totam enim est cupiditate voluptates possimus architecto rerum et.", "Sed consequatur est rerum omnis fugiat voluptas." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Ut non aut sed illo officia.", "Sed enim est iste qui fugit ut quos dolore." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Repudiandae eos magni nulla vel non aliquam.", "Aut ratione corrupti neque nobis laudantium reiciendis et." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Aliquid aut possimus dicta.", "Molestias optio qui quasi." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Provident esse libero voluptatem excepturi pariatur.", "Nobis quia enim pariatur rerum incidunt." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Impedit harum dolorem cupiditate.", "Voluptas et nulla quia qui dicta officia sint officiis." });

            migrationBuilder.UpdateData(
                table: "Preguntas",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Pregunta", "Respuesta" },
                values: new object[] { "Vel numquam maxime non officia autem itaque ut sed.", "Fugit numquam quod qui." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "qui", 3L, 2L, "Explicabo error ut officiis ex ut iure." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "sequi", 3L, 2L, "Error animi adipisci sint repellendus error non ipsa occaecati." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "Nombre" },
                values: new object[] { "sit", 2L, "Minima pariatur quis corrupti cum dolor est accusantium aut est." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Descripcion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre" },
                values: new object[] { "tempora", 2L, 3L, "Enim qui aut commodi odio numquam ea." });

            migrationBuilder.UpdateData(
                table: "Pruebas",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "numquam", "Cupiditate iusto doloremque et eos sapiente dolores similique odio." });
        }
    }
}
