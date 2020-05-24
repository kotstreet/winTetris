﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Player : INotifyPropertyChanged
{
    private string _name;
    private int _score;

    public int Id { get; set; }
    public string Name { get { return _name; } 
        set
        {
            _name = value;
            OnPropertyChanged("Name");
        }
    }
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            OnPropertyChanged("Score");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName]string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}
