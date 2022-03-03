namespace GenericsConsoleApp.SimpleStacks;

public class SimpleStackInt
{
    private readonly int[] _items;
    private int _currentIndex = -1;

    public SimpleStackInt() => _items = new int[10];

    public int Count => _currentIndex + 1;

    public void Push(int item) => _items[++_currentIndex] = item;

    public int Pop() => _items[_currentIndex--];
}

 
