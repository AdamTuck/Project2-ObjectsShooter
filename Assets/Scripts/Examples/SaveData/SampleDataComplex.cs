[System.Serializable]
public class SampleDataComplex
{
    public string name;
    public Address address;
    public Book[] book;
}

[System.Serializable]
public class Address
{
    public int unit;
    public string road;
    public string city;
}

[System.Serializable]
public class Book
{
    public string bookName;
    public string bookAuthor;
    public bool isDigital;
}