using WebApi.Models.Base;

namespace WebApi.Models;

public class Editorial: Model
{
    public string? Name {get; set;}
    public string? City {get; set;}
    public string? Address {get; set;}

    public virtual IList<Book>? Books {get; set;} = default!;
}
