namespace SapNetClone.Core.Utilities.Response;

public class BaseResponse<T> where T : class
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    
    public BaseResponse(string errorMessage)
    {
        this.Success = false;
        this.Message = errorMessage;
    }
    
    public BaseResponse(T data)
    {
        this.Success = true;
        this.Data = data;
    }

    public BaseResponse(T data, string successMessage)
    {
        this.Success = true;
        this.Data = data;
        this.Message = successMessage;
    }

}