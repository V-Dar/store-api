using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class AddShoppingCartAndCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Уточнения системы поставленных способствует уровня не различных форм предложений.", "Эргономичный Бетонный Ножницы", 33.939999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Же высшего выполнять деятельности равным управление.", "Потрясающий Стальной Кулон", 516.69000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Качественно позиции предпосылки технологий прежде по инновационный.", "Интеллектуальный Кожанный Шарф", 441.54000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Поставленных мира повышение.", "Грубый Кожанный Плащ", 291.33999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Информационно-пропогандистское участниками повышение таким не.", "Практичный Хлопковый Кулон", 29.219999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Рост следует демократической повышению качества предпосылки финансовых.", "Потрясающий Хлопковый Кошелек", 166.38, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Инновационный общества задача.", "Лоснящийся Натуральный Стол", 924.13999999999999, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Поэтапного показывает консультация нами.", "Великолепный Гранитный Стул", 322.85000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Что структуры экономической постоянное нас сущности.", "Маленький Натуральный Берет", 857.75, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Консультация активности организации важную собой управление следует.", "Грубый Гранитный Плащ", 569.84000000000003 });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Базы консультация реализация поэтапного высшего обществом.", "Эргономичный Гранитный Кепка", 616.0, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Информационно-пропогандистское соответствующих подготовке качества сложившаяся экономической.", "Эргономичный Хлопковый Майка", 590.69000000000005 });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Понимание широким и задач проблем целесообразности проект.", "Грубый Деревянный Автомобиль", 691.5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поэтапного системы плановых путь реализация также намеченных подготовке.", "Потрясающий Меховой Носки", 639.12, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Занимаемых место постоянный позиции постоянное играет кадровой базы.", "Невероятный Гранитный Портмоне", 876.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Особенности управление сущности кругу таким деятельности сущности плановых базы социально-ориентированный.", "Грубый Резиновый Портмоне", 236.91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Обуславливает материально-технической вызывает.", "Практичный Натуральный Берет", 594.28999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Принципов представляет правительством на не соответствующей другой практика модели.", "Фантастический Кожанный Шарф", 940.07000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Опыт участия укрепления для обуславливает для специалистов сомнений прогресса.", "Большой Неодимовый Компьютер", 282.38999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Занимаемых правительством участниками всего внедрения нами целесообразности последовательного различных разработке.", "Большой Меховой Стул", 297.95999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "По путь структура позволяет прежде роль богатый.", "Великолепный Неодимовый Кулон", 560.05999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Прежде потребностям образом качественно.", "Великолепный Кожанный Стул", 890.65999999999997, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Предложений различных последовательного позволяет следует направлений проект.", "Практичный Меховой Кошелек", 243.02000000000001, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Начало уточнения важные роль определения позволяет высокотехнологичная.", "Лоснящийся Деревянный Свитер", 353.92000000000002, "Популярный" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Массового систему стороны забывать.", "Эргономичный Кожанный Плащ", 411.63999999999999, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Высокотехнологичная богатый путь разработке качества насущным.", "Интеллектуальный Неодимовый Автомобиль", 662.94000000000005, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Важную социально-экономическое постоянный кругу базы показывает однако на.", "Большой Деревянный Ремень", 26.210000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Порядка обучения широкому.", "Свободный Меховой Кулон", 614.87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Соображения организационной однако управление формировании рост.", "Лоснящийся Неодимовый Шарф", 161.80000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Принимаемых прогрессивного показывает социально-ориентированный.", "Лоснящийся Гранитный Носки", 853.90999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Сознания рост дальнейших формирования создание обеспечение активности мира.", "Потрясающий Меховой Свитер", 10.85 });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Системы участия национальный выполнять.", "Великолепный Кожанный Клатч", 995.95000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Количественный что важную активизации следует роль социально-ориентированный сознания стороны нами.", "Лоснящийся Резиновый Кулон", 475.94999999999999, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Участия повседневная условий важные стороны представляет не.", "Интеллектуальный Натуральный Носки", 445.04000000000002, "Популярный" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Значимость реализация базы кадров шагов изменений сфера направлений.", "Лоснящийся Неодимовый Майка", 546.52999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Создаёт социально-экономическое другой соображения новых актуальность.", "Свободный Натуральный Стол", 920.27999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Отметить анализа внедрения модели формирования шагов насущным другой место.", "Великолепный Гранитный Стол", 57.590000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Высокотехнологичная что плановых обществом процесс ресурсосберегающих уточнения.", "Эргономичный Стальной Портмоне", 899.10000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Повседневная консультация практика поставленных очевидна.", "Свободный Гранитный Носки", 490.74000000000001, "Популярный" });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Прогрессивного анализа модернизации принципов плановых повседневная.", "Невероятный Деревянный Кулон", 154.25999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Форм инновационный создание активизации насущным повседневной современного проблем уточнения.", "Большой Гранитный Ботинок", 149.25999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Организационной зависит соответствующих укрепления разнообразный модернизации укрепления работы эксперимент кадровой.", "Фантастический Пластиковый Автомобиль", 198.53999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Высокотехнологичная задач демократической значимость.", "Лоснящийся Натуральный Кулон", 444.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Намеченных профессионального системы социально-ориентированный прогрессивного принимаемых.", "Большой Пластиковый Сабо", 827.79999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Сфера важные понимание экономической участниками шагов гражданского же соответствующей.", "Невероятный Бетонный Портмоне", 14.869999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Поэтапного дальнейшее повышение изменений оценить степени существующий прогресса таким.", "Маленький Неодимовый Стол", 496.27999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Экономической формирования другой сущности.", "Грубый Пластиковый Компьютер", 709.92999999999995, "Новинка" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Структура экономической повышение рост укрепления структуры способствует мира участия задач.", "Свободный Меховой Клатч", 523.07000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Последовательного оценить занимаемых воздействия уровня.", "Практичный Бетонный Ножницы", 274.17000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Также другой соображения национальный.", "Практичный Неодимовый Кошелек", 115.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Широкому новая высокотехнологичная задач от.", "Великолепный Хлопковый Ремень", 28.359999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Ресурсосберегающих для сфера национальный структуры разработке плановых проект.", "Невероятный Гранитный Портмоне", 772.41999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Важные базы высшего.", "Свободный Гранитный Свитер", 651.07000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Профессионального задача поэтапного принимаемых административных консультация форм профессионального.", "Фантастический Пластиковый Свитер", 622.75999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Значение поэтапного развития играет место сложившаяся плановых современного новых.", "Великолепный Бетонный Куртка", 637.50999999999999 });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Проект консультация образом определения модернизации предпосылки деятельности задача что постоянное.", "Маленький Пластиковый Автомобиль", 637.87, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Порядка социально-экономическое постоянное специалистов информационно-пропогандистское поэтапного структуры прогрессивного кадровой значительной.", "Маленький Меховой Клатч", 549.75, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Последовательного последовательного отметить.", "Потрясающий Кожанный Клатч", 721.59000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Место инновационный повышению важную организации соответствующих проект.", "Маленький Меховой Кепка", 348.73000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Широким принципов повседневной деятельности условий по равным развития.", "Эргономичный Пластиковый Носки", 86.719999999999999 });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Управление организационной постоянное структура настолько принципов модели.", "Потрясающий Неодимовый Кошелек", 937.02999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Оценить всего ресурсосберегающих зависит нашей задача.", "Интеллектуальный Натуральный Майка", 831.10000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Же определения последовательного сомнений что другой способствует.", "Потрясающий Деревянный Сабо", 462.38999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Форм в участия разработке требует обуславливает значительной оценить всего.", "Лоснящийся Кожанный Свитер", 647.09000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Позволяет стороны повседневная плановых широким.", "Потрясающий Неодимовый Сабо", 769.16999999999996, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Обуславливает сложившаяся деятельности повседневной.", "Грубый Бетонный Компьютер", 84.290000000000006 });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Таким уровня и проблем прежде обуславливает задач также сознания создаёт.", "Маленький Хлопковый Кепка", 486.42000000000002 });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Не намеченных форм.", "Лоснящийся Деревянный Куртка", 888.51999999999998, "Рекомендуемый" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Гражданского активом структуры уровня работы повседневная.", "Фантастический Пластиковый Носки", 19.0, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Выбранный последовательного уточнения участия занимаемых последовательного новых.", "Свободный Бетонный Свитер", 547.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Обеспечение и на экономической прежде повседневная по подготовке.", "Лоснящийся Стальной Кулон", 436.44999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Качественно технологий изменений формировании соответствующей социально-экономическое.", "Интеллектуальный Меховой Клатч", 114.94, "Популярный" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Не поэтапного поэтапного задания идейные укрепления прежде различных.", "Большой Гранитный Кошелек", 465.63, "Новинка" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingCartId",
                table: "CartItems",
                column: "ShoppingCartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "По поэтапного активности прогресса процесс новых качественно начало разработке реализация.", "Большой Кожанный Компьютер", 695.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Профессионального отношении форм проверки гражданского за для.", "Маленький Кожанный Кулон", 20.199999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Прогресса стороны национальный сфера требует.", "Эргономичный Деревянный Ремень", 462.19999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "И предпосылки на на систему зависит обучения значимость таким особенности.", "Большой Стальной Ботинок", 971.97000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Новых обуславливает однако административных массового направлений новая кругу направлений.", "Грубый Стальной Кепка", 156.59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Нами целесообразности правительством разнообразный занимаемых демократической.", "Практичный Бетонный Стул", 262.14999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Рамки собой зависит участия задача соответствующих вызывает модели.", "Эргономичный Хлопковый Носки", 237.90000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Материально-технической создаёт богатый поэтапного также задания актуальность определения административных предложений.", "Грубый Бетонный Кулон", 182.93000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "А массового экономической технологий общественной шагов.", "Маленький Неодимовый Шарф", 68.579999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "В зависит показывает систему актуальность место повседневной задания.", "Невероятный Бетонный Свитер", 555.01999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Создаёт сомнений рамки участия степени путь следует.", "Потрясающий Бетонный Портмоне", 363.56 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Развития системы важные принимаемых практика.", "Интеллектуальный Бетонный Шарф", 713.52999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Другой прогрессивного порядка понимание и принимаемых социально-ориентированный.", "Потрясающий Неодимовый Кошелек", 826.50999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "За повышение деятельности.", "Эргономичный Гранитный Носки", 627.79999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Концепция участия определения выполнять.", "Великолепный Неодимовый Компьютер", 143.13999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Участниками вызывает развития мира активности.", "Интеллектуальный Деревянный Автомобиль", 569.95000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "И вызывает технологий работы профессионального.", "Интеллектуальный Пластиковый Шарф", 799.03999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Формированию организации отметить подготовке сущности проблем практика собой реализация.", "Маленький Гранитный Кулон", 800.96000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Административных количественный поставленных.", "Большой Резиновый Берет", 519.92999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Уточнения разработке структура выполнять таким кадровой.", "Эргономичный Натуральный Куртка", 481.45999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Шагов порядка ресурсосберегающих повышению также задания значительной прогрессивного в.", "Великолепный Стальной Автомобиль", 708.32000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Технологий обществом задач путь равным.", "Большой Стальной Кошелек", 327.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Существующий потребностям поставленных оценить.", "Великолепный Неодимовый Берет", 94.340000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Рост и сфера разработке поэтапного.", "Маленький Пластиковый Автомобиль", 783.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Порядка профессионального ресурсосберегающих задач идейные.", "Большой Гранитный Ремень", 486.94, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Широкому поставленных обуславливает новая качества процесс не.", "Эргономичный Хлопковый Берет", 567.69000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Мира следует воздействия структура.", "Свободный Хлопковый Сабо", 768.45000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Принимаемых предложений модернизации уточнения.", "Фантастический Хлопковый Клатч", 951.46000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Напрямую базы специалистов качественно задач напрямую.", "Великолепный Натуральный Плащ", 30.260000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Определения повседневной выполнять модели повседневная дальнейшее практика высшего нас повседневной.", "Грубый Пластиковый Берет", 789.15999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Потребностям проект роль модели проверки за позиции.", "Практичный Гранитный Компьютер", 287.87, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Соответствующей проверки создание.", "Большой Деревянный Портмоне", 911.80999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Новая организационной позволяет за нашей.", "Практичный Хлопковый Клатч", 681.74000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Богатый сознания консультация участниками.", "Невероятный Неодимовый Кошелек", 985.10000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Позволяет насущным задача уровня формирования.", "Маленький Гранитный Стул", 822.04999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Курс структура идейные повышение поэтапного существующий анализа направлений шагов не.", "Маленький Гранитный Плащ", 632.83000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Постоянный уровня рост значимость.", "Грубый Меховой Носки", 208.31999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Прогресса поставленных создаёт гражданского же систему базы дальнейшее.", "Невероятный Пластиковый Шарф", 752.15999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Новых направлений шагов актуальность структуры внедрения насущным активизации организации.", "Большой Гранитный Кепка", 737.39999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Однако поставленных соответствующей нашей играет для проверки предпосылки.", "Грубый Натуральный Свитер", 265.31, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Направлений формирования место создание стороны базы опыт.", "Невероятный Натуральный Шарф", 660.86000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Соответствующей собой предпосылки широкому значительной проверки отношении.", "Свободный Бетонный Шарф", 543.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Же повышению задач.", "Большой Бетонный Кулон", 864.48000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Реализация стороны потребностям а дальнейших проект равным также социально-ориентированный.", "Грубый Стальной Берет", 769.15999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Шагов обуславливает в.", "Интеллектуальный Пластиковый Стол", 367.80000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Предложений определения принимаемых и.", "Практичный Меховой Клатч", 583.87, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Современного общества различных внедрения гражданского от соответствующей.", "Потрясающий Гранитный Сабо", 378.91000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Интересный внедрения степени уровня различных поставленных предложений социально-экономическое прогресса формированию.", "Лоснящийся Натуральный Клатч", 164.55000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Общественной ресурсосберегающих принимаемых очевидна развития реализация порядка.", "Интеллектуальный Меховой Ботинок", 935.84000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Отношении прогресса определения сложившаяся.", "Эргономичный Резиновый Кошелек", 593.0, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Активизации модернизации выбранный.", "Практичный Неодимовый Носки", 516.38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Настолько воздействия от реализация насущным а повседневная административных.", "Интеллектуальный Кожанный Свитер", 327.13999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Таким настолько особенности базы прежде кругу широкому целесообразности способствует обеспечение.", "Большой Стальной Сабо", 284.11000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Последовательного дальнейших сложившаяся форм общественной формировании сложившаяся модели высокотехнологичная формирования.", "Великолепный Деревянный Ремень", 478.69, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "По анализа рамки сознания современного внедрения.", "Невероятный Неодимовый Носки", 631.26999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Модернизации структуры соответствующих обучения очевидна условий место выполнять участия.", "Интеллектуальный Неодимовый Стул", 877.13999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "А курс повседневной постоянный значение.", "Эргономичный Резиновый Кулон", 111.81999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Обучения повседневная общественной базы новая настолько вызывает курс разработке.", "Невероятный Деревянный Носки", 900.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Подготовке соответствующей предложений деятельности значение курс обществом значительной.", "Практичный Деревянный Клатч", 526.32000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Структура кадров общества проверки забывать позволяет.", "Великолепный Бетонный Автомобиль", 38.689999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Равным интересный развития напрямую различных ресурсосберегающих высшего не.", "Свободный Бетонный Кошелек", 147.16, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "За анализа общества широким.", "Лоснящийся Неодимовый Ножницы", 338.38, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Подготовке представляет забывать на насущным напрямую.", "Грубый Меховой Клатч", 288.62 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Общества позволяет качества реализация.", "Лоснящийся Деревянный Ножницы", 939.65999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Укрепления реализация обществом а.", "Невероятный Деревянный Компьютер", 399.55000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Разнообразный активности специалистов развития.", "Маленький Меховой Портмоне", 754.67999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Роль этих технологий современного развития проверки количественный.", "Свободный Резиновый Кепка", 942.91999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Ресурсосберегающих повседневная важные.", "Грубый Хлопковый Кошелек", 805.72000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Настолько этих требует.", "Эргономичный Кожанный Стол", 909.24000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Участия активизации не.", "Грубый Хлопковый Клатч", 937.15999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Очевидна принципов качественно организационной активизации систему этих национальный уточнения.", "Свободный Стальной Клатч", 428.37 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Нами широкому обучения целесообразности рост поэтапного поэтапного.", "Фантастический Неодимовый Сабо", 767.27999999999997 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Национальный социально-ориентированный требует качественно требует.", "Практичный Пластиковый Носки", 46.270000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Таким выбранный массового рост обучения изменений курс повышению реализация.", "Эргономичный Деревянный Плащ", 895.26999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Особенности задача базы форм принимаемых способствует порядка.", "Лоснящийся Пластиковый Компьютер", 62.460000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Материально-технической правительством предпосылки гражданского.", "Лоснящийся Резиновый Стол", 128.75999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Разработке технологий позиции активизации для предложений инновационный собой систему проект.", "Невероятный Натуральный Кошелек", 258.74000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Очевидна в социально-экономическое нашей повышению.", "Свободный Резиновый Шарф", 139.61000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "По новая прогресса.", "Свободный Натуральный Стол", 239.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Плановых модернизации работы изменений.", "Эргономичный Кожанный Компьютер", 673.51999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Влечёт проверки процесс определения повседневная систему значительной прогресса повышение нами.", "Грубый Пластиковый Сабо", 235.47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Порядка качества анализа.", "Грубый Пластиковый Свитер", 54.030000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Играет гражданского выполнять высшего.", "Свободный Бетонный Стол", 639.03999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Организационной значимость качества плановых анализа базы реализация.", "Невероятный Меховой Клатч", 196.75, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Широкому материально-технической условий нашей дальнейших играет формированию выполнять соответствующих.", "Маленький Неодимовый Стул", 589.17999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Собой обучения внедрения путь.", "Практичный Деревянный Стол", 791.94000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Профессионального практика соответствующих курс шагов.", "Невероятный Стальной Берет", 314.74000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Позволяет административных а степени консультация активом высокотехнологичная этих.", "Маленький Меховой Сабо", 535.34000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Участия соответствующих административных демократической финансовых способствует.", "Великолепный Резиновый Шарф", 676.30999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Принимаемых роль проект сфера значительной.", "Практичный Деревянный Клатч", 545.79999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Важную инновационный же структуры путь позиции условий прогресса кадровой.", "Большой Гранитный Ремень", 718.97000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Поставленных широким постоянное внедрения кругу плановых.", "Грубый Натуральный Шарф", 507.04000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Высшего активом систему.", "Интеллектуальный Стальной Кулон", 659.77999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Повышение анализа вызывает от гражданского модели рамки.", "Большой Меховой Ремень", 177.47999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "Практика нас соображения.", "Фантастический Кожанный Стул", 5.5899999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Порядка соответствующих от инновационный настолько консультация поэтапного информационно-пропогандистское обеспечивает задания.", "Грубый Кожанный Берет", 821.61000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Формированию системы уровня структуры прогресса.", "Маленький Резиновый Стол", 190.84, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Активизации ресурсосберегающих также инновационный формированию национальный позволяет и модели работы.", "Большой Бетонный Куртка", 111.37, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Таким значение последовательного воздействия опыт системы.", "Фантастический Меховой Шарф", 415.00999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Напрямую активности широким.", "Интеллектуальный Хлопковый Стул", 592.88999999999999, "Популярный" });
        }
    }
}
