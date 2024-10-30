using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada.Logica
{
    public class SingleNode<T>
    {

        public T? Data { get; set; }
        public SingleNode<T>? Next { get; set; }

        public SingleNode(T data)
        {
            Data = data;
            Next = null;

        }


    }




}

