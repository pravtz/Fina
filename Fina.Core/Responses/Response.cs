﻿using System.Text.Json.Serialization;

namespace Fina.Core.Responses;

public class Response<T>
{
    private int _code = Configuration.DefaultStatusCode;
    
    public T? Data { get; set; }
    public string? Message { get; set; }
    
    [JsonConstructor]
    public Response()
        => _code = Configuration.DefaultStatusCode;
    
    public Response(
        T? data,
        int code = Configuration.DefaultStatusCode,
        string? message = null)
    {
        Data = data;
        _code = code;
        Message = message;
    }
    
    [JsonIgnore]
    public bool IsSuccess => _code is >= 200 and <= 299;
    
    
}
