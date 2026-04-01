using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<char>();
        bool expectOperand = true;

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];

            if (char.IsWhiteSpace(item))
                continue;

            if (char.IsDigit(item) || item == '.')
            {
                int j = i;
                while (j < infix.Length && (char.IsDigit(infix[j]) || infix[j] == '.'))
                {
                    j++;
                }
                postFix += infix.Substring(i, j - i);
                postFix += ' ';
                i = j - 1;
                expectOperand = false;
                continue;
            }

            if (IsOperator(item))
            {
                if ((item == '+' || item == '-') && expectOperand)
                {
                    postFix += "0 ";
                }

                if (item == '(')
                {
                    stack.Push(item);
                    expectOperand = true;
                    continue;
                }

                if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFix += stack.Pop();
                        postFix += ' ';
                    }
                    if (stack.Count == 0) throw new Exception("Syntax error: unmatched ')'.");
                    stack.Pop();
                    expectOperand = false;
                    continue;
                }

                while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInfix(item))
                {
                    postFix += stack.Pop();
                    postFix += ' ';
                }
                stack.Push(item);
                expectOperand = true;
                continue;
            }

            postFix += item;
            postFix += ' ';
            expectOperand = false;
        }

        while (stack.Count > 0)
        {
            postFix += stack.Pop();
            postFix += ' ';
        }
        return postFix.Trim();
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        var tokens = postfix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var token in tokens)
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                if (stack.Count < 2) throw new Exception("Syntax error: insufficient operands for operator.");
                
                var b = stack.Pop();
                var a = stack.Pop();
                var result = Calculate(a, token[0], b);
                stack.Push(result);
            }
            else
            {
                stack.Push(double.Parse(token, CultureInfo.InvariantCulture));
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);

    private static double Calculate(double number1, char @operator, double number2)
    {
        switch (@operator)
        {
            case '^': return Math.Pow(number1, number2);
            case '*': return number1 * number2;
            case '/': return number1 / number2;
            case '+': return number1 + number2;
            case '-': return number1 - number2;
            default: throw new Exception("Not valid operator");
        }
    }
}
