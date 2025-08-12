using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendespil_WPF.Model; 

public class Card
{
    public int Id { get; private set; }
    public bool IsFlipped { get; set; }
    public bool IsMatched { get; set; }
    public string Symbol { get; private set; }

    public Card (int id, string symbol) 
    { 
        this.Id = id;
        this.Symbol = symbol;
        this.IsMatched = false;
        this.IsFlipped = false;
    }      
}