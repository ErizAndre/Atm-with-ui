using System;
using Newtonsoft.Json;



public class UserCred
{
    public string User { get; set; }
    public string Pass { get; set; }
    public string Balance { get; set; }
}

public static class CurrentLogUser
{
    public static string LoggedInPass { get; set; }
}


public static class GlobalVariables
{
    
    public static int GlobalIntVariable = 100000;
    
}
