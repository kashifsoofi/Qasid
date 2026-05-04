using System.Collections.Generic;

namespace Qasid.Models;

public class Collection
{
    public string Name { get; set; }
    public List<Collection> Collections { get; set; }
    public List<Request> Requests { get; set; }
}

public class Request
{
    public string Name { get; set;}
}