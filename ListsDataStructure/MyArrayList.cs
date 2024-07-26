using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ListsDataStructure
{
    public class MyArrayList
    {
        int[] _list;
        int _size = 0;

        public int Size { get { return _size; } }
        public int[] List { get { return _list; } }

        public MyArrayList()
        {
            _list = new int[10];
        }
        public MyArrayList(int size)
        {
            _list = new int[size];
        }

        /// <summary>
        /// Will add incoming value to end of list
        /// </summary>
        public void Append(int value)
        {
            IncreaseCapacity();
            _list[_size++] = value;
        }

        public void AddStart(int value)
        {
            IncreaseCapacity();
            for (int i = _size; i >= 0; i--)
            {
                _list[i + 1] = i;
            }
            _list[0] = value;
            _size++;
        }

        private void IncreaseCapacity()
        {
            if (_size != _list.Length) return;

            int[] newArray = new int[_size * 2];
            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _list[i];
            }

            _list = newArray;

        }
    }
}
