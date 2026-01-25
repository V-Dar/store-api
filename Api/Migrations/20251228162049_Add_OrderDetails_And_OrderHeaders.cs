using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class Add_OrderDetails_And_OrderHeaders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: true),
                    OrderTotalAmount = table.Column<double>(type: "double precision", nullable: false),
                    OrderDataTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: true),
                    TotalCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.OrderHeaderId);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderHeaderId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ItemName = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderHeaderId",
                        column: x => x.OrderHeaderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "OrderHeaderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Показывает сложившаяся различных последовательного системы социально-экономическое курс.", "Лоснящийся Хлопковый Шарф", 105.31, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Важную ресурсосберегающих за.", "Лоснящийся Хлопковый Плащ", 615.52999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Гражданского кадровой управление высокотехнологичная существующий эксперимент.", "Великолепный Меховой Портмоне", 165.97, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Сложившаяся специалистов проверки определения широкому требует вызывает образом важную повышению.", "Великолепный Гранитный Свитер", 256.64999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Кадровой забывать количественный административных обуславливает кадровой.", "Грубый Меховой Свитер", 540.72000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "За реализация за кругу существующий профессионального таким прежде.", "Лоснящийся Стальной Берет", 760.64999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Высокотехнологичная обществом позволяет представляет за в задач также роль.", "Маленький Кожанный Ножницы", 568.90999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Рамки очевидна понимание.", "Потрясающий Гранитный Кепка", 513.46000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Сущности что правительством занимаемых позволяет кадров.", "Большой Хлопковый Кепка", 882.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Важные структура богатый концепция структура формированию сущности новая.", "Свободный Меховой Ремень", 849.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Всего на выбранный дальнейших требует.", "Невероятный Пластиковый Майка", 632.5, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Целесообразности дальнейшее социально-экономическое поэтапного форм обществом кадров создаёт занимаемых настолько.", "Эргономичный Резиновый Шарф", 319.44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Повседневной по также формировании намеченных соответствующих богатый также.", "Практичный Неодимовый Сабо", 319.31999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Структура в напрямую от модели современного.", "Потрясающий Стальной Кулон", 450.39999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Отношении нами активизации.", "Маленький Резиновый Автомобиль", 220.83000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Качественно укрепления реализация намеченных однако.", "Свободный Стальной Ножницы", 906.48000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Позволяет широким кадровой общества.", "Свободный Хлопковый Куртка", 183.84999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Административных высшего по.", "Маленький Бетонный Ножницы", 216.13, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Уровня форм мира занимаемых обществом демократической играет нами сознания.", "Потрясающий Хлопковый Кепка", 895.53999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Систему социально-ориентированный всего настолько.", "Невероятный Пластиковый Сабо", 545.12, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Позволяет обеспечивает определения плановых значительной задания нами.", "Невероятный Кожанный Клатч", 226.43000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Управление за укрепления оценить практика.", "Великолепный Гранитный Клатч", 809.02999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Консультация систему высшего работы организации задач по стороны же.", "Маленький Меховой Берет", 125.59999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Уточнения модернизации определения на правительством оценить настолько структура высшего насущным.", "Грубый Натуральный Ботинок", 34.729999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Социально-ориентированный модель представляет и влечёт уточнения зависит.", "Свободный Меховой Ножницы", 437.75, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Разработке идейные уровня для повышению общества этих сознания проблем.", "Грубый Меховой Плащ", 737.10000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "И специалистов условий выбранный за формировании.", "Свободный Кожанный Автомобиль", 817.13 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Участниками структуры кадров.", "Фантастический Кожанный Кошелек", 614.65999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Участниками другой качества модели массового управление и.", "Лоснящийся Натуральный Майка", 885.80999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Форм целесообразности настолько.", "Потрясающий Бетонный Куртка", 728.40999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Профессионального следует финансовых богатый процесс курс.", "Эргономичный Кожанный Ботинок", 401.62, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Для консультация формировании оценить понимание развития.", "Большой Деревянный Кошелек", 214.41, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Нами системы курс актуальность вызывает а количественный.", "Потрясающий Неодимовый Свитер", 924.36000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Стороны целесообразности представляет задания и широким путь количественный принимаемых последовательного.", "Большой Натуральный Свитер", 143.30000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Значительной активизации предложений реализация консультация же играет сомнений потребностям.", "Великолепный Деревянный Стул", 954.61000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Сфера концепция настолько проект.", "Маленький Стальной Плащ", 512.84000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Плановых значение повышению структуры.", "Интеллектуальный Деревянный Автомобиль", 46.210000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Правительством кругу нас управление формирования новая кругу понимание на.", "Потрясающий Натуральный Куртка", 331.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Задания материально-технической новая с нами и нашей структура.", "Великолепный Кожанный Кепка", 908.08000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Структура новых проверки направлений выбранный.", "Эргономичный Меховой Стул", 711.80999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Намеченных создаёт гражданского внедрения форм обществом подготовке системы организационной.", "Невероятный Гранитный Свитер", 764.19000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Ресурсосберегающих поэтапного существующий.", "Грубый Натуральный Ремень", 112.58, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Структура плановых сложившаяся массового.", "Маленький Резиновый Ремень", 60.649999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Нами национальный вызывает условий широким подготовке идейные поставленных информационно-пропогандистское массового.", "Грубый Меховой Шарф", 373.45999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Формировании экономической что специалистов практика определения создание.", "Потрясающий Гранитный Сабо", 992.28999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Этих зависит в создание сфера.", "Лоснящийся Деревянный Берет", 539.58000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Дальнейших сложившаяся забывать активом отношении высокотехнологичная.", "Практичный Бетонный Ботинок", 793.70000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Существующий процесс новых.", "Большой Бетонный Стол", 166.49000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Постоянное формировании новых обеспечивает формировании формировании задач.", "Лоснящийся Стальной Ботинок", 331.79000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "На условий формирования обществом.", "Маленький Гранитный Ботинок", 182.91999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сфера понимание рост.", "Маленький Резиновый Майка", 341.31, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Модель по рамки технологий.", "Великолепный Кожанный Носки", 657.78999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Кругу таким нас.", "Невероятный Неодимовый Стул", 533.33000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Укрепления демократической направлений модернизации различных в.", "Большой Кожанный Носки", 568.24000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Рамки зависит воздействия отношении базы для проект мира широким активом.", "Большой Деревянный Ножницы", 596.13999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Укрепления активности гражданского.", "Практичный Меховой Носки", 457.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Постоянное кадровой прогресса требует кругу деятельности.", "Интеллектуальный Бетонный Автомобиль", 258.88, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Информационно-пропогандистское прогресса проверки соответствующей выбранный роль.", "Интеллектуальный Стальной Сабо", 144.11000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Формирования соответствующих различных разнообразный качественно административных организационной.", "Свободный Гранитный Стол", 227.09999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Условий инновационный ресурсосберегающих правительством организационной внедрения.", "Свободный Кожанный Майка", 934.45000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Специалистов другой модели.", "Большой Резиновый Майка", 334.33999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Постоянный задач общества общественной важные процесс базы целесообразности.", "Маленький Деревянный Стол", 647.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Таким задач специалистов существующий массового другой.", "Практичный Резиновый Майка", 522.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Условий значительной дальнейшее обеспечение сознания существующий важную способствует.", "Лоснящийся Стальной Ножницы", 388.86000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Важную модели качества материально-технической способствует курс богатый всего.", "Эргономичный Бетонный Кепка", 715.97000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Проект соображения этих соображения с.", "Маленький Натуральный Кошелек", 587.86000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Важные степени показывает в нами технологий работы современного соответствующей способствует.", "Фантастический Стальной Кулон", 523.90999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Организационной рост собой для выполнять место начало.", "Лоснящийся Бетонный Кошелек", 318.06, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Зависит формированию сфера для начало активизации отношении.", "Эргономичный Натуральный Стол", 36.07, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Внедрения другой инновационный национальный занимаемых понимание сомнений.", "Интеллектуальный Хлопковый Свитер", 880.58000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Кадровой другой обуславливает особенности отношении выбранный.", "Потрясающий Бетонный Стол", 229.84, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Технологий сфера уточнения проверки оценить на укрепления существующий национальный технологий.", "Свободный Кожанный Компьютер", 932.47000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Кадров нашей выбранный понимание структуры.", "Свободный Меховой Плащ", 589.55999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Важную повседневной организационной изменений сомнений.", "Лоснящийся Деревянный Майка", 943.71000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Значимость позиции сложившаяся плановых обуславливает повышение другой очевидна.", "Эргономичный Стальной Клатч", 156.44 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Разработке обуславливает важные богатый.", "Интеллектуальный Кожанный Шарф", 26.93 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Курс укрепления дальнейшее равным на формирования административных намеченных выбранный принимаемых.", "Лоснящийся Кожанный Сабо", 345.14999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Материально-технической соответствующих экономической определения зависит курс эксперимент различных.", "Практичный Стальной Портмоне", 688.75999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Существующий создаёт направлений особенности определения по потребностям.", "Лоснящийся Пластиковый Автомобиль", 611.39999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Широкому соображения в широкому богатый.", "Свободный Кожанный Портмоне", 470.05000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "В внедрения уровня таким за обучения способствует прежде социально-ориентированный место.", "Великолепный Гранитный Клатч", 925.65999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Плановых материально-технической влечёт.", "Невероятный Кожанный Автомобиль", 96.239999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "На подготовке участия.", "Фантастический Меховой Клатч", 490.69999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Системы уровня общественной организационной различных информационно-пропогандистское.", "Невероятный Стальной Компьютер", 696.29999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Базы укрепления управление демократической.", "Великолепный Натуральный Клатч", 670.84000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Также а национальный важную позволяет социально-ориентированный выбранный анализа.", "Маленький Натуральный Кепка", 645.67999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Играет создаёт модернизации.", "Большой Бетонный Берет", 773.90999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Стороны значение повседневная.", "Грубый Бетонный Берет", 904.40999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Актуальность высшего последовательного место массового поэтапного разнообразный однако.", "Потрясающий Деревянный Ремень", 575.51999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Принципов задания обществом ресурсосберегающих формировании социально-экономическое сфера очевидна.", "Невероятный Деревянный Портмоне", 6.0899999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "И различных демократической от реализация технологий обуславливает отношении разработке последовательного.", "Маленький Стальной Портмоне", 599.34000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Другой практика количественный место.", "Свободный Пластиковый Клатч", 514.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Определения всего значение социально-ориентированный.", "Интеллектуальный Хлопковый Ботинок", 607.39999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Место модернизации обуславливает гражданского работы на значительной сущности актуальность.", "Потрясающий Пластиковый Ножницы", 707.73000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Очевидна напрямую определения на уточнения.", "Большой Пластиковый Стул", 782.14999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Процесс модернизации воздействия сфера поэтапного повышению подготовке.", "Большой Гранитный Ножницы", 14.85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Кадровой уточнения не путь.", "Невероятный Меховой Ремень", 400.66000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Особенности соответствующей повседневная поставленных забывать порядка.", "Свободный Натуральный Кепка", 664.28999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Административных форм определения обеспечение существующий.", "Свободный Кожанный Берет", 39.659999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Порядка процесс поэтапного специалистов соответствующих образом демократической новая для насущным.", "Великолепный Деревянный Сабо", 756.08000000000004 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderHeaderId",
                table: "OrderDetails",
                column: "OrderHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_AppUserId",
                table: "OrderHeaders",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Уточнения системы поставленных способствует уровня не различных форм предложений.", "Эргономичный Бетонный Ножницы", 33.939999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Же высшего выполнять деятельности равным управление.", "Потрясающий Стальной Кулон", 516.69000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Качественно позиции предпосылки технологий прежде по инновационный.", "Интеллектуальный Кожанный Шарф", 441.54000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поставленных мира повышение.", "Грубый Кожанный Плащ", 291.33999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Информационно-пропогандистское участниками повышение таким не.", "Практичный Хлопковый Кулон", 29.219999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Рост следует демократической повышению качества предпосылки финансовых.", "Потрясающий Хлопковый Кошелек", 166.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Инновационный общества задача.", "Лоснящийся Натуральный Стол", 924.13999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Кадровой проблем позиции в работы же укрепления забывать.", "Фантастический Меховой Стол", 490.30000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Поэтапного показывает консультация нами.", "Великолепный Гранитный Стул", 322.85000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Что структуры экономической постоянное нас сущности.", "Маленький Натуральный Берет", 857.75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Консультация активности организации важную собой управление следует.", "Грубый Гранитный Плащ", 569.84000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Оценить направлений влечёт обеспечение другой.", "Свободный Неодимовый Ботинок", 380.35000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Базы консультация реализация поэтапного высшего обществом.", "Эргономичный Гранитный Кепка", 616.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Информационно-пропогандистское соответствующих подготовке качества сложившаяся экономической.", "Эргономичный Хлопковый Майка", 590.69000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Существующий национальный эксперимент особенности от.", "Маленький Деревянный Кепка", 204.72999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Понимание широким и задач проблем целесообразности проект.", "Грубый Деревянный Автомобиль", 691.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Поэтапного системы плановых путь реализация также намеченных подготовке.", "Потрясающий Меховой Носки", 639.12, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Насущным отношении сфера качества реализация.", "Потрясающий Резиновый Ботинок", 175.09999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Занимаемых место постоянный позиции постоянное играет кадровой базы.", "Невероятный Гранитный Портмоне", 876.88999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Особенности управление сущности кругу таким деятельности сущности плановых базы социально-ориентированный.", "Грубый Резиновый Портмоне", 236.91, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Обуславливает материально-технической вызывает.", "Практичный Натуральный Берет", 594.28999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Принципов представляет правительством на не соответствующей другой практика модели.", "Фантастический Кожанный Шарф", 940.07000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Опыт участия укрепления для обуславливает для специалистов сомнений прогресса.", "Большой Неодимовый Компьютер", 282.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Занимаемых правительством участниками всего внедрения нами целесообразности последовательного различных разработке.", "Большой Меховой Стул", 297.95999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "По путь структура позволяет прежде роль богатый.", "Великолепный Неодимовый Кулон", 560.05999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Прежде потребностям образом качественно.", "Великолепный Кожанный Стул", 890.65999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Прогресса определения модели а влечёт кругу базы управление социально-экономическое специалистов.", "Эргономичный Деревянный Кошелек", 898.38999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Предложений различных последовательного позволяет следует направлений проект.", "Практичный Меховой Кошелек", 243.02000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Проект стороны повышение структура.", "Эргономичный Неодимовый Плащ", 695.92999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Начало уточнения важные роль определения позволяет высокотехнологичная.", "Лоснящийся Деревянный Свитер", 353.92000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Очевидна гражданского соответствующих курс технологий таким выбранный.", "Невероятный Бетонный Сабо", 621.87, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Деятельности постоянный правительством позволяет дальнейших.", "Невероятный Кожанный Ножницы", 510.75999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Обуславливает качественно кадров.", "Интеллектуальный Кожанный Ботинок", 174.49000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Массового систему стороны забывать.", "Эргономичный Кожанный Плащ", 411.63999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Создание интересный укрепления соответствующих высокотехнологичная форм порядка обеспечивает.", "Практичный Натуральный Портмоне", 41.219999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Высокотехнологичная богатый путь разработке качества насущным.", "Интеллектуальный Неодимовый Автомобиль", 662.94000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "А современного обществом также административных воздействия структуры процесс последовательного широким.", "Маленький Хлопковый Автомобиль", 484.23000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Важную социально-экономическое постоянный кругу базы показывает однако на.", "Большой Деревянный Ремень", 26.210000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Порядка обучения широкому.", "Свободный Меховой Кулон", 614.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Соображения организационной однако управление формировании рост.", "Лоснящийся Неодимовый Шарф", 161.80000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Принимаемых прогрессивного показывает социально-ориентированный.", "Лоснящийся Гранитный Носки", 853.90999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сознания рост дальнейших формирования создание обеспечение активности мира.", "Потрясающий Меховой Свитер", 10.85, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Дальнейшее отношении кадров.", "Интеллектуальный Меховой Портмоне", 15.460000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Системы участия национальный выполнять.", "Великолепный Кожанный Клатч", 995.95000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Количественный что важную активизации следует роль социально-ориентированный сознания стороны нами.", "Лоснящийся Резиновый Кулон", 475.94999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Насущным массового вызывает.", "Маленький Меховой Портмоне", 476.10000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Участия повседневная условий важные стороны представляет не.", "Интеллектуальный Натуральный Носки", 445.04000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Инновационный важную сомнений же.", "Большой Хлопковый Кепка", 184.58000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Значимость реализация базы кадров шагов изменений сфера направлений.", "Лоснящийся Неодимовый Майка", 546.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Создаёт социально-экономическое другой соображения новых актуальность.", "Свободный Натуральный Стол", 920.27999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Отметить анализа внедрения модели формирования шагов насущным другой место.", "Великолепный Гранитный Стол", 57.590000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Высокотехнологичная что плановых обществом процесс ресурсосберегающих уточнения.", "Эргономичный Стальной Портмоне", 899.10000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Повседневная консультация практика поставленных очевидна.", "Свободный Гранитный Носки", 490.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Задача активом важную задач широким настолько курс и.", "Грубый Хлопковый Компьютер", 237.37, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Прогрессивного анализа модернизации принципов плановых повседневная.", "Невероятный Деревянный Кулон", 154.25999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Форм инновационный создание активизации насущным повседневной современного проблем уточнения.", "Большой Гранитный Ботинок", 149.25999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Организационной зависит соответствующих укрепления разнообразный модернизации укрепления работы эксперимент кадровой.", "Фантастический Пластиковый Автомобиль", 198.53999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Высокотехнологичная задач демократической значимость.", "Лоснящийся Натуральный Кулон", 444.02999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Намеченных профессионального системы социально-ориентированный прогрессивного принимаемых.", "Большой Пластиковый Сабо", 827.79999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Сфера важные понимание экономической участниками шагов гражданского же соответствующей.", "Невероятный Бетонный Портмоне", 14.869999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Поэтапного дальнейшее повышение изменений оценить степени существующий прогресса таким.", "Маленький Неодимовый Стол", 496.27999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Экономической формирования другой сущности.", "Грубый Пластиковый Компьютер", 709.92999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Значимость предпосылки уровня нашей для позиции для забывать целесообразности рост.", "Невероятный Стальной Кошелек", 309.30000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Стороны зависит уточнения от принципов.", "Свободный Гранитный Куртка", 898.12, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Рост активности постоянное участниками что шагов внедрения соображения.", "Интеллектуальный Меховой Майка", 80.879999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Структура экономической повышение рост укрепления структуры способствует мира участия задач.", "Свободный Меховой Клатч", 523.07000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Последовательного оценить занимаемых воздействия уровня.", "Практичный Бетонный Ножницы", 274.17000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Также другой соображения национальный.", "Практичный Неодимовый Кошелек", 115.56, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Широкому новая высокотехнологичная задач от.", "Великолепный Хлопковый Ремень", 28.359999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Ресурсосберегающих для сфера национальный структуры разработке плановых проект.", "Невероятный Гранитный Портмоне", 772.41999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Важные базы высшего.", "Свободный Гранитный Свитер", 651.07000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Профессионального задача поэтапного принимаемых административных консультация форм профессионального.", "Фантастический Пластиковый Свитер", 622.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Значение поэтапного развития играет место сложившаяся плановых современного новых.", "Великолепный Бетонный Куртка", 637.50999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Требует что разработке создаёт важную сознания этих соображения.", "Потрясающий Неодимовый Плащ", 320.31999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Проект консультация образом определения модернизации предпосылки деятельности задача что постоянное.", "Маленький Пластиковый Автомобиль", 637.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Порядка социально-экономическое постоянное специалистов информационно-пропогандистское поэтапного структуры прогрессивного кадровой значительной.", "Маленький Меховой Клатч", 549.75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Последовательного последовательного отметить.", "Потрясающий Кожанный Клатч", 721.59000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Место инновационный повышению важную организации соответствующих проект.", "Маленький Меховой Кепка", 348.73000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Широким принципов повседневной деятельности условий по равным развития.", "Эргономичный Пластиковый Носки", 86.719999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Не порядка проект различных базы организации технологий.", "Большой Деревянный Свитер", 246.69999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Управление организационной постоянное структура настолько принципов модели.", "Потрясающий Неодимовый Кошелек", 937.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Оценить всего ресурсосберегающих зависит нашей задача.", "Интеллектуальный Натуральный Майка", 831.10000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Же определения последовательного сомнений что другой способствует.", "Потрясающий Деревянный Сабо", 462.38999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Форм в участия разработке требует обуславливает значительной оценить всего.", "Лоснящийся Кожанный Свитер", 647.09000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Позволяет стороны повседневная плановых широким.", "Потрясающий Неодимовый Сабо", 769.16999999999996, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Обуславливает сложившаяся деятельности повседневной.", "Грубый Бетонный Компьютер", 84.290000000000006, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Формированию нас количественный последовательного практика играет курс всего представляет богатый.", "Интеллектуальный Бетонный Компьютер", 598.89999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Таким уровня и проблем прежде обуславливает задач также сознания создаёт.", "Маленький Хлопковый Кепка", 486.42000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Проверки дальнейшее демократической экономической проверки высокотехнологичная.", "Практичный Стальной Плащ", 473.26999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Этих показывает предпосылки с образом модели повседневная за различных значимость.", "Эргономичный Кожанный Свитер", 333.5, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Консультация организационной сознания ресурсосберегающих дальнейшее за.", "Практичный Резиновый Стул", 661.97000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Не намеченных форм.", "Лоснящийся Деревянный Куртка", 888.51999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Рамки оценить оценить целесообразности рост.", "Грубый Деревянный Ремень", 884.44000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Гражданского активом структуры уровня работы повседневная.", "Фантастический Пластиковый Носки", 19.0, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Выбранный последовательного уточнения участия занимаемых последовательного новых.", "Свободный Бетонный Свитер", 547.13999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Обеспечение и на экономической прежде повседневная по подготовке.", "Лоснящийся Стальной Кулон", 436.44999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Качественно технологий изменений формировании соответствующей социально-экономическое.", "Интеллектуальный Меховой Клатч", 114.94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Определения рост различных и намеченных с целесообразности эксперимент.", "Большой Пластиковый Кепка", 932.46000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Шагов прогрессивного демократической развития сущности принимаемых структуры понимание.", "Интеллектуальный Пластиковый Автомобиль", 856.89999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Не поэтапного поэтапного задания идейные укрепления прежде различных.", "Большой Гранитный Кошелек", 465.63 });
        }
    }
}
