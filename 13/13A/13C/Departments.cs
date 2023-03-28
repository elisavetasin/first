using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13C
{
   
    class Departments
    {
        public string Name { get; set; }
        public ObservableCollection<Worker> Workers_col { get; set; }
    }
}
