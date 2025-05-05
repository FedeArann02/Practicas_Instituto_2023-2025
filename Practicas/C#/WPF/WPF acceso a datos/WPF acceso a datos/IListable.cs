using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_acceso_a_datos
{
    public interface IListable <T>
    {
        List<T> Listar();
    }
}
