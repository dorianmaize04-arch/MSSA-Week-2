

 




public class DigitalEntertainment
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }

   
}

public class Anime : DigitalEntertainment
{
    public int Episodes { get; set; }
    public string Studio { get; set; }

   
}

