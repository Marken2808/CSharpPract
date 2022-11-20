using System;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace CalculatorBMI.ViewModels;

public partial class CalculatorViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(BMIScore))]
    [AlsoNotifyChangeFor(nameof(BMIResult))]
    public double height;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(BMIScore))]
    [AlsoNotifyChangeFor(nameof(BMIResult))]
    public double weight;


    public double BMIScore => Math.Round(weight / Math.Pow(height / 100, 2), 2);
    

    public string BMIResult
    {
        get{
            if (BMIScore < 18.5) return "Underweight";
            if (BMIScore < 25) return "Healthy";
            if (BMIScore < 30) return "Overweight";
            else return "Obses";
        }
    }
}

