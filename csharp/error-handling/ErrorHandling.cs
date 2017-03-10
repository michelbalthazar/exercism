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
        bool successfulResult = false;
        if(input == "1")
        {
            result = 1;
            successfulResult = true;
            return successfulResult;
        }
        else
             result = 1; 
             return successfulResult;

    }

    private class DisposableResouce : IDisposable
    {
        public bool IsDisposed 
        {
            get;
            
            private set;
        }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {   
        disposableObject.Dispose();
        throw new Exception();
    }
}
