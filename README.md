# 📰 Ad Platforms Service

Сервис для хранения и поиска рекламных площадок по локациям 🌍.  
Тестовое задание на C# / ASP.NET Core Web API (.NET 8).

---

## 🚀 Архитектура проекта

Проект разделён на слои:

- **Api** 🌐 — ASP.NET Core Web API (контроллеры, точки входа).
- **Bll** ⚙️ — бизнес-логика, сервисы и модели.
- **Dal** 🛠️ — работа с файлами (загрузка данных).
- **Tests** ✅ — модульные тесты (xUnit).

📂 Пример входного файла

Файл test_platforms.txt:

Яндекс.Директ:/ru
Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik
Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl
Крутая реклама:/ru/svrd

## ⚙️ Инструкция по запуску веб-сервиса

### 🔹 Предварительные требования

- Установлен [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Установлен Git (для клонирования репозитория)

---

### 🔹 Шаги запуска

Клонировать проект с GitHub

Собрать решение:

dotnet build

Перейти в проект с API:

cd AdPlatformsService.Api

Запустить сервис:

dotnet run

После запуска API будет доступен по адресу:

Swagger UI 👉 http://localhost:5000/swagger

или 👉 https://localhost:5001/swagger
(если используется HTTPS)
