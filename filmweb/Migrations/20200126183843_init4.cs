using Microsoft.EntityFrameworkCore.Migrations;

namespace filmweb.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmActor_Actors_ActorId",
                table: "FilmActor");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmActor_Films_FilmId",
                table: "FilmActor");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenre_Films_FilmId",
                table: "FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenre_Genres_GenreId",
                table: "FilmGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmProducer_Films_FilmId",
                table: "FilmProducer");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmProducer_Producers_ProducerId",
                table: "FilmProducer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmProducer",
                table: "FilmProducer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmGenre",
                table: "FilmGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmActor",
                table: "FilmActor");

            migrationBuilder.RenameTable(
                name: "FilmProducer",
                newName: "FilmProducers");

            migrationBuilder.RenameTable(
                name: "FilmGenre",
                newName: "FilmGenres");

            migrationBuilder.RenameTable(
                name: "FilmActor",
                newName: "FilmActors");

            migrationBuilder.RenameIndex(
                name: "IX_FilmProducer_FilmId",
                table: "FilmProducers",
                newName: "IX_FilmProducers_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmGenre_FilmId",
                table: "FilmGenres",
                newName: "IX_FilmGenres_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmActor_FilmId",
                table: "FilmActors",
                newName: "IX_FilmActors_FilmId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmProducers",
                table: "FilmProducers",
                columns: new[] { "ProducerId", "FilmId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmGenres",
                table: "FilmGenres",
                columns: new[] { "GenreId", "FilmId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmActors",
                table: "FilmActors",
                columns: new[] { "ActorId", "FilmId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FilmActors_Actors_ActorId",
                table: "FilmActors",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmActors_Films_FilmId",
                table: "FilmActors",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenres_Films_FilmId",
                table: "FilmGenres",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenres_Genres_GenreId",
                table: "FilmGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmProducers_Films_FilmId",
                table: "FilmProducers",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmProducers_Producers_ProducerId",
                table: "FilmProducers",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmActors_Actors_ActorId",
                table: "FilmActors");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmActors_Films_FilmId",
                table: "FilmActors");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenres_Films_FilmId",
                table: "FilmGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenres_Genres_GenreId",
                table: "FilmGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmProducers_Films_FilmId",
                table: "FilmProducers");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmProducers_Producers_ProducerId",
                table: "FilmProducers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmProducers",
                table: "FilmProducers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmGenres",
                table: "FilmGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmActors",
                table: "FilmActors");

            migrationBuilder.RenameTable(
                name: "FilmProducers",
                newName: "FilmProducer");

            migrationBuilder.RenameTable(
                name: "FilmGenres",
                newName: "FilmGenre");

            migrationBuilder.RenameTable(
                name: "FilmActors",
                newName: "FilmActor");

            migrationBuilder.RenameIndex(
                name: "IX_FilmProducers_FilmId",
                table: "FilmProducer",
                newName: "IX_FilmProducer_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmGenres_FilmId",
                table: "FilmGenre",
                newName: "IX_FilmGenre_FilmId");

            migrationBuilder.RenameIndex(
                name: "IX_FilmActors_FilmId",
                table: "FilmActor",
                newName: "IX_FilmActor_FilmId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmProducer",
                table: "FilmProducer",
                columns: new[] { "ProducerId", "FilmId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmGenre",
                table: "FilmGenre",
                columns: new[] { "GenreId", "FilmId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmActor",
                table: "FilmActor",
                columns: new[] { "ActorId", "FilmId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FilmActor_Actors_ActorId",
                table: "FilmActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmActor_Films_FilmId",
                table: "FilmActor",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenre_Films_FilmId",
                table: "FilmGenre",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenre_Genres_GenreId",
                table: "FilmGenre",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmProducer_Films_FilmId",
                table: "FilmProducer",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmProducer_Producers_ProducerId",
                table: "FilmProducer",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
