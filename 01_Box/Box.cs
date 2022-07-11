using System;
using System.Collections.Generic;
using System.Text;

namespace Box
{
    public class Box<T>
    {
        //Constructors
        public Box(T element)
        {
            Element = element;
        }
        public Box(List<T> elements)
        {
            Elements = elements;
        }

        //Fields
        public List<T> Elements { get; }
        public T Element { get; set; }

        //Properties
        public void Swap(List<T>elements, int in1, int in2)
        {
            T firstEle = elements[in1];
            elements[in1] = elements[in2];
            elements[in2] = firstEle;
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }

    }
}
