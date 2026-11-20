namespace BlazingPizza;

using System.Globalization;
public class Topping
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string GetFormattedPrice() => Price.ToString("N0", CultureInfo.GetCultureInfo("es-CR"));
}
