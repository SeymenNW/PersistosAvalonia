using Persistos.Models;
using System.Collections.ObjectModel;

namespace Persistos.ViewModels;


public class MainWindowViewModel : ViewModelBase
{
   public Student student = new Student();

    public ObservableCollection<Student> studentsList { get; set; }

    public MainWindowViewModel() 
    {

        studentsList = new ObservableCollection<Student>()
    {
        new Student() { Major="Biology", Name="Jake", Semester=5},
        new Student() { Major="Mathematics", Name="Oliver", Semester=2},
         new Student() { Major="Biology", Name="Jake", Semester=5},
         new Student() { Major="Biology", Name="Jake", Semester=5},
        new Student() { Major="Mathematics", Name="Oliver", Semester=2},
         new Student() { Major="Biology", Name="Jake", Semester=5},
        new Student() { Major="Mathematics", Name="Oliver", Semester=2}



    };

    }



}