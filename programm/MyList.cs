namespace programm;

/// <summary>
/// Мой класс списка
/// </summary>
public class MyList
{
    /// <summary>
    /// Тут массив интов, храним наши значения
    /// </summary>
    private int[] _values;

    /// <summary>
    /// Тут храним размер нашего массива
    /// </summary>
    private int _count;
    
    /// <summary>
    /// Свойство для получения размера массива, а так же
    /// для назначения этого размера, но назначение доступно
    /// только внутри класса.
    /// </summary>
    public int Count
    {
        get => _count;
        private set => _count = value;
    }
    
    /// <summary>
    /// Индексатор, для получения значения по индексу
    /// и его назначения
    /// </summary>
    /// <param name="index">входящий индекс</param>
    /// <exception cref="Exception">Ошибка, когда индекс выходит за пределы</exception>
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= _values.Length)
            {
                throw new Exception("Выход за пределы границ");
            }
            return _values[index];
        }
        set => _values[index] = value;
    }

    /// <summary>
    /// Конструктор
    /// </summary>
    public MyList()
    {
        Count = 0;
        _values = Array.Empty<int>();
    }
    
    /// <summary>
    /// Метод
    /// </summary>
    /// <param name="item">Входящий элемент</param>
    public void Add(int item)
    {
        int[] array = new int[Count + 1];
        for (int i = 0; i < Count; i++)
        {
            array[i] = _values[i];
        }

        array[Count] = item;
    }

    public void Remove(int item)
    {
        Remove(item, true);
    }

    public void RemoveAll(int item)
    {
        Remove(item, false);
    }

    private void Remove(int item, bool isOne)
    {
        for (int i = 0; i < Count; i++)
        {
            if (_values[i] == item)
            {
                _values[i] = default;
                if(isOne) { return; }
            }
        }
    }
}