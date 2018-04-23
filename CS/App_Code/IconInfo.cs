using System;

public class IconInfo
{
    private string _category;
    private string _size;
    private string _collection;
    private string _name;
    private string _fullIconID;
    private string _enumName;

    public IconInfo(string category, string size, string collection, string name, string fullIconID, string enumName)
    {
        this._category = category;
        this._size = size;
        this._collection = collection;
        this._name = name;
        this._fullIconID = fullIconID;
        this._enumName = enumName;
    }
    public string Category
    {
        get { return _category; }
        set { _category = value; }
    }

    public string Size
    {
        get { return _size; }
        set { _size = value; }
    }
    public string Collection
    {
        get { return _collection; }
        set { _collection = value; }
    }
    public string IconName
    {
        get { return _name; }
        set { _name = value; }
    }
    public string FullIconID
    {
        get { return _fullIconID; }
        set { _fullIconID = value; }
    }
    public string EnumName
    {
        get { return _enumName; }
        set { _enumName = value; }
    }
}

