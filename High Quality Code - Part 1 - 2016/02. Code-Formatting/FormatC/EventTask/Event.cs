using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Wintellect.PowerCollections;

public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    public Event(DateTime date, string title, string location)
    {
        this.date = date;
        this.title = title;
        this.location = location;
    }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int by_Date = this.date.CompareTo(other.date);
        int by_Title = this.title.CompareTo(other.title);
        int by_Location = this.location.CompareTo(other.location);
        if (by_Date == 0)
        {
            if (by_Title == 0)
            {
                return by_Location;
            }
            else
            {
                return by_Title;
            }
        }
        else
        {
            return by_Date;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append(" | " + this.title);
        if (this.location != null && this.location != string.Empty)
        {
            toString.Append(" | " + this.location);
        }

        return toString.ToString();
    }
}