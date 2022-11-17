# TMS_Course_HM

<h2>Lesson 3</h2>
<details>
1. Создать консольное приложение:<br>
   - Обмена значениями двух переменных (при возможности не создавать третью переменную).<br>
   - Реализовать сравнение двух введенных с клавиатуры чисел. После сравнения, программа не должна закрываться,<br>
   а должна ожидать ввод следующих цифр для сравнения<br>
  - Реализовать алгоритм, который определяет является ли введенное целочисленное число полиндромом 
  (читается одинаково слева направо и справа налево, для преобразования к типу int использовать Convert.ToInt32())<br>
</details>

<h2>Lesson 4</h2>
<details>
1. Создать консольное приложение: <br>
    - Приложение должно создавать массив целых чисел, размер которого должен задавать пользователь с клавиатуры. <br>
    - Массив необходимо заполнить произвольными целыми числами (для генерации чисел нужно использовать <br>
    Random rand = new Random(); int value = rand.Next(-100, 100);).<br>
    Сгенерированный массив необходимо вывести на экран<br>
    - С помощью математических операций, условий и циклов на консоль необходимо вывести наибольшее значение в массиве, наименьшее значение в массиве,<br> 
    общую сумму всех элементов, среднее арифметическое всех элементов. Вычисленные значения необходимо вывести на экран<br>
   - Программа должна ожидать нажатия клавиши клавиатуры для завершения работы программы.<br>
   * Выполнить сортировку элементов массива по убыванию и вывести результат на экран, ,без использования методов класса Array.<br>
2. * Тоже самое только массив должен быть двумерный - матрица.<br>
3. Создать программу-переводчик, которая знает 10 английских слов. Пользователь должен ввести слово на английском, программа выводит перевод на русском.<br> 
В случае если слова нет, то нужно вывести на консоль сообщение "Слово не было найдено".<br>
Для решения задачи можно использовать класс Dictionary<string, string> и методы этого класса, такие как ContainsKey().... 
</details>

<h2>Lesson 5</h2>
   <details>
   5. Написать валютный калькулятор:<br>
 5.1 Программа должна обладать следующим функционалом:<br>
   - Программа должна создавать CurrencyConverter с разными курсами валют(СurrencyConverter.AddExchangeRate()).<br>
Можно добавить до 10 разных курсов, придумать самим<br>
   - Отображать пользователю имеющиеся курсы - CurrencyConverter.ToString()<br>
   - Конвертировать валюты и отображать полученный результат - пользователь вводит название валюты, <br>
название валюты в которую необходимо выполнить конвертацию и значение, указывающие объем первой валюты<br>
 5.2 Программа должна содержать следующие сущности (каждая сущность в отдельном классе):<br>
    - Перечисление Currencies – можно добавить до 10 разных валют.<br>
</details>


<h2>Lesson 13</h2>
   <details>
1. Cоздать пользовательский Middleware и добавить его в конвейер обработки запроса через расширяющий метод.
Задача этого компонента выполнять запись в файл адрес, по которому пользователь обратился к приложению.
2. Создать модель Worker c полями: Name, Age, DateOfBirth, Address.
3. Создать контроллер, который будет принимать пользовательские запросы. 
Например, контроллер будет возвращать в ответ пользователю представление с данными модели Worker. 
Создание экземпляра класса Worker произвольное, можно создавать в момент выполнения метода контроллера.
4. Создать все пять типов фильтров и добавить в глобальную область. Методы фильтров должны выполнять запись в отдельный файл.
Проанализировать когда и в какой последовательности вызываются методы фильтров.
</details>
