# Итоговая контрольная работа по основному блоку

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.  
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.   
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  

## Решение
1. Основной блок кода
2. Функция CreateArray
3. Функция PrintArray
4. Функция CreateNewReducedArray

### 1. Основной блок кода
Создается новый массив строк, наполнение которого выполняется с помощью функции CreateArray.  
Затем, с помощью функции PrintArray, выводит в консоль новый массив, отвечающий условиям задачи, полученный с помощью функции CreateNewReducedArray.

### 2. Функция CreateArray
Данная функция предназначена для создания и наполнения массива строк.  
Запрашивает у пользователя размер массива, затем с помощью цикла for запрашивает каждую строку для ввода пользователем.  
Возвращает готовый, наполненый массив.

### 3. Функция PrintArray
Данная функция с помощью цикла foreach выводит в консоль поочередно каждый элемент массива.  
Если массив не имеет элементов, выводит символьное обозначение пустого массива.

### 4. Функция CreateNewReducedArray
Данная функция создает и наполняет новый массив, соответствующий требованиям задачи.  
Создается массив (int[] indexesStringLengthLessThreeSymbols) для хранения индексов строк, длина которых меньше, либо равна 3 символам.  
Создается переменная (int count) для хранения количества строк, длина которых меньше, либо равна 3 символам.  
С помощью цикла определяются строки, длина которых меньше, либо равна 3 символам, их индексы записываются в соответствующий массив, и ведется подсчет их количества.  
Создается новый массив (newArray) с размером, равным количеству строк, длина которых меньше, либо равна 3 символам, с помощью переменной count.  
С помощью цикла for новый массив (newArray) наполняется строками, отвечающими требованиям задачи.  
Возвращает новый массив.
