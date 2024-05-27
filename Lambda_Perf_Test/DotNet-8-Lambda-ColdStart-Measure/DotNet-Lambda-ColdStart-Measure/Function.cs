using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System.Text.Json.Serialization;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyRequest))]
[JsonSerializable(typeof(APIGatewayHttpApiV2ProxyResponse))]
[JsonSerializable(typeof(List<string>))]
[JsonSerializable(typeof(Dictionary<string, string>))]
public partial class CustomJsonSerializerContext : JsonSerializerContext
{
}
public class Function
{
    public static APIGatewayHttpApiV2ProxyResponse FunctionHandler(APIGatewayHttpApiV2ProxyRequest apigProxyEvent, ILambdaContext context)
    {
        var fibonacciResult = Fibonacci_recursive(35);
        return new APIGatewayHttpApiV2ProxyResponse
        {
            StatusCode = 200,
            Body = String.Format("Result = {0}", fibonacciResult),
        };
    }

    private static int Fibonacci_recursive(int n)
    {
        if (n < 2)
            return n;
        return Fibonacci_recursive(n - 1) + Fibonacci_recursive(n - 2);
    }

    private static int Fibonacci(int n)
    {
        if (n < 2)
            return n;

        int a = 0, b = 1, temp;
        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}
