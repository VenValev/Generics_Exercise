using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Box
{
    public class Box<T> : IComparable <T> where T : IComparable<T>
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

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountElements<T>(List<T> list, T readLine) where T : IComparable
            => list.Count(word => word.CompareTo(readLine) > 0);

        //Properties
        public void Swap(List<T>elements, int in1, int in2)
        {
            T firstEle = elements[in1];
            elements[in1] = elements[in2];
            elements[in2] = firstEle;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }

            //return $"{typeof(T)}: {Element}";
            return sb.ToString().TrimEnd();
        }

    }
}
