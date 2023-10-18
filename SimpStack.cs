using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStack
{
    internal class SimpStack<T>
    {
        Node<T>? pTail;
        public int Count { get; private set; }
        public SimpStack()
        {
            pTail = null;
        }
        public void Push(T value)
        {
            if (pTail == null)
            {
                pTail = new Node<T>(value, null);
            }

            pTail = new Node<T>(value, pTail);

            Count++;
        }
        public T Pop()
        {
            if(pTail == null)
            {
                throw new InvalidOperationException("Стек пуст");
            }

            T value = pTail.Data;
            pTail = pTail.pPrev;
            Count--;

            return value;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            Node<T>? tempNode = pTail;

            while(tempNode != null)
            {
                stringBuilder.Append($"{tempNode.Data?.ToString() ?? "Данных нет"}");
                tempNode = tempNode.pPrev;
            }

            return stringBuilder.ToString();
        }
    }
}
