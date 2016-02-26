using System;

class WriteToConsole : Output
{
    public bool Write(String Message){
        if (String.IsNullOrEmpty(Message) == false)
        {
            Console.Write(Message);
            return true;
        }
        return false;
    } 
}

class WriteToDb : Output
{
    public bool Write(String Message)
    {
        if (Message != null)
        {
            //Database write here
            return true;
        }
        return false;
    }
}