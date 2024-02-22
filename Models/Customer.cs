namespace SysCredit.Android.Models;

using Helpers;

public class Customer
{
    public long m_CustomerId;

    public string m_Identification = string.Empty;

    public string m_Name = string.Empty;

    public string m_LastName = string.Empty;

    public Gender m_Gender;

    public string? m_Email;

    public string m_Address = string.Empty;

    public string m_Neighborhood = string.Empty;

    public string m_BussinessType = string.Empty;

    public string m_BussinessAddress = string.Empty;

    public string m_Phone = string.Empty;
}