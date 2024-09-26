namespace CompAndDel.Filters;
using System;
using CompAndDel;

public class SaveFilter : IFilter
{
    private PictureProvider p = new PictureProvider();
    public string Path { get; set; }

    public SaveFilter(string path)
    {
        this.Path = path;
    }
    public IPicture Filter(IPicture result)
    {
        p.SavePicture(result, this.Path );
        return result;
    }
}