using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Vendespil_WPF.ViewModel;

public class Game_ViewModel: INotifyPropertyChanged
{
    //Når man klikker på et kort vendes det
    //Identificer koden bag kortet - hvilket symbol
    //Gøre kortet synligt 
    //Hvor mange kort er synlige? ved 2 kort evalueres, if matched = point/fjernes fra boarded og if not Reset
    //Property, der holder øje med synlige kort - is flipped = true og is matched = true og stikket fjernes fra boarded
    //Ved nyt spil "blandes" kortene, så de får en ny position


    //Counter antal turer 
    private int _counter = 2;
    public int Counter
    {
        get => _counter;
        set
        {
            _counter = value;
            OnPropertyChanged(nameof(Counter));
        }
    }

    public Game_ViewModel()
    {
        AddPointCommand = new RelayCommand(AddPoint);
    }

    public ICommand AddPointCommand { get; set; }

    //Add point to player on correct answer
    public void AddPoint()
    {
        Counter++; 
    }

    //Implementering af interface
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

}
