using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private string _phoneNumber;
    public PhoneNumber(string phoneNumber)
    {
        this._phoneNumber = phoneNumber;
        
    }
    public string ToString()
    {
        
        return _phoneNumber = Regex.Replace(_phoneNumber, @"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
    }
    public string Number
    {
        get
        {

            

            _phoneNumber = _phoneNumber.Replace("(", "").Replace(")", "").Replace("-",
                "").Replace(" ", "").Replace(".", "");

            if (_phoneNumber.Length == 10)
            {
                return _phoneNumber;
            }

            if (_phoneNumber.StartsWith("1") && _phoneNumber.Length > 10)
            {
                return _phoneNumber.Substring(1);
            }

            return "0000000000";
        }
    }

    public string AreaCode
    {
        get
        {
            return _phoneNumber.Remove(3);
        }
    }
}