using System;

public class PhoneNumber
{
    private string _phoneNumber;
    public PhoneNumber(string phoneNumber)
    {
        this._phoneNumber = phoneNumber;
    }


    public string Number
    {
        get
        {
            if (_phoneNumber.Length >= 10)
            {
                return _phoneNumber;
            }


            return _phoneNumber;
        }
    }

    public string AreaCode
    {
        get
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}