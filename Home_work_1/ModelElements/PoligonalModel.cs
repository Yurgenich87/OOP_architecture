namespace ModelElements;

public class PoligonalModel
{
    // Атрибуты
    public Poligon Poligons { get; set; }
    public Texture Textures { get; set; }

    // Конструктор
    public PoligonalModel(Poligon poligons, Texture textures)
    {
        Poligons = poligons;
        Textures = textures;
    }

    }
