using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class PizzaInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<BaseContext>
    {
        protected override void Seed(BaseContext context)
        {
            var typeofingredientList = new List<TypeOfIngredient>()
            {
                new TypeOfIngredient(){Name = "Моцарелла", Price = 10},
                new TypeOfIngredient(){Name = "Пепперони", Price = 10},
                new TypeOfIngredient(){Name = "Чили перец", Price = 10},
                new TypeOfIngredient(){Name = "Томат", Price = 10},
                new TypeOfIngredient(){Name = "Чёрный перец", Price = 10},
                new TypeOfIngredient(){Name = "Тильтизер", Price = 10},
                new TypeOfIngredient(){Name = "Пармезан", Price = 10},
                new TypeOfIngredient(){Name = "Дорблю", Price = 10},
            };

            var streetList = new List<Street>()
            {
                new Street(){Name="Улица Рабфаковская"},
                new Street(){Name="Улица Богдана Хмельницкого"},
                new Street(){Name="Улица Красных Зорь"},
            };

            var cityList = new List<City>()
            {
                new City(){Name="Иваново", Streets = streetList},
            };

            var adressList = new List<Adress>()
            {
                new Adress(){Street = streetList[0], HomeNumber = 1, FlatNumber = 1 },
                new Adress(){Street = streetList[1], HomeNumber = 2, FlatNumber = 2 },
                new Adress(){Street = streetList[2], HomeNumber = 3, FlatNumber = 3 },
            };

            var adminList = new List<Admin>()
            {
                new Admin()
                {
                    FirstName = "admin",
                    SecondName = "admin",
                    Login = "admin",
                    Password = "admin",
                }
            };

            var buyerList = new List<Buyer>()
            {
                new Buyer()
                {
                    FirstName = getFirstName(),
                    SecondName = getSecondName(),
                    Login = "test_1",
                    Password = "test_2",
                    Adress = adressList[0],
                    TelephoneNumber = "89028764563",
                }
            };

            var cookerList = new List<Cooker>()
            {
                new Cooker()
                {
                    FirstName = getFirstName(),
                    SecondName = getSecondName(),
                    Login = "test_2",
                    Password = "test_2",
                    TelephoneNumber = "88005553535",
                }
            };

            var deliverymanList = new List<DeliveryMan>()
            {
                new DeliveryMan()
                {
                    FirstName = getFirstName(),
                    SecondName = getSecondName(),
                    Login = "test_3",
                    Password = "test_3",
                    TelephoneNumber = "88005550505",
                }
            };

            var conditionList = new List<Condition>()
            {
                new Condition(){NameOfCondition = "Заказан"},
                new Condition(){NameOfCondition = "Готовится"},
                new Condition(){NameOfCondition = "Доставляется"},
                new Condition(){NameOfCondition = "Завершён"},
            };

            var workerList = new List<Worker>();

            var sizeList = new List<SizeType>()
            {
                new SizeType (){Name = "Маленькая", PriceMultiolication = 0.5},
                new SizeType (){Name = "Средняя", PriceMultiolication = 1},
                new SizeType (){Name = "Большая", PriceMultiolication = 1.5},
            };

            var doughList = new List<DoughType>()
            {
                new DoughType(){Name = "Традиционное", PriceAdition = 150},
                new DoughType(){Name = "Тонкое", PriceAdition = 250},
            };

            var sauceList = new List<Sauce>()
            {
                new Sauce(){Name = "Сырный", Price = 25, },
                new Sauce(){Name = "Горчичный", Price = 25,},
                new Sauce(){Name = "Карри", Price = 25,},
                new Sauce(){Name = "Кисло-сладкий", Price = 25,},
                new Sauce(){Name = "Барбекью" , Price = 25,},
                new Sauce(){Name = "Сметанночесночный", Price = 25,},
            };

            var ingredientList = new List<Ingredient>()
            {
                new Ingredient(){ SignatureIngredient = typeofingredientList[0], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[1], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[2], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[3], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[4], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[5], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[6], QuantityOfIngredient = 1,},
                new Ingredient(){ SignatureIngredient = typeofingredientList[7], QuantityOfIngredient = 1,},
            };

            var pizzaList = new List<Pizza>()
            {
                new Pizza()
                {
                    Name = "Пепперони",
                    Aviable = true,
                    SelfMaded = false,
                    Ingredients = ingredientList,
                },
                new Pizza ()
                {
                    Name = "4 Сыра",
                    Aviable = true,
                    SelfMaded = false,
                    Ingredients = ingredientList,
                },
                new Pizza()
                {
                    Name = "Мясная",
                    Aviable = false,
                    SelfMaded = false,
                    Ingredients = ingredientList,
                },
            };

            var orderitemList = new List<OrderItem>()
            {
                new OrderItem()
                {
                    Pizza = pizzaList[0],
                    Dough = doughList[0],
                    Size = sizeList[0],
                },
                new OrderItem()
                {
                    Pizza = pizzaList[1],
                    Dough = doughList[1],
                    Size = sizeList[1],
                },
                new OrderItem()
                {
                    Pizza = pizzaList[2],
                    Dough = doughList[1],
                    Size = sizeList[0],
                },
            };

            var orderlineList = new List<OrderLine>()
            {
                new OrderLine{Item = orderitemList[0], ItemQuantity = 2,},
                new OrderLine{Item = orderitemList[1], ItemQuantity = 3,},
                new OrderLine{Item = orderitemList[2], ItemQuantity = 1,},
            };

            var orderList = new List<Order>()
            {
                new Order()
                {
                    Cooker = cookerList[0],
                    DeliveryMan = deliverymanList[0],
                    Buyer = buyerList[0],
                    DateOfCreation = new DateTime(2020,11,10),
                    Condition = conditionList[3],
                    Lines = new List<OrderLine>(){orderlineList[0] }, 
                },
                new Order()
                {
                    Cooker = cookerList[0],
                    DeliveryMan = deliverymanList[0],
                    Buyer = buyerList[0],
                    DateOfCreation = new DateTime(2020,11,10),
                    Condition = conditionList[3],
                    Lines = new List<OrderLine>(){orderlineList[1] }, 
                },
                new Order()
                {
                    Cooker = cookerList[0],
                    DeliveryMan = deliverymanList[0],
                    Buyer = buyerList[0],
                    DateOfCreation = new DateTime(2020,11,10),
                    Condition = conditionList[3],
                    Lines = new List<OrderLine>(){orderlineList[2] }, 
                },
            };

            

            // создание цены на существующие пиццы
            foreach (var pizza in pizzaList)
            {
                double price = doughList[0].PriceAdition;
                foreach(var ing in pizza.Ingredients)
                {
                    price += ing.SignatureIngredient.Price * ing.QuantityOfIngredient;
                }
                pizza.Price = price;
            }

            // создание цны на каждый item
            foreach (var it in orderitemList)
            {
                it.Price += it.Pizza.Price * it.Size.PriceMultiolication + it.Dough.PriceAdition;
            }

            // создание цены на каждый order
            foreach (var ord in orderList)
            {
                double price = 0;
                foreach(var line in ord.Lines)
                {
                    price += line.Item.Price * line.ItemQuantity;
                }
                ord.Price = price;
            }

            // добавление заказов покупателям
            foreach(var buyer in buyerList)
            {
                buyer.HistoryOfOrders = new List<Order>() { orderList[0], orderList[1], orderList[2], };
            }

            // добавление заказов работникам
            foreach(var cooker in cookerList)
            {
                cooker.Orders = new List<Order>() { orderList[0], orderList[1], orderList[2], };
            }
            foreach (var deliv in deliverymanList)
            {
                deliv.Orders = new List<Order>() { orderList[0], orderList[1], orderList[2], };
            }

            typeofingredientList.ForEach(e => context.TypeOfIngredient.Add(e));
            streetList.ForEach(e => context.Street.Add(e));
            cityList.ForEach(e => context.City.Add(e));
            adressList.ForEach(e => context.Adress.Add(e));
            adminList.ForEach(e => context.Admin.Add(e));
            buyerList.ForEach(e => context.Buyer.Add(e));

            cookerList.ForEach(e => context.Cooker.Add(e));
            cookerList.ForEach(e => context.Worker.Add(e));
            deliverymanList.ForEach(e => context.DeliveryMan.Add(e));
            deliverymanList.ForEach(e => context.Worker.Add(e));
            
            conditionList.ForEach(e => context.Condition.Add(e));
            sizeList.ForEach(e => context.SizeType.Add(e));
            doughList.ForEach(e => context.DoughType.Add(e));
            sauceList.ForEach(e => context.Sauce.Add(e));
            ingredientList.ForEach(e => context.Ingredient.Add(e));
            pizzaList.ForEach(e => context.Pizza.Add(e));
            orderitemList.ForEach(e => context.OrderItem.Add(e));
            orderlineList.ForEach(e => context.OrderLine.Add(e));
            orderList.ForEach(e => context.Order.Add(e));

            context.SaveChanges();
        }

        Random random = new Random();
        private string getFirstName()
        {
            string[] names = { "Абрам", "Аваз", "Август", "Авдей", "Автандил", "Адам", "Адис", "Адольф", "Адриан", "Азарий", "Аким", "Алан (Ален)", "Александр", "Алексей", "Альберт", "Альфред", "Амадей", "Амадеус", "Амаяк", "Анатолий", "Ангел", "Андоим", "Андрей", "Аникита", "Антон", "Ануфрий", "Арам", "Арий", "Аристарх", "Аркадий", "Арно", "Арнольд", "Арон", "Арсен, Арсений", "Артем", "Артемий", "Артур", "Архип", "Аскольд", "Афанасий", "Ахмет", "Ашот", "Бежен", "Бенедикт", "Берек", "Бернар", "Богдан", "Боголюб", "Болеслав", "Бонифаций", "Борис", "Борислав", "Боян", "Бронислав", "Бруно", "Вадим", "Валентин", "Валерий", "Вальтер", "Василий", "Велизар", "Венедикт", "Вениамин", "Виктор", "Вилен", "Вилли", "Вильгельм", "Виссарион", "Виталий", "Витаутас", "Витольд", "Владимир", "Владислав", "Владлен", "Володар", "Вольдемар", "Всеволод", "Вячеслав", "Гавриил", "Гарри", "Гастон", "Геннадий", "Генрих", "Георгий", "Геральд", "Герасим", "Герман", "Глеб", "Гордей", "Гордон", "Градимир", "Григорий", "Гурий", "Давыд", "Даниил", "Демид", "Демьян", "Денис", "Джордан", "Дмитрий", "Дональд", "Донат", "Донатос", "Дорофей", "Евгений", "Евграф", "Евдоким", "Евстафий", "Егор", "Елизар", "Елисей", "Емельян", "Ермолай", "Ерофей", "Ефим", "Ефимий", "Ефрем", "Жан", "Ждан", "Жорж", "Захар", "Захария", "Зигмунд", "Зиновий", "Ибрагим", "Иван", "Игнат", "Игорь", "Измаил", "Израиль", "Илиан", "Илларион", "Илья", "Иннокентий", "Ион", "Ионос", "Иосиф", "Ираклий", "Иржи", "Исай", "Казимир", "Карен", "Карл", "Ким", "Кирилл", "Клавдий", "Клемент", "Клим", "Клод", "Кондрат", "Конкордий", "Константин", "Кузьма", "Лазарь", "Лев", "Леван", "Леонард", "Леонид", "Леонтий", "Леопольд", "Лука", "Любомир", "Людвиг", "Люсьен", "Мадлен", "Май", "Макар", "Максим", "Максимилиан", "Мануил", "Марат", "Мариан", "Марк", "Мартин", "Матвей", "Мераб", "Мечеслав", "Милан", "Мирон", "Мирослав", "Михаил", "Мичлов", "Модест", "Моисей", "Мурат", "Муслим", "Назар", "Назарий", "Натан", "Наум", "Никита", "Никифор", "Николай", "Никон", "Нисон", "Нифонт", "Олан", "Олег", "Олесь", "Онисим", "Орест", "Осип", "Оскар", "Павел", "Парамон", "Петр", "Платон", "Порфирий", "Прохор", "Равиль", "Радий", "Радомир", "Раис", "Раймонд", "Ратмир", "Рафаил", "Рафик", "Рашид", "Рем", "Ренольд", "Ринат", "Рифат", "Ричард", "Роберт", "Родион", "Ролан", "Роман", "Ростислав", "Рубен", "Рудольф", "Руслан", "Рустам", "Савва", "Савел", "Самсон", "Святослав", "Севастьян", "Северин", "Семен", "Серафим", "Сергей", "Сократ", "Соломон", "Спартак", "Стакрат", "Станислав", "Степан", "Стивен", "Стоян", "Таис", "Талик", "Тамаз", "Тарас", "Тельман", "Теодор", "Терентий", "Тибор", "Тигран", "Тигрий", "Тимофей", "Тимур", "Тит", "Тихон", "Трифон", "Трофим", "Ульманас", "Устин", "Фаддей", "Федор", "Феликс", "Феодосий", "Фидель", "Филимон", "Филипп", "Флорентий", "Фома", "Франц", "Фридрих", "Харитон", "Христиан", "Христос", "Христофор", "Эдвард", "Эдуард", "Эльдар", "Эмиль", "Эммануил", "Эраст", "Эрик", "Эрнест", "Юлиан", "Юрий", "Юхим", "Яким", "Яков", "Ян", "Яромир", "Ярослав", "Ясон" };
            return names[random.Next(0, names.Length - 1)];
        }

        private string getSecondName()
        {
            string[] surnames = { "Смирнов", "Иванов", "Кузнецов", "Соколов", "Попов", "Лебедев", "Козлов", "Новиков", "Морозов", "Петров", "Волков", "Соловьёв", "Васильев", "Зайцев", "Павлов", "Семёнов", "Голубев", "Виноградов", "Богданов", "Воробьёв", "Фёдоров", "Михайлов", "Беляев", "Тарасов", "Белов", "Комаров", "Орлов", "Киселёв", "Макаров", "Андреев", "Ковалёв", "Ильин", "Гусев", "Титов", "Кузьмин", "Кудрявцев", "Баранов", "Куликов", "Алексеев", "Степанов", "Яковлев", "Сорокин", "Сергеев", "Романов", "Захаров", "Борисов", "Королёв", "Герасимов", "Пономарёв", "Григорьев", "Лазарев", "Медведев", "Ершов", "Никитин", "Соболев", "Рябов", "Поляков", "Цветков", "Данилов", "Жуков", "Фролов", "Журавлёв", "Николаев", "Крылов", "Максимов", "Сидоров", "Осипов", "Белоусов", "Федотов", "Дорофеев", "Егоров", "Матвеев", "Бобров", "Дмитриев", "Калинин", "Анисимов", "Петухов", "Антонов", "Тимофеев", "Никифоров", "Веселов", "Филиппов", "Марков", "Большаков", "Суханов", "Миронов", "Ширяев", "Александров", "Коновалов", "Шестаков", "Казаков", "Ефимов", "Денисов", "Громов", "Фомин", "Давыдов", "Мельников", "Щербаков", "Блинов", "Колесников", "Карпов", "Афанасьев", "Власов", "Маслов", "Исаков", "Тихонов", "Аксёнов", "Гаврилов", "Родионов", "Котов", "Горбунов", "Кудряшов", "Быков", "Зуев", "Третьяков", "Савельев", "Панов", "Рыбаков", "Суворов", "Абрамов", "Воронов", "Мухин", "Архипов", "Трофимов", "Мартынов", "Емельянов", "Горшков", "Чернов", "Овчинников", "Селезнёв", "Панфилов", "Копылов", "Михеев", "Галкин", "Назаров", "Лобанов", "Лукин", "Беляков", "Потапов", "Некрасов", "Хохлов", "Жданов", "Наумов", "Шилов", "Воронцов", "Ермаков", "Дроздов", "Игнатьев", "Савин", "Логинов", "Сафонов", "Капустин", "Кириллов", "Моисеев", "Елисеев", "Кошелев", "Костин", "Горбачёв", "Орехов", "Ефремов", "Исаев", "Евдокимов", "Калашников", "Кабанов", "Носков", "Юдин", "Кулагин", "Лапин", "Прохоров", "Нестеров", "Харитонов", "Агафонов", "Муравьёв", "Ларионов", "Федосеев", "Зимин", "Пахомов", "Шубин", "Игнатов", "Филатов", "Крюков", "Рогов", "Кулаков", "Терентьев", "Молчанов", "Владимиров", "Артемьев", "Гурьев", "Зиновьев", "Гришин", "Кононов", "Дементьев", "Ситников", "Симонов", "Мишин", "Фадеев", "Комиссаров", "Мамонтов", "Носов", "Гуляев", "Шаров", "Устинов", "Вишняков", "Евсеев", "Лаврентьев", "Брагин", "Константинов", "Корнилов", "Авдеев", "Зыков", "Бирюков", "Шарапов", "Никонов", "Щукин", "Дьячков", "Одинцов", "Сазонов", "Якушев", "Красильников", "Гордеев", "Самойлов", "Князев", "Беспалов", "Уваров", "Шашков", "Бобылёв", "Доронин", "Белозёров", "Рожков", "Самсонов", "Мясников", "Лихачёв", "Буров", "Сысоев", "Фомичёв", "Русаков", "Стрелков", "Гущин", "Тетерин", "Колобов", "Субботин", "Фокин", "Блохин", "Селиверстов", "Пестов", "Кондратьев", "Силин", "Меркушев", "Лыткин", "ТуровСмирнов", "Иванов", "Кузнецов", "Соколов", "Попов", "Лебедев", "Козлов", "Новиков", "Морозов", "Петров", "Волков", "Соловьёв", "Васильев", "Зайцев", "Павлов", "Семёнов", "Голубев", "Виноградов", "Богданов", "Воробьёв", "Фёдоров", "Михайлов", "Беляев", "Тарасов", "Белов", "Комаров", "Орлов", "Киселёв", "Макаров", "Андреев", "Ковалёв", "Ильин", "Гусев", "Титов", "Кузьмин", "Кудрявцев", "Баранов", "Куликов", "Алексеев", "Степанов", "Яковлев", "Сорокин", "Сергеев", "Романов", "Захаров", "Борисов", "Королёв", "Герасимов", "Пономарёв", "Григорьев", "Лазарев", "Медведев", "Ершов", "Никитин", "Соболев", "Рябов", "Поляков", "Цветков", "Данилов", "Жуков", "Фролов", "Журавлёв", "Николаев", "Крылов", "Максимов", "Сидоров", "Осипов", "Белоусов", "Федотов", "Дорофеев", "Егоров", "Матвеев", "Бобров", "Дмитриев", "Калинин", "Анисимов", "Петухов", "Антонов", "Тимофеев", "Никифоров", "Веселов", "Филиппов", "Марков", "Большаков", "Суханов", "Миронов", "Ширяев", "Александров", "Коновалов", "Шестаков", "Казаков", "Ефимов", "Денисов", "Громов", "Фомин", "Давыдов", "Мельников", "Щербаков", "Блинов", "Колесников", "Карпов", "Афанасьев", "Власов", "Маслов", "Исаков", "Тихонов", "Аксёнов", "Гаврилов", "Родионов", "Котов", "Горбунов", "Кудряшов", "Быков", "Зуев", "Третьяков", "Савельев", "Панов", "Рыбаков", "Суворов", "Абрамов", "Воронов", "Мухин", "Архипов", "Трофимов", "Мартынов", "Емельянов", "Горшков", "Чернов", "Овчинников", "Селезнёв", "Панфилов", "Копылов", "Михеев", "Галкин", "Назаров", "Лобанов", "Лукин", "Беляков", "Потапов", "Некрасов", "Хохлов", "Жданов", "Наумов", "Шилов", "Воронцов", "Ермаков", "Дроздов", "Игнатьев", "Савин", "Логинов", "Сафонов", "Капустин", "Кириллов", "Моисеев", "Елисеев", "Кошелев", "Костин", "Горбачёв", "Орехов", "Ефремов", "Исаев", "Евдокимов", "Калашников", "Кабанов", "Носков", "Юдин", "Кулагин", "Лапин", "Прохоров", "Нестеров", "Харитонов", "Агафонов", "Муравьёв", "Ларионов", "Федосеев", "Зимин", "Пахомов", "Шубин", "Игнатов", "Филатов", "Крюков", "Рогов", "Кулаков", "Терентьев", "Молчанов", "Владимиров", "Артемьев", "Гурьев", "Зиновьев", "Гришин", "Кононов", "Дементьев", "Ситников", "Симонов", "Мишин", "Фадеев", "Комиссаров", "Мамонтов", "Носов", "Гуляев", "Шаров", "Устинов", "Вишняков", "Евсеев", "Лаврентьев", "Брагин", "Константинов", "Корнилов", "Авдеев", "Зыков", "Бирюков", "Шарапов", "Никонов", "Щукин", "Дьячков", "Одинцов", "Сазонов", "Якушев", "Красильников", "Гордеев", "Самойлов", "Князев", "Беспалов", "Уваров", "Шашков", "Бобылёв", "Доронин", "Белозёров", "Рожков", "Самсонов", "Мясников", "Лихачёв", "Буров", "Сысоев", "Фомичёв", "Русаков", "Стрелков", "Гущин", "Тетерин", "Колобов", "Субботин", "Фокин", "Блохин", "Селиверстов", "Пестов", "Кондратьев", "Силин", "Меркушев", "Лыткин", "Туров" };
            return surnames[random.Next(0, surnames.Length - 1)];
        }
    }
}
