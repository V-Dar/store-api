using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Desctiption", "Image", "Name", "Price", "SpecialTag" },
                values: new object[,]
                {
                    { 1, "Категория 3", "Определения курс формированию качества формировании с активизации начало.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Хлопковый Кулон", 728.97000000000003, "Популярный" },
                    { 2, "Категория 1", "Сознания качественно интересный административных ресурсосберегающих количественный активизации курс структура.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Гранитный Ножницы", 408.32999999999998, "Рекомендуемый" },
                    { 3, "Категория 1", "Количественный национальный таким национальный порядка социально-экономическое проверки.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Неодимовый Ножницы", 994.49000000000001, "Новинка" },
                    { 4, "Категория 2", "Не повышение понимание экономической значительной эксперимент.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Натуральный Носки", 256.56, "Популярный" },
                    { 5, "Категория 2", "Активности новых собой технологий показывает проект нашей повседневной с.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Пластиковый Берет", 578.46000000000004, "Популярный" },
                    { 6, "Категория 2", "Деятельности в показывает.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Неодимовый Кепка", 301.67000000000002, "Новинка" },
                    { 7, "Категория 3", "Анализа структура показывает концепция систему.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Неодимовый Стул", 918.88999999999999, "Новинка" },
                    { 8, "Категория 3", "Базы создание участия роль уровня последовательного собой социально-ориентированный кадров.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Пластиковый Берет", 142.59, "Новинка" },
                    { 9, "Категория 2", "Прогрессивного от равным важную зависит настолько соответствующей модель.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Резиновый Шарф", 304.31999999999999, "Новинка" },
                    { 10, "Категория 1", "Нами общественной и задач обуславливает развития модель эксперимент поставленных актуальность.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Натуральный Свитер", 606.60000000000002, "Рекомендуемый" },
                    { 11, "Категория 1", "Форм принимаемых систему современного.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Неодимовый Куртка", 433.06999999999999, "Новинка" },
                    { 12, "Категория 3", "Организационной модернизации в подготовке проект дальнейших специалистов.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Стальной Ремень", 784.50999999999999, "Рекомендуемый" },
                    { 13, "Категория 1", "Влечёт сущности прогресса показывает широкому.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Бетонный Кошелек", 268.27999999999997, "Рекомендуемый" },
                    { 14, "Категория 3", "Рамки социально-экономическое современного деятельности информационно-пропогандистское повседневной.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Стальной Клатч", 258.24000000000001, "Новинка" },
                    { 15, "Категория 3", "Не степени ресурсосберегающих технологий укрепления социально-экономическое широким дальнейших прогрессивного социально-ориентированный.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Кожанный Портмоне", 97.180000000000007, "Новинка" },
                    { 16, "Категория 2", "Прежде концепция участниками кадров организационной существующий высшего позволяет занимаемых.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Деревянный Автомобиль", 703.36000000000001, "Популярный" },
                    { 17, "Категория 1", "Путь сложившаяся начало широким.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Стальной Сабо", 251.38999999999999, "Популярный" },
                    { 18, "Категория 2", "Таким массового принимаемых практика активизации всего.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Кожанный Компьютер", 480.27999999999997, "Новинка" },
                    { 19, "Категория 3", "Влечёт ресурсосберегающих сложившаяся.", "https://cataas.com/cat?width=100&cat?height=:100", "Большой Гранитный Кепка", 824.77999999999997, "Новинка" },
                    { 20, "Категория 1", "Не сфера предпосылки.", "https://cataas.com/cat?width=100&cat?height=:100", "Невероятный Меховой Носки", 963.70000000000005, "Рекомендуемый" },
                    { 21, "Категория 1", "Модернизации выбранный принимаемых значимость активизации.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Стальной Клатч", 62.079999999999998, "Новинка" },
                    { 22, "Категория 1", "Изменений правительством систему.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Деревянный Куртка", 448.32999999999998, "Рекомендуемый" },
                    { 23, "Категория 2", "Повышение от развития принципов забывать сфера.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Натуральный Автомобиль", 774.70000000000005, "Популярный" },
                    { 24, "Категория 1", "Же деятельности широким для представляет обуславливает информационно-пропогандистское.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Хлопковый Плащ", 829.74000000000001, "Популярный" },
                    { 25, "Категория 1", "Материально-технической определения образом высшего.", "https://cataas.com/cat?width=100&cat?height=:100", "Интеллектуальный Пластиковый Клатч", 751.25999999999999, "Популярный" },
                    { 26, "Категория 1", "Структура новая образом.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Бетонный Кепка", 952.36000000000001, "Рекомендуемый" },
                    { 27, "Категория 2", "Поставленных структуры повседневная обществом.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Деревянный Компьютер", 42.759999999999998, "Рекомендуемый" },
                    { 28, "Категория 3", "Профессионального с разработке принимаемых.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Деревянный Кепка", 885.11000000000001, "Новинка" },
                    { 29, "Категория 1", "Кадров сознания понимание поставленных национальный принимаемых общества за опыт прежде.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Деревянный Свитер", 829.60000000000002, "Рекомендуемый" },
                    { 30, "Категория 1", "Деятельности выполнять высокотехнологичная.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Хлопковый Ножницы", 492.06999999999999, "Новинка" },
                    { 31, "Категория 3", "Показывает выбранный системы активом постоянный прогресса практика.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Натуральный Кошелек", 635.04999999999995, "Новинка" },
                    { 32, "Категория 3", "Работы интересный существующий кадров вызывает работы рост идейные отношении.", "https://cataas.com/cat?width=100&cat?height=:100", "Невероятный Хлопковый Клатч", 908.76999999999998, "Новинка" },
                    { 33, "Категория 3", "Структура этих эксперимент структура сомнений шагов высокотехнологичная активом забывать.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Кожанный Куртка", 1.6100000000000001, "Рекомендуемый" },
                    { 34, "Категория 1", "Демократической нас прогресса повышение деятельности проверки прогресса.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Неодимовый Берет", 30.25, "Рекомендуемый" },
                    { 35, "Категория 2", "Поэтапного модернизации административных определения создание широкому.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Резиновый Свитер", 403.29000000000002, "Популярный" },
                    { 36, "Категория 1", "Сложившаяся воздействия модернизации кругу систему демократической предпосылки анализа работы.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Неодимовый Носки", 963.23000000000002, "Новинка" },
                    { 37, "Категория 2", "Активизации разнообразный участниками значительной качественно насущным развития позволяет.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Стальной Кулон", 951.23000000000002, "Популярный" },
                    { 38, "Категория 1", "Потребностям шагов активности материально-технической постоянное модели демократической уточнения соображения работы.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Деревянный Кошелек", 156.91, "Рекомендуемый" },
                    { 39, "Категория 3", "Последовательного по зависит степени другой другой.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Резиновый Свитер", 935.28999999999996, "Рекомендуемый" },
                    { 40, "Категория 2", "Изменений начало профессионального отметить прогрессивного понимание способствует значимость обучения.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Резиновый Носки", 789.19000000000005, "Популярный" },
                    { 41, "Категория 2", "Процесс участия новых.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Деревянный Автомобиль", 871.25, "Рекомендуемый" },
                    { 42, "Категория 3", "Же базы концепция сфера формирования повышение соответствующей всего.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Гранитный Портмоне", 972.80999999999995, "Рекомендуемый" },
                    { 43, "Категория 2", "Роль работы высокотехнологичная повышению таким забывать финансовых.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Деревянный Майка", 118.65000000000001, "Новинка" },
                    { 44, "Категория 2", "Роль существующий ресурсосберегающих напрямую условий курс повседневной консультация значимость.", "https://cataas.com/cat?width=100&cat?height=:100", "Интеллектуальный Стальной Компьютер", 880.60000000000002, "Рекомендуемый" },
                    { 45, "Категория 1", "Технологий общества занимаемых анализа не формирования дальнейшее выбранный рамки.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Натуральный Портмоне", 845.94000000000005, "Новинка" },
                    { 46, "Категория 2", "Целесообразности новых влечёт намеченных позволяет общества.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Пластиковый Портмоне", 301.06, "Рекомендуемый" },
                    { 47, "Категория 1", "Базы всего нас управление значимость.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Кожанный Свитер", 882.46000000000004, "Рекомендуемый" },
                    { 48, "Категория 2", "Модель с этих соответствующей важную что формировании формировании стороны нас.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Деревянный Свитер", 278.85000000000002, "Популярный" },
                    { 49, "Категория 2", "Понимание проект профессионального правительством проблем значение же не идейные управление.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Натуральный Носки", 995.64999999999998, "Рекомендуемый" },
                    { 50, "Категория 3", "По формирования социально-экономическое.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Натуральный Кошелек", 486.81, "Новинка" },
                    { 51, "Категория 2", "Зависит профессионального способствует проект поэтапного выбранный.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Хлопковый Шарф", 701.25999999999999, "Рекомендуемый" },
                    { 52, "Категория 3", "Же эксперимент организации дальнейших потребностям роль разнообразный новая обеспечение рост.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Неодимовый Носки", 672.79999999999995, "Рекомендуемый" },
                    { 53, "Категория 1", "Уровня актуальность отметить реализация внедрения.", "https://cataas.com/cat?width=100&cat?height=:100", "Лоснящийся Хлопковый Шарф", 563.20000000000005, "Популярный" },
                    { 54, "Категория 1", "Укрепления предложений широкому кадров.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Натуральный Шарф", 512.30999999999995, "Популярный" },
                    { 55, "Категория 1", "Участниками обуславливает с роль.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Пластиковый Плащ", 382.98000000000002, "Рекомендуемый" },
                    { 56, "Категория 3", "Правительством социально-экономическое прогресса правительством.", "https://cataas.com/cat?width=100&cat?height=:100", "Интеллектуальный Натуральный Кулон", 564.83000000000004, "Рекомендуемый" },
                    { 57, "Категория 1", "Разнообразный воздействия не повседневная соответствующей.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Стальной Ножницы", 996.10000000000002, "Популярный" },
                    { 58, "Категория 1", "Создание повышение нас базы правительством.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Резиновый Плащ", 114.22, "Популярный" },
                    { 59, "Категория 1", "Формированию равным участия обеспечивает требует консультация отношении.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Меховой Кулон", 139.52000000000001, "Популярный" },
                    { 60, "Категория 1", "Различных позволяет предложений систему определения формировании общественной форм.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Стальной Кошелек", 329.88999999999999, "Рекомендуемый" },
                    { 61, "Категория 2", "Экономической богатый массового формировании.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Хлопковый Кулон", 196.62, "Популярный" },
                    { 62, "Категория 3", "Сфера сознания широким повседневная.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Стальной Шарф", 722.08000000000004, "Новинка" },
                    { 63, "Категория 1", "Равным за для повседневной модель различных условий играет качественно опыт.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Меховой Сабо", 483.98000000000002, "Популярный" },
                    { 64, "Категория 3", "Таким с напрямую позволяет участия также и разнообразный опыт.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Хлопковый Кепка", 51.329999999999998, "Новинка" },
                    { 65, "Категория 3", "Специалистов создаёт повседневная задач деятельности.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Стальной Кулон", 783.16999999999996, "Рекомендуемый" },
                    { 66, "Категория 3", "Модернизации особенности изменений работы обществом значимость следует высокотехнологичная участия.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Гранитный Майка", 371.36000000000001, "Новинка" },
                    { 67, "Категория 1", "Нами технологий соответствующей занимаемых нашей также богатый.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Кожанный Носки", 903.0, "Популярный" },
                    { 68, "Категория 2", "Равным образом качества роль в забывать постоянный место инновационный уточнения.", "https://cataas.com/cat?width=100&cat?height=:100", "Большой Натуральный Майка", 270.55000000000001, "Популярный" },
                    { 69, "Категория 1", "Внедрения общества воздействия последовательного.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Кожанный Ножницы", 122.98999999999999, "Новинка" },
                    { 70, "Категория 3", "Анализа зависит демократической повышению деятельности технологий понимание.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Натуральный Кулон", 854.52999999999997, "Популярный" },
                    { 71, "Категория 1", "Очевидна следует напрямую значимость реализация повышению степени.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Пластиковый Сабо", 160.91999999999999, "Популярный" },
                    { 72, "Категория 3", "Понимание особенности же же по подготовке создаёт.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Гранитный Клатч", 568.44000000000005, "Рекомендуемый" },
                    { 73, "Категория 1", "Развития развития отметить гражданского отношении прогресса представляет показывает.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Хлопковый Портмоне", 849.82000000000005, "Рекомендуемый" },
                    { 74, "Категория 1", "Играет обуславливает общества концепция ресурсосберегающих.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Гранитный Стул", 25.859999999999999, "Популярный" },
                    { 75, "Категория 3", "Обеспечение же прежде широкому повседневная требует обеспечивает.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Резиновый Шарф", 597.09000000000003, "Популярный" },
                    { 76, "Категория 1", "Социально-ориентированный от всего правительством таким позволяет качественно прогресса различных.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Натуральный Носки", 257.55000000000001, "Новинка" },
                    { 77, "Категория 2", "Путь общества для практика базы.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Хлопковый Клатч", 924.26999999999998, "Популярный" },
                    { 78, "Категория 1", "Позволяет актуальность модель образом формированию.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Деревянный Кулон", 777.88999999999999, "Популярный" },
                    { 79, "Категория 2", "Формирования активизации насущным реализация проект активизации участниками равным.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Кожанный Портмоне", 514.44000000000005, "Популярный" },
                    { 80, "Категория 2", "Не разработке обучения разнообразный роль финансовых прогресса процесс.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Кожанный Кепка", 798.66999999999996, "Новинка" },
                    { 81, "Категория 2", "Обеспечение настолько инновационный.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Натуральный Стол", 510.97000000000003, "Рекомендуемый" },
                    { 82, "Категория 3", "Позволяет правительством воздействия прогресса зависит разработке модели формирования.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Гранитный Кепка", 547.30999999999995, "Рекомендуемый" },
                    { 83, "Категория 2", "Также насущным широким новая.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Стальной Компьютер", 104.48, "Новинка" },
                    { 84, "Категория 3", "Повседневной соображения что богатый таким занимаемых сущности концепция общества оценить.", "https://cataas.com/cat?width=100&cat?height=:100", "Великолепный Стальной Стул", 822.46000000000004, "Рекомендуемый" },
                    { 85, "Категория 3", "Интересный новая что принимаемых принимаемых а оценить.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Деревянный Кепка", 533.19000000000005, "Популярный" },
                    { 86, "Категория 2", "Предложений этих плановых.", "https://cataas.com/cat?width=100&cat?height=:100", "Грубый Резиновый Ботинок", 815.35000000000002, "Рекомендуемый" },
                    { 87, "Категория 2", "Поэтапного профессионального принципов существующий выполнять укрепления формирования обуславливает.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Неодимовый Майка", 751.80999999999995, "Рекомендуемый" },
                    { 88, "Категория 2", "Определения в важные соображения социально-экономическое предпосылки выбранный.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Неодимовый Кулон", 660.77999999999997, "Новинка" },
                    { 89, "Категория 3", "Потребностям позиции демократической структуры от реализация.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Натуральный Берет", 127.81, "Новинка" },
                    { 90, "Категория 1", "Дальнейшее принципов дальнейшее широкому идейные.", "https://cataas.com/cat?width=100&cat?height=:100", "Практичный Резиновый Плащ", 834.59000000000003, "Новинка" },
                    { 91, "Категория 3", "Образом реализация определения укрепления кадровой.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Неодимовый Стол", 295.48000000000002, "Рекомендуемый" },
                    { 92, "Категория 2", "Не определения обуславливает важные уточнения повседневная организационной.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Меховой Портмоне", 432.54000000000002, "Новинка" },
                    { 93, "Категория 1", "Таким сущности предложений представляет укрепления за играет и.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Меховой Клатч", 544.99000000000001, "Новинка" },
                    { 94, "Категория 2", "Социально-ориентированный сомнений с забывать значение базы плановых структуры организации важную.", "https://cataas.com/cat?width=100&cat?height=:100", "Свободный Кожанный Кулон", 103.64, "Рекомендуемый" },
                    { 95, "Категория 2", "Профессионального вызывает прогресса опыт модели.", "https://cataas.com/cat?width=100&cat?height=:100", "Потрясающий Стальной Шарф", 772.20000000000005, "Рекомендуемый" },
                    { 96, "Категория 3", "Создаёт собой кадровой нами проект потребностям.", "https://cataas.com/cat?width=100&cat?height=:100", "Интеллектуальный Натуральный Шарф", 341.06, "Новинка" },
                    { 97, "Категория 3", "Технологий поэтапного системы уровня равным активом.", "https://cataas.com/cat?width=100&cat?height=:100", "Эргономичный Стальной Плащ", 439.76999999999998, "Новинка" },
                    { 98, "Категория 1", "Нашей проверки намеченных постоянный сложившаяся принципов задача предложений укрепления анализа.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Пластиковый Плащ", 518.24000000000001, "Рекомендуемый" },
                    { 99, "Категория 2", "Плановых повседневная национальный качественно отметить дальнейших рамки требует отношении модели.", "https://cataas.com/cat?width=100&cat?height=:100", "Фантастический Натуральный Ботинок", 591.72000000000003, "Популярный" },
                    { 100, "Категория 3", "Различных широким дальнейшее материально-технической информационно-пропогандистское разнообразный высшего предпосылки также.", "https://cataas.com/cat?width=100&cat?height=:100", "Маленький Стальной Ножницы", 391.25, "Рекомендуемый" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
