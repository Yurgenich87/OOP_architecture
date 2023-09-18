using System.Net.Sockets;
using System.Threading.Channels;
using Home_work_4;

public class GeometryFigure
{
    static private List<IShape> toolbox;
    public GeometryFigure()
    {
        toolbox = new List<IShape>();
    }

    // Метод для добавления фигуры
    public void Add(IShape figure)
    {
        toolbox.Add(figure);
    }
    
    // Метод для удаления фигуры
    public void Remove(int index)
    {
        if (index >= 0 && index < toolbox.Count)
        {
            toolbox.RemoveAt(index);
            Console.WriteLine($"Фигура с индексом {index} удалена!");
        }
    }

    // Метод для поиска фигуры
    public int Find(IShape figure)
    {
        int foundIndex = toolbox.IndexOf(figure);
        if (foundIndex != -1)
        {
            Console.WriteLine($"Фигура {figure.GetType().Name} найдена под индексом: {foundIndex}");
        }
        else
        {
            Console.WriteLine("Фигура не найдена.");
        }
        return foundIndex;
    }


    // Метод для отображения информации фигуры
    public void GetInfo(int num)
    {
        IShape figure = toolbox[num];
        Console.WriteLine($"Фигура {figure.GetType().Name}, Площадь: {figure.GetArea():F2}, Периметр: {figure.GetPerimeter():F2}");
        }
    
    // Метод для изменения фигуры
    public void Modify(int index, IShape newFigure)
    {
        {
            if (index >= 0 && index < toolbox.Count)
            {
                IShape figureToMove = toolbox[index];
                toolbox[index] = newFigure;
                toolbox.RemoveAt(index); 
                toolbox.Add(figureToMove); 
            }
        }
    }

}