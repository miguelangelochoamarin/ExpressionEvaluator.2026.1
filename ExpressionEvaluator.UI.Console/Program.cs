using ExpressionEvaluator.Core;

try
{
    var result1 = Evaluator.Evaluate("12+-3.5*(2-4)");

    Console.WriteLine(result1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}