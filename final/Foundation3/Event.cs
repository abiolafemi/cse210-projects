public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate:{_date.ToShortDateString}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public string ShortDescription()
    {
        return $"{this.GetType().Name}: {_title} on {_date.ToShortDateString()}";
    }
}
