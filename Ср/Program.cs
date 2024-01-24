Console.WriteLine("Введите последовательность скобок:");
string sequence = Console.ReadLine();

string bracketsOnly = new string(sequence.Where(c => c == '(' || c == ')').ToArray());
string expressionOnly = new string(sequence.Where(c => c != '(' && c != ')').ToArray());

Console.WriteLine("Скобки: " + bracketsOnly);
Console.WriteLine("Выражение: " + sequence);
Console.WriteLine("Результат проверки: " + SequenceOfParentheses(sequence));

static bool SequenceOfParentheses(string input)
{
    Stack<char> stack = new Stack<char>();

    foreach (char bracket in input)
    {
        if (bracket == '(')
        {
            stack.Push(bracket);
        }
        else if (bracket == ')')
        {
            if (stack.Count == 0 || stack.Peek() != '(')
            {
                return false;
            }
            stack.Pop();
        }

    }

    return stack.Count == 0;
}