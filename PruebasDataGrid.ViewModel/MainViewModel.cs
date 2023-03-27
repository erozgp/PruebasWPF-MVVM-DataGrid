using PruebasDataGrid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasDataGrid.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private List<Estudiante> estudiantesList;
       


        public List<Estudiante> EstudiantesList
        {
            get { return estudiantesList; }

            set
            {
                if (estudiantesList == value)
                {
                    return;
                }
                estudiantesList = value;
                OnPropertyChanged("EstudiantesList");
            }
        }

        public MainViewModel()
        {
            List<Estudiante> estudianteList = new List<Estudiante>();

            for (int i = 0; i <= 5; i++)
            {
                estudianteList.Add(new Estudiante("Estudiante"+i, 23+i, "erozgp"+i+"@gmail.com"));
            }
                    
            EstudiantesList = estudianteList;            
        }
    }
}
