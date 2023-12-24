using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaIngresoFMP.Server.Data.Migrations
{
    public partial class TablasIniciales01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aspirantes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<long>(type: "bigint", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechaactualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspirantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estadospruebas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadospruebas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LenguajesProgramacions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LenguajesProgramacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NivelPruebas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelPruebas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pruebas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LenguajesProgramacionId = table.Column<long>(type: "bigint", nullable: false),
                    NivelPruebaId = table.Column<long>(type: "bigint", nullable: false),
                    Tipoprueba = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidadpreguntas = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechaactualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pruebas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pruebas_LenguajesProgramacions_LenguajesProgramacionId",
                        column: x => x.LenguajesProgramacionId,
                        principalTable: "LenguajesProgramacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pruebas_NivelPruebas_NivelPruebaId",
                        column: x => x.NivelPruebaId,
                        principalTable: "NivelPruebas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preguntas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PruebasId = table.Column<long>(type: "bigint", nullable: false),
                    Pregunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Respuesta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fechaactualizacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preguntas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preguntas_Pruebas_PruebasId",
                        column: x => x.PruebasId,
                        principalTable: "Pruebas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Aspirantes",
                columns: new[] { "Id", "Apellidos", "Direccion", "Email", "Fechaactualizacion", "Identificacion", "Nombres", "Telefono", "Usuario" },
                values: new object[,]
                {
                    { 1L, "Buckridge", "5685 Jacky Lake Suite 223", "miss.yesenia_reilly@krajcik.co.uk", null, 10L, "Autumn", "186.062.1756 x92843", null },
                    { 2L, "Kertzmann", "0104 Jakubowski Grove Apt. 505", "ashley.gusikowski.dvm@kohlerfahey.info", null, 9L, "Noe", "1-817-455-4592 x396", null },
                    { 3L, "Huels", "72507 McLaughlin Motorway Suite 017", "mariane.schoen@denesik.com", null, 9L, "Elsa", "(604)479-2219", null },
                    { 4L, "Hettinger", "59228 Mauricio Union Suite 316", "dr.greta_jedidiah.anderson.md@dachschmitt.uk", null, 5L, "Anita", "707-555-9770 x25845", null },
                    { 5L, "Rosenbaum", "32880 Wilderman Street Suite 983", "mr_jalen_kerluke.iv@medhurst.info", null, 3L, "Raphaelle", "299-585-2226", null },
                    { 6L, "Klein", "92084 Jones Square Apt. 843", "kariane.jerde@yostarmstrong.biz", null, 6L, "Berneice", "1-996-946-5979 x25059", null },
                    { 7L, "Welch", "9433 Satterfield Lake Suite 102", "janie_welch@gorczany.co.uk", null, 8L, "Trycia", "060.623.6687 x4116", null },
                    { 8L, "Jacobson", "8507 Weber Hill Suite 515", "emmitt.jewess@dubuquewelch.co.uk", null, 4L, "Lawrence", "(105)249-8371", null },
                    { 9L, "Bogan", "6440 Wilhelm Wells Apt. 886", "dr.jettie.justus.howell.v@witting.co.uk", null, 6L, "Katrina", "213.317.6741 x736", null },
                    { 10L, "Becker", "97171 Johnny Spur Suite 097", "brent_ankunding@nikolaus.ca", null, 8L, "Domingo", "1-027-602-6731", null },
                    { 11L, "Schiller", "407 Marina Lake Suite 612", "dwight.swaniawski@rowegrady.ca", null, 9L, "Cooper", "(879)212-9377", null },
                    { 12L, "Jacobs", "1357 Turner Plains Suite 610", "herta_leo.murphy_i@heathcote.biz", null, 3L, "Kennedi", "1-196-157-5929 x7711", null },
                    { 13L, "Fay", "24785 Destinee Knolls Suite 493", "mrs.peter.bahringer.iii@kessler.co.uk", null, 3L, "Walker", "(589)073-2349 x5581", null },
                    { 14L, "Roob", "511 Izaiah Harbors Suite 002", "friedrich.felipe_christiansen.ii@steuberleffler.name", null, 5L, "Destiney", "1-178-472-9498 x32595", null },
                    { 15L, "Strosin", "8979 Dibbert Fields Suite 966", "petra.kemmer@cummings.com", null, 7L, "Izabella", "1-022-387-3361 x72755", null }
                });

            migrationBuilder.InsertData(
                table: "Estadospruebas",
                columns: new[] { "Id", "Descripcion" },
                values: new object[,]
                {
                    { 1L, "Registrada" },
                    { 2L, "En proceso" },
                    { 3L, "Terminada" },
                    { 4L, "Anulada" }
                });

            migrationBuilder.InsertData(
                table: "LenguajesProgramacions",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1L, "SDK Java", "Java" },
                    { 2L, ".Net C#", "C#" },
                    { 3L, "Javascript", "Javascript" },
                    { 4L, "GoLang", "Go" }
                });

            migrationBuilder.InsertData(
                table: "NivelPruebas",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1L, "Junior" },
                    { 2L, "Middle" },
                    { 3L, "Senior" }
                });

            migrationBuilder.InsertData(
                table: "Pruebas",
                columns: new[] { "Id", "Cantidadpreguntas", "Codigo", "Descripcion", "Fechaactualizacion", "LenguajesProgramacionId", "NivelPruebaId", "Nombre", "Tipoprueba", "Usuario" },
                values: new object[,]
                {
                    { 1L, 2, "000001", "qui", null, 3L, 2L, "Explicabo error ut officiis ex ut iure.", "Tecnica", null },
                    { 2L, 2, "000002", "sequi", null, 3L, 2L, "Error animi adipisci sint repellendus error non ipsa occaecati.", "Tecnica", null },
                    { 3L, 2, "000003", "sit", null, 2L, 3L, "Minima pariatur quis corrupti cum dolor est accusantium aut est.", "Tecnica", null },
                    { 4L, 2, "000004", "tempora", null, 2L, 3L, "Enim qui aut commodi odio numquam ea.", "Tecnica", null },
                    { 5L, 2, "000005", "numquam", null, 3L, 2L, "Cupiditate iusto doloremque et eos sapiente dolores similique odio.", "Tecnica", null }
                });

            migrationBuilder.InsertData(
                table: "Preguntas",
                columns: new[] { "Id", "Fechaactualizacion", "Pregunta", "PruebasId", "Respuesta", "Usuario" },
                values: new object[,]
                {
                    { 1L, null, "Ab vel repellendus quia deserunt ullam iste.", 1L, "Aspernatur expedita sit nihil quia.", null },
                    { 2L, null, "Non quis omnis et eos accusamus non possimus et ut.", 1L, "Modi voluptatibus dolore dolor distinctio.", null },
                    { 3L, null, "Accusantium quae enim ut.", 1L, "Necessitatibus asperiores molestiae et voluptas quos iure aut.", null },
                    { 4L, null, "Corrupti officiis ut saepe quaerat adipisci maiores veritatis.", 2L, "Sit omnis eos exercitationem et qui.", null },
                    { 5L, null, "Id voluptatem cumque modi dolor magnam aperiam rerum quia.", 2L, "Et et magnam natus eum doloribus consequatur voluptatem explicabo.", null },
                    { 6L, null, "Quisquam ullam id pariatur a nam similique.", 2L, "Voluptates culpa dolorum sed officia iste.", null },
                    { 7L, null, "Mollitia aperiam est non ea similique ea at voluptates.", 3L, "Est officia dignissimos debitis earum odit aut amet.", null },
                    { 8L, null, "Dolore enim doloremque laboriosam dolorem occaecati iusto temporibus.", 3L, "Consequatur sit animi placeat voluptas quibusdam.", null },
                    { 9L, null, "Totam enim est cupiditate voluptates possimus architecto rerum et.", 3L, "Sed consequatur est rerum omnis fugiat voluptas.", null },
                    { 10L, null, "Ut non aut sed illo officia.", 4L, "Sed enim est iste qui fugit ut quos dolore.", null },
                    { 11L, null, "Repudiandae eos magni nulla vel non aliquam.", 4L, "Aut ratione corrupti neque nobis laudantium reiciendis et.", null },
                    { 12L, null, "Aliquid aut possimus dicta.", 4L, "Molestias optio qui quasi.", null },
                    { 13L, null, "Provident esse libero voluptatem excepturi pariatur.", 5L, "Nobis quia enim pariatur rerum incidunt.", null },
                    { 14L, null, "Impedit harum dolorem cupiditate.", 5L, "Voluptas et nulla quia qui dicta officia sint officiis.", null },
                    { 15L, null, "Vel numquam maxime non officia autem itaque ut sed.", 5L, "Fugit numquam quod qui.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Preguntas_PruebasId",
                table: "Preguntas",
                column: "PruebasId");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_LenguajesProgramacionId",
                table: "Pruebas",
                column: "LenguajesProgramacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pruebas_NivelPruebaId",
                table: "Pruebas",
                column: "NivelPruebaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aspirantes");

            migrationBuilder.DropTable(
                name: "Estadospruebas");

            migrationBuilder.DropTable(
                name: "Preguntas");

            migrationBuilder.DropTable(
                name: "Pruebas");

            migrationBuilder.DropTable(
                name: "LenguajesProgramacions");

            migrationBuilder.DropTable(
                name: "NivelPruebas");
        }
    }
}
