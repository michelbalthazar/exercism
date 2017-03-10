using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
         throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        int successfulResult = 0;
        if (input == "a")
        {
        return null;
        }
         return successfulResult = 1;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
