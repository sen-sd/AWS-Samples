import time

def lambda_handler(event, context):
    result = fibonacci(35)
    
    return {
        'statusCode': 200,
        'body': {
            'result': result
        }
    }


def fibonacci_recursion(n):
    if n < 2:
        return n
    return fibonacci_recursion(n - 1) + fibonacci_recursion(n - 2)

# The iterative approach is more efficient and avoids the
# overhead of function calls and stack usage associated with recursion.
def fibonacci(n):
    if n < 2:
        return n
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    return b
