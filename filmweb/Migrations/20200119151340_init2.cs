using Microsoft.EntityFrameworkCore.Migrations;

namespace filmweb.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Films_FilmId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteFilms_User_UserId",
                table: "FavoriteFilms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_FilmId",
                table: "Comments",
                newName: "IX_Comments_FilmId");

            migrationBuilder.AlterColumn<string>(
                name: "Login",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Леонардо Дикаприо" },
                    { 1, "Джони Деп" },
                    { 2, "Том Круз" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Тёмный рыцарь" },
                    { 1, "Однажды в Голивуде" },
                    { 2, "Космическая одисея" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Боевик" },
                    { 1, "Фентези" },
                    { 2, "Детектив" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Кристофер Нолан" },
                    { 1, "Квентин Тарантино" },
                    { 2, "Стэнли Кубрик" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Login", "Password" },
                values: new object[] { 3, null, "test", null });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "FilmId", "Text", "UserId" },
                values: new object[] { 3, 3, "классный фильм!", 3 });

            migrationBuilder.InsertData(
                table: "FilmActor",
                columns: new[] { "ActorId", "FilmId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 2, 1 },
                    { 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "FilmGenre",
                columns: new[] { "GenreId", "FilmId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 1, 3 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "FilmProducer",
                columns: new[] { "ProducerId", "FilmId" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Films_FilmId",
                table: "Comments",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteFilms_Users_UserId",
                table: "FavoriteFilms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Films_FilmId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteFilms_Users_UserId",
                table: "FavoriteFilms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilmActor",
                keyColumns: new[] { "ActorId", "FilmId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FilmActor",
                keyColumns: new[] { "ActorId", "FilmId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FilmActor",
                keyColumns: new[] { "ActorId", "FilmId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "FilmGenre",
                keyColumns: new[] { "GenreId", "FilmId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "FilmGenre",
                keyColumns: new[] { "GenreId", "FilmId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FilmGenre",
                keyColumns: new[] { "GenreId", "FilmId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProducer",
                keyColumns: new[] { "ProducerId", "FilmId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FilmProducer",
                keyColumns: new[] { "ProducerId", "FilmId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "FilmProducer",
                keyColumns: new[] { "ProducerId", "FilmId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_FilmId",
                table: "Comment",
                newName: "IX_Comment_FilmId");

            migrationBuilder.AlterColumn<int>(
                name: "Login",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Films_FilmId",
                table: "Comment",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_User_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteFilms_User_UserId",
                table: "FavoriteFilms",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
