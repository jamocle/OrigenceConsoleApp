using OrigenceConsoleApp.Contracts;

namespace OrigenceConsoleApp;

public class MyStack<T> : IStack<T>
{
    private List<T> _stack= new List<T>();

    T IStack<T>.Peek()
    {
        var retVal = _stack[_stack.Count - 1];
        return retVal;
    }

    T IStack<T>.Pop()
    {
        if (_stack.Count == 0)
            throw new InvalidOperationException("Unable to remove from an Empty Stack");

        var retVal = _stack[_stack.Count-1]; ;
        _stack.RemoveAt(_stack.Count-1);
        return retVal;
    }

    void IStack<T>.Push(T item)
    {
        this._stack.Add(item);
    }
}
