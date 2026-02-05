# Лабораторна робота №4

* **Студент:** Нікітіч Олександр
* **Група:** ІО-51
* **Залікова книжка:** №5113

## Посилання на документацію GitHub Pages

[https://sashanikitich.github.io/lab_4/](https://sashanikitich.github.io/lab_4/)

## Варіант завдання

* **Завдання:** Реалізувати класи для роботи з текстом: **Sentence**, **Word**, **Punct**, **Text**.
* **Сортування:** Масив речень сортувати за віком та XP (аналогічно NPC).
* **Пошук:** Знайти конкретний об’єкт у колекції за логікою `Equals`.

---

## Опис реалізації

Програма написана на мові **C#** (.NET 9) і демонструє роботу з **об’єктно-орієнтованою моделлю тексту**, сортуванням колекцій і юніт-тестуванням.

### 1. Клас `Word`

* Представляє окреме слово.
* Зберігає **масив об’єктів `Letter`**, кожна літера — окремий об’єкт.
* Має властивість `Content` та перевизначений `ToString()` для зручного виводу.

### 2. Клас `Punct`

* Представляє **окремий знак пунктуації**.
* Має властивість `Mark` та перевизначений `ToString()`.

### 3. Клас `Sentence`

* Складається з **слів (`Word`) та пунктуації (`Punct`)**.
* Для NPC-логіки зберігає:

  * `Name` (string) — ім’я
  * `Surname` (string) — прізвище
  * `Hobby` (string) — хобі
  * `Xp` (int) — очки досвіду
  * `Age` (int) — вік
* Перевизначені методи `Equals`, `GetHashCode` та `ToString`.

### 4. Клас `Text`

* Контейнер для масиву об’єктів `Sentence`.
* Забезпечує метод `GetSentences()` для доступу до речень.
* Має утилітний метод `CleanString()` для нормалізації рядків (замінює кілька пробілів і табуляцій на один пробіл).

### 5. Сортування та пошук

* Сортування колекції речень за **Age** (зростання) та **Xp** (спадання) з використанням LINQ (`OrderBy` / `ThenByDescending`).
* Пошук конкретного речення через `Array.Find` та метод `Equals`.

### 6. Тестування (Unit Tests)

Проєкт з тестами на **NUnit** перевіряє:

* Ініціалізацію об’єктів (`Sentence`, `Word`)
* Коректність роботи методів `Equals` і `ToString`
* Сортування за двома критеріями
* Нормалізацію рядків через `Text.CleanString()`
* Роботу з порожніми масивами та пустими словами

---

## Структура проєкту

* `Word.cs` — модель слова
* `Letter.cs` — модель літери
* `Punct.cs` — модель пунктуації
* `Sentence.cs` — модель речення
* `Text.cs` — контейнер для колекції речень
* `Program.cs` — головний клас із демонстрацією роботи та сортування
* `Tests/WordTest.cs`, `Tests/SentenceTest.cs`, `Tests/TextTest.cs` — юніт-тести на NUnit

---

## Результат роботи програми

```text
Initial list: 
Sasha  | Surname: Nikitich | Hobby: programming | XP: 67 | Age: 17
Bogdan | Surname: Tsiapko | Hobby: programming | XP: 69 | Age: 17
Dmytro | Surname: Pankevich| Hobby: cooking    | XP: 911| Age: 19
Max    | Surname: Shapirenko| Hobby: fighting  | XP: 42 | Age: 18
Danya  | Surname: Sych     | Hobby: running   | XP: 52 | Age: 25

Sorted list: 
Sasha  | Surname: Nikitich | Hobby: programming | XP: 67 | Age: 17
Bogdan | Surname: Tsiapko | Hobby: programming | XP: 69 | Age: 17
Max    | Surname: Shapirenko| Hobby: fighting  | XP: 42 | Age: 18
Dmytro | Surname: Pankevich| Hobby: cooking    | XP: 911| Age: 19
Danya  | Surname: Sych     | Hobby: running   | XP: 52 | Age: 25

Search result: 
Found: Sasha  | Surname: Nikitich | Hobby: programming | XP: 67 | Age: 17
```

---

## Відео роботи програми

https://github.com/user-attachments/assets/fd73471a-4861-4ee7-94d7-acd137a61ef1

---
