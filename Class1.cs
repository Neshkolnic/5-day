using System;
using System.Collections.Generic;

public static class StringExtensions
{
    // Метод расширения для типа string
    public static string AddPeriod(this string str)
    {
        return str + ".";
    }
}

public static class SetExtensions
{
    // Метод расширения для удаления нулевых элементов из множества
    public static Set<T> RemoveZeros<T>(this Set<T> set)
    {
        Set<T> result = new Set<T>();
        foreach (var item in set)
        {
            if (!item.Equals(default(T)))
            {
                result.Add(item);
            }
        }
        return result;
    }

}

public class MyClass
{
    public class Date
    {
        public DateTime CreationDate { get; }

        public Date()
        {
            CreationDate = DateTime.Now;
        }
    }

    // Ваша реализация класса MyClass
}

public class Set<T> : HashSet<T>
{
    // Перегрузка оператора - для удаления элемента из множества
    public static Set<T> operator -(Set<T> set, T item)
    {
        set.Remove(item);
        return set;
    }

    // Перегрузка оператора * для пересечения множеств
    public static Set<T> operator *(Set<T> set1, Set<T> set2)
    {
        Set<T> result = new Set<T>();
        foreach (var item in set1)
        {
            if (set2.Contains(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    // Перегрузка оператора < для сравнения множеств
    public static bool operator <(Set<T> set1, Set<T> set2)
    {
        return set1.Count < set2.Count;
    }

    // Перегрузка оператора > для проверки на подмножество
    public static bool operator >(Set<T> set1, Set<T> set2)
    {
        return set1.IsSubsetOf(set2);
    }

    // Придуманное использование: оператор & для объединения двух множеств
    public static Set<T> operator &(Set<T> set1, Set<T> set2)
    {
        Set<T> result = new Set<T>();
        foreach (var item in set1)
        {
            result.Add(item);
        }
        foreach (var item in set2)
        {
            result.Add(item);
        }
        return result;
    }


}
