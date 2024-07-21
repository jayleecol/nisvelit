public class Program
{
    public static void Main(string[] args)
    {
        string expr = "2 + 3 * x";
        Scope scope = new Scope();
        scope.Variables["x"] = 5;

        expr = ExpressionParser.Parse(expr, scope).Expr;

        Console.WriteLine($"Parsed expression: {expr}");
        // Further processing of the parsed expression
    }
}
