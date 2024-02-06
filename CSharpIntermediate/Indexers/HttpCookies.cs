using System.Collections.Generic;

namespace CSharpIntermediate;

public class HttpCookies
{
    private readonly Dictionary <string , string> dictinory = [];
    // initializing or create a ctor and initialize 


    public void set(string key, string value)
    {
        this.dictinory[value] = value;
        this.dictinory[key] = key;

    }

    public string get(string key)
    {
        return dictinory[key];
    }
/*
    //indexers
    public string this[string key]
    {
        get { return dictinory[key]; }
        set { dictinory[key] = value; }
    }*/

    //if not indexer use properties 

    
}
