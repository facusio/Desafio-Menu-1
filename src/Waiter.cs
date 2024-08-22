using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private string name;
    public string Name
    {
        get
        {
            return name;
            
        }
        set
        {
            name = value;
        }

    }

    public void AssignTable(Table table)
    {
        this.assignedTables.Add(table);
    }

    public void TakeOrder(Table table, Dish dish)
    {
        table.AddToOrder(dish);
    }
        
    private ArrayList assignedTables = new ArrayList();
}