using KB15070_WpfApp1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB15070_WpfApp1.Model;
internal class Person : ObservableObject
{
    private int _id;
    public int ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }

    private String _familyName = String.Empty;
    public String FamilyName
    {
        get { return _familyName; }
        set { _familyName = value; OnPropertyChanged(); }
    }

    private String _givenName = String.Empty;
    public String GivenName
    {
        get { return _givenName; }
        set { _givenName = value; OnPropertyChanged(); }
    }

    private String _prefecture = String.Empty;
    public String Prefecture
    {
        get { return _prefecture; }
        set { _prefecture = value; OnPropertyChanged(); }
    }

    private String _city = String.Empty;
    public String City
    {
        get { return _city; }
        set { _city = value; OnPropertyChanged(); }
    }

    public Person()
    {
    }
}
