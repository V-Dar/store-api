using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class CorrectFieldName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desctiption",
                table: "Products",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "По поэтапного активности прогресса процесс новых качественно начало разработке реализация.", "Большой Кожанный Компьютер", 695.13999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Профессионального отношении форм проверки гражданского за для.", "Маленький Кожанный Кулон", 20.199999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Прогресса стороны национальный сфера требует.", "Эргономичный Деревянный Ремень", 462.19999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "И предпосылки на на систему зависит обучения значимость таким особенности.", "Большой Стальной Ботинок", 971.97000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Новых обуславливает однако административных массового направлений новая кругу направлений.", "Грубый Стальной Кепка", 156.59, "Рекомендуемый" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Рамки собой зависит участия задача соответствующих вызывает модели.", "Эргономичный Хлопковый Носки", 237.90000000000001, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "А массового экономической технологий общественной шагов.", "Маленький Неодимовый Шарф", 68.579999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 2", "В зависит показывает систему актуальность место повседневной задания.", "Невероятный Бетонный Свитер", 555.01999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Создаёт сомнений рамки участия степени путь следует.", "Потрясающий Бетонный Портмоне", 363.56, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Развития системы важные принимаемых практика.", "Интеллектуальный Бетонный Шарф", 713.52999999999997, "Новинка" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "За повышение деятельности.", "Эргономичный Гранитный Носки", 627.79999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Концепция участия определения выполнять.", "Великолепный Неодимовый Компьютер", 143.13999999999999 });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "И вызывает технологий работы профессионального.", "Интеллектуальный Пластиковый Шарф", 799.03999999999996, "Новинка" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Административных количественный поставленных.", "Большой Резиновый Берет", 519.92999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Уточнения разработке структура выполнять таким кадровой.", "Эргономичный Натуральный Куртка", 481.45999999999998, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Технологий обществом задач путь равным.", "Большой Стальной Кошелек", 327.60000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Существующий потребностям поставленных оценить.", "Великолепный Неодимовый Берет", 94.340000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Рост и сфера разработке поэтапного.", "Маленький Пластиковый Автомобиль", 783.60000000000002, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Широкому поставленных обуславливает новая качества процесс не.", "Эргономичный Хлопковый Берет", 567.69000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Мира следует воздействия структура.", "Свободный Хлопковый Сабо", 768.45000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Принимаемых предложений модернизации уточнения.", "Фантастический Хлопковый Клатч", 951.46000000000004, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Потребностям проект роль модели проверки за позиции.", "Практичный Гранитный Компьютер", 287.87, "Популярный" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Позволяет насущным задача уровня формирования.", "Маленький Гранитный Стул", 822.04999999999995, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Постоянный уровня рост значимость.", "Грубый Меховой Носки", 208.31999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Прогресса поставленных создаёт гражданского же систему базы дальнейшее.", "Невероятный Пластиковый Шарф", 752.15999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Новых направлений шагов актуальность структуры внедрения насущным активизации организации.", "Большой Гранитный Кепка", 737.39999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Однако поставленных соответствующей нашей играет для проверки предпосылки.", "Грубый Натуральный Свитер", 265.31, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Направлений формирования место создание стороны базы опыт.", "Невероятный Натуральный Шарф", 660.86000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Соответствующей собой предпосылки широкому значительной проверки отношении.", "Свободный Бетонный Шарф", 543.34000000000003, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Же повышению задач.", "Большой Бетонный Кулон", 864.48000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Реализация стороны потребностям а дальнейших проект равным также социально-ориентированный.", "Грубый Стальной Берет", 769.15999999999997 });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Предложений определения принимаемых и.", "Практичный Меховой Клатч", 583.87, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Современного общества различных внедрения гражданского от соответствующей.", "Потрясающий Гранитный Сабо", 378.91000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Интересный внедрения степени уровня различных поставленных предложений социально-экономическое прогресса формированию.", "Лоснящийся Натуральный Клатч", 164.55000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Общественной ресурсосберегающих принимаемых очевидна развития реализация порядка.", "Интеллектуальный Меховой Ботинок", 935.84000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Отношении прогресса определения сложившаяся.", "Эргономичный Резиновый Кошелек", 593.0, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Активизации модернизации выбранный.", "Практичный Неодимовый Носки", 516.38, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Настолько воздействия от реализация насущным а повседневная административных.", "Интеллектуальный Кожанный Свитер", 327.13999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Таким настолько особенности базы прежде кругу широкому целесообразности способствует обеспечение.", "Большой Стальной Сабо", 284.11000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Последовательного дальнейших сложившаяся форм общественной формировании сложившаяся модели высокотехнологичная формирования.", "Великолепный Деревянный Ремень", 478.69, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "По анализа рамки сознания современного внедрения.", "Невероятный Неодимовый Носки", 631.26999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Модернизации структуры соответствующих обучения очевидна условий место выполнять участия.", "Интеллектуальный Неодимовый Стул", 877.13999999999999, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Обучения повседневная общественной базы новая настолько вызывает курс разработке.", "Невероятный Деревянный Носки", 900.34000000000003, "Рекомендуемый" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Структура кадров общества проверки забывать позволяет.", "Великолепный Бетонный Автомобиль", 38.689999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Равным интересный развития напрямую различных ресурсосберегающих высшего не.", "Свободный Бетонный Кошелек", 147.16, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "За анализа общества широким.", "Лоснящийся Неодимовый Ножницы", 338.38, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Укрепления реализация обществом а.", "Невероятный Деревянный Компьютер", 399.55000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Разнообразный активности специалистов развития.", "Маленький Меховой Портмоне", 754.67999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Роль этих технологий современного развития проверки количественный.", "Свободный Резиновый Кепка", 942.91999999999996 });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Настолько этих требует.", "Эргономичный Кожанный Стол", 909.24000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Участия активизации не.", "Грубый Хлопковый Клатч", 937.15999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Очевидна принципов качественно организационной активизации систему этих национальный уточнения.", "Свободный Стальной Клатч", 428.37, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Нами широкому обучения целесообразности рост поэтапного поэтапного.", "Фантастический Неодимовый Сабо", 767.27999999999997, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Таким выбранный массового рост обучения изменений курс повышению реализация.", "Эргономичный Деревянный Плащ", 895.26999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Особенности задача базы форм принимаемых способствует порядка.", "Лоснящийся Пластиковый Компьютер", 62.460000000000001 });

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
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Разработке технологий позиции активизации для предложений инновационный собой систему проект.", "Невероятный Натуральный Кошелек", 258.74000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Очевидна в социально-экономическое нашей повышению.", "Свободный Резиновый Шарф", 139.61000000000001 });

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
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Влечёт проверки процесс определения повседневная систему значительной прогресса повышение нами.", "Грубый Пластиковый Сабо", 235.47, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Играет гражданского выполнять высшего.", "Свободный Бетонный Стол", 639.03999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Организационной значимость качества плановых анализа базы реализация.", "Невероятный Меховой Клатч", 196.75, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Широкому материально-технической условий нашей дальнейших играет формированию выполнять соответствующих.", "Маленький Неодимовый Стул", 589.17999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Собой обучения внедрения путь.", "Практичный Деревянный Стол", 791.94000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Профессионального практика соответствующих курс шагов.", "Невероятный Стальной Берет", 314.74000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Позволяет административных а степени консультация активом высокотехнологичная этих.", "Маленький Меховой Сабо", 535.34000000000003, "Популярный" });

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
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Принимаемых роль проект сфера значительной.", "Практичный Деревянный Клатч", 545.79999999999995 });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 3", "Повышение анализа вызывает от гражданского модели рамки.", "Большой Меховой Ремень", 177.47999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Name", "Price", "SpecialTag" },
                values: new object[] { "Практика нас соображения.", "Фантастический Кожанный Стул", 5.5899999999999999, "Новинка" });

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
                columns: new[] { "Category", "Description", "Name", "Price" },
                values: new object[] { "Категория 1", "Формированию системы уровня структуры прогресса.", "Маленький Резиновый Стол", 190.84 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Активизации ресурсосберегающих также инновационный формированию национальный позволяет и модели работы.", "Большой Бетонный Куртка", 111.37 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Desctiption");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Определения курс формированию качества формировании с активизации начало.", "Грубый Хлопковый Кулон", 728.97000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Сознания качественно интересный административных ресурсосберегающих количественный активизации курс структура.", "Эргономичный Гранитный Ножницы", 408.32999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Количественный национальный таким национальный порядка социально-экономическое проверки.", "Великолепный Неодимовый Ножницы", 994.49000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Не повышение понимание экономической значительной эксперимент.", "Свободный Натуральный Носки", 256.56, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Активности новых собой технологий показывает проект нашей повседневной с.", "Практичный Пластиковый Берет", 578.46000000000004, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Деятельности в показывает.", "Грубый Неодимовый Кепка", 301.67000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Анализа структура показывает концепция систему.", "Фантастический Неодимовый Стул", 918.88999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Базы создание участия роль уровня последовательного собой социально-ориентированный кадров.", "Свободный Пластиковый Берет", 142.59, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Прогрессивного от равным важную зависит настолько соответствующей модель.", "Великолепный Резиновый Шарф", 304.31999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Нами общественной и задач обуславливает развития модель эксперимент поставленных актуальность.", "Лоснящийся Натуральный Свитер", 606.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Форм принимаемых систему современного.", "Свободный Неодимовый Куртка", 433.06999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Организационной модернизации в подготовке проект дальнейших специалистов.", "Свободный Стальной Ремень", 784.50999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Влечёт сущности прогресса показывает широкому.", "Практичный Бетонный Кошелек", 268.27999999999997, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Рамки социально-экономическое современного деятельности информационно-пропогандистское повседневной.", "Фантастический Стальной Клатч", 258.24000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Не степени ресурсосберегающих технологий укрепления социально-экономическое широким дальнейших прогрессивного социально-ориентированный.", "Грубый Кожанный Портмоне", 97.180000000000007 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Прежде концепция участниками кадров организационной существующий высшего позволяет занимаемых.", "Свободный Деревянный Автомобиль", 703.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Путь сложившаяся начало широким.", "Фантастический Стальной Сабо", 251.38999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Таким массового принимаемых практика активизации всего.", "Эргономичный Кожанный Компьютер", 480.27999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Влечёт ресурсосберегающих сложившаяся.", "Большой Гранитный Кепка", 824.77999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Не сфера предпосылки.", "Невероятный Меховой Носки", 963.70000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Модернизации выбранный принимаемых значимость активизации.", "Великолепный Стальной Клатч", 62.079999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Изменений правительством систему.", "Свободный Деревянный Куртка", 448.32999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Повышение от развития принципов забывать сфера.", "Маленький Натуральный Автомобиль", 774.70000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Же деятельности широким для представляет обуславливает информационно-пропогандистское.", "Грубый Хлопковый Плащ", 829.74000000000001, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Материально-технической определения образом высшего.", "Интеллектуальный Пластиковый Клатч", 751.25999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Структура новая образом.", "Практичный Бетонный Кепка", 952.36000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поставленных структуры повседневная обществом.", "Эргономичный Деревянный Компьютер", 42.759999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Профессионального с разработке принимаемых.", "Практичный Деревянный Кепка", 885.11000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Кадров сознания понимание поставленных национальный принимаемых общества за опыт прежде.", "Великолепный Деревянный Свитер", 829.60000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Деятельности выполнять высокотехнологичная.", "Эргономичный Хлопковый Ножницы", 492.06999999999999, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Показывает выбранный системы активом постоянный прогресса практика.", "Потрясающий Натуральный Кошелек", 635.04999999999995, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Работы интересный существующий кадров вызывает работы рост идейные отношении.", "Невероятный Хлопковый Клатч", 908.76999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Структура этих эксперимент структура сомнений шагов высокотехнологичная активом забывать.", "Лоснящийся Кожанный Куртка", 1.6100000000000001, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Демократической нас прогресса повышение деятельности проверки прогресса.", "Фантастический Неодимовый Берет", 30.25, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поэтапного модернизации административных определения создание широкому.", "Фантастический Резиновый Свитер", 403.29000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сложившаяся воздействия модернизации кругу систему демократической предпосылки анализа работы.", "Маленький Неодимовый Носки", 963.23000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Активизации разнообразный участниками значительной качественно насущным развития позволяет.", "Практичный Стальной Кулон", 951.23000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Потребностям шагов активности материально-технической постоянное модели демократической уточнения соображения работы.", "Эргономичный Деревянный Кошелек", 156.91, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Последовательного по зависит степени другой другой.", "Эргономичный Резиновый Свитер", 935.28999999999996, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Изменений начало профессионального отметить прогрессивного понимание способствует значимость обучения.", "Лоснящийся Резиновый Носки", 789.19000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Процесс участия новых.", "Свободный Деревянный Автомобиль", 871.25, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Же базы концепция сфера формирования повышение соответствующей всего.", "Грубый Гранитный Портмоне", 972.80999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Роль работы высокотехнологичная повышению таким забывать финансовых.", "Грубый Деревянный Майка", 118.65000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Роль существующий ресурсосберегающих напрямую условий курс повседневной консультация значимость.", "Интеллектуальный Стальной Компьютер", 880.60000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Технологий общества занимаемых анализа не формирования дальнейшее выбранный рамки.", "Великолепный Натуральный Портмоне", 845.94000000000005, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Целесообразности новых влечёт намеченных позволяет общества.", "Фантастический Пластиковый Портмоне", 301.06, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Базы всего нас управление значимость.", "Лоснящийся Кожанный Свитер", 882.46000000000004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Модель с этих соответствующей важную что формировании формировании стороны нас.", "Эргономичный Деревянный Свитер", 278.85000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Понимание проект профессионального правительством проблем значение же не идейные управление.", "Эргономичный Натуральный Носки", 995.64999999999998, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "По формирования социально-экономическое.", "Лоснящийся Натуральный Кошелек", 486.81, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Зависит профессионального способствует проект поэтапного выбранный.", "Грубый Хлопковый Шарф", 701.25999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 3", "Же эксперимент организации дальнейших потребностям роль разнообразный новая обеспечение рост.", "Лоснящийся Неодимовый Носки", 672.79999999999995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Уровня актуальность отметить реализация внедрения.", "Лоснящийся Хлопковый Шарф", 563.20000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Укрепления предложений широкому кадров.", "Великолепный Натуральный Шарф", 512.30999999999995, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Участниками обуславливает с роль.", "Практичный Пластиковый Плащ", 382.98000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Правительством социально-экономическое прогресса правительством.", "Интеллектуальный Натуральный Кулон", 564.83000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Разнообразный воздействия не повседневная соответствующей.", "Свободный Стальной Ножницы", 996.10000000000002, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Создание повышение нас базы правительством.", "Фантастический Резиновый Плащ", 114.22, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Формированию равным участия обеспечивает требует консультация отношении.", "Маленький Меховой Кулон", 139.52000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Различных позволяет предложений систему определения формировании общественной форм.", "Фантастический Стальной Кошелек", 329.88999999999999, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Экономической богатый массового формировании.", "Практичный Хлопковый Кулон", 196.62, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Сфера сознания широким повседневная.", "Свободный Стальной Шарф", 722.08000000000004, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Равным за для повседневной модель различных условий играет качественно опыт.", "Свободный Меховой Сабо", 483.98000000000002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Таким с напрямую позволяет участия также и разнообразный опыт.", "Эргономичный Хлопковый Кепка", 51.329999999999998, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Специалистов создаёт повседневная задач деятельности.", "Маленький Стальной Кулон", 783.16999999999996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 3", "Модернизации особенности изменений работы обществом значимость следует высокотехнологичная участия.", "Фантастический Гранитный Майка", 371.36000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Нами технологий соответствующей занимаемых нашей также богатый.", "Эргономичный Кожанный Носки", 903.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Равным образом качества роль в забывать постоянный место инновационный уточнения.", "Большой Натуральный Майка", 270.55000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Внедрения общества воздействия последовательного.", "Грубый Кожанный Ножницы", 122.98999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Анализа зависит демократической повышению деятельности технологий понимание.", "Великолепный Натуральный Кулон", 854.52999999999997, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Очевидна следует напрямую значимость реализация повышению степени.", "Свободный Пластиковый Сабо", 160.91999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Понимание особенности же же по подготовке создаёт.", "Маленький Гранитный Клатч", 568.44000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 1", "Развития развития отметить гражданского отношении прогресса представляет показывает.", "Эргономичный Хлопковый Портмоне", 849.82000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Играет обуславливает общества концепция ресурсосберегающих.", "Фантастический Гранитный Стул", 25.859999999999999, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 3", "Обеспечение же прежде широкому повседневная требует обеспечивает.", "Практичный Резиновый Шарф", 597.09000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Социально-ориентированный от всего правительством таким позволяет качественно прогресса различных.", "Потрясающий Натуральный Носки", 257.55000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Путь общества для практика базы.", "Свободный Хлопковый Клатч", 924.26999999999998, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Позволяет актуальность модель образом формированию.", "Потрясающий Деревянный Кулон", 777.88999999999999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Формирования активизации насущным реализация проект активизации участниками равным.", "Эргономичный Кожанный Портмоне", 514.44000000000005 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Не разработке обучения разнообразный роль финансовых прогресса процесс.", "Практичный Кожанный Кепка", 798.66999999999996, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Обеспечение настолько инновационный.", "Грубый Натуральный Стол", 510.97000000000003, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Позволяет правительством воздействия прогресса зависит разработке модели формирования.", "Эргономичный Гранитный Кепка", 547.30999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Также насущным широким новая.", "Потрясающий Стальной Компьютер", 104.48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Повседневной соображения что богатый таким занимаемых сущности концепция общества оценить.", "Великолепный Стальной Стул", 822.46000000000004, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Интересный новая что принимаемых принимаемых а оценить.", "Маленький Деревянный Кепка", 533.19000000000005, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Предложений этих плановых.", "Грубый Резиновый Ботинок", 815.35000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Поэтапного профессионального принципов существующий выполнять укрепления формирования обуславливает.", "Эргономичный Неодимовый Майка", 751.80999999999995, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Определения в важные соображения социально-экономическое предпосылки выбранный.", "Потрясающий Неодимовый Кулон", 660.77999999999997, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Потребностям позиции демократической структуры от реализация.", "Эргономичный Натуральный Берет", 127.81, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Дальнейшее принципов дальнейшее широкому идейные.", "Практичный Резиновый Плащ", 834.59000000000003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Образом реализация определения укрепления кадровой.", "Свободный Неодимовый Стол", 295.48000000000002, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Не определения обуславливает важные уточнения повседневная организационной.", "Эргономичный Меховой Портмоне", 432.54000000000002, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 1", "Таким сущности предложений представляет укрепления за играет и.", "Эргономичный Меховой Клатч", 544.99000000000001, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 2", "Социально-ориентированный сомнений с забывать значение базы плановых структуры организации важную.", "Свободный Кожанный Кулон", 103.64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Профессионального вызывает прогресса опыт модели.", "Потрясающий Стальной Шарф", 772.20000000000005, "Рекомендуемый" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Создаёт собой кадровой нами проект потребностям.", "Интеллектуальный Натуральный Шарф", 341.06, "Новинка" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Desctiption", "Name", "Price" },
                values: new object[] { "Категория 3", "Технологий поэтапного системы уровня равным активом.", "Эргономичный Стальной Плащ", 439.76999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Desctiption", "Name", "Price" },
                values: new object[] { "Нашей проверки намеченных постоянный сложившаяся принципов задача предложений укрепления анализа.", "Фантастический Пластиковый Плащ", 518.24000000000001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 2", "Плановых повседневная национальный качественно отметить дальнейших рамки требует отношении модели.", "Фантастический Натуральный Ботинок", 591.72000000000003, "Популярный" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Desctiption", "Name", "Price", "SpecialTag" },
                values: new object[] { "Категория 3", "Различных широким дальнейшее материально-технической информационно-пропогандистское разнообразный высшего предпосылки также.", "Маленький Стальной Ножницы", 391.25, "Рекомендуемый" });
        }
    }
}
