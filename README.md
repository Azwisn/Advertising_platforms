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

## 📂 Пример входного файла

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

Клонировать проект с GitHub:
   ```bash
   git clone https://github.com/Azwisn/Advertising_platforms.git
   cd Advertising_platforms
```

Собрать решение:

dotnet build

Перейти в проект с API:

cd Advertising_platforms

Запустить сервис:

dotnet run

## 🔗 API методы
1. Загрузка файла

POST /api/platforms/upload

2. Поиск площадок

GET /api/platforms/search?location=/ru/svrd/revda

## ✅ Тесты

Запуск юнит-тестов:

dotnet test

## 📌 Заметки

Данные хранятся только в памяти (in-memory).

Алгоритм поиска использует префиксный поиск (от глубокой локации к корневой).

Загрузка файла выполняется редко, поиск — часто.
