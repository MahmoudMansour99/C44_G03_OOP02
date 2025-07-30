using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP02.Encapsulation
{
    internal struct PhoneNoteBook
    {
        #region Attributes
        private string[] names;
        private int[] numbers;
        private int size;
        #endregion

        #region Constructor
        public PhoneNoteBook(int Size)
        {
            size = Size;
            names = new string[Size];
            numbers = new int[Size];
        }
        #endregion

        public int Size { get { return size; } }

        #region Method
        public void AddPerson(int Position, string Name, int Numbers)
        {
            if (names is not null && numbers is not null)
            {
                if (Position < size && Position >= 0)
                {
                    names[Position] = Name;
                    numbers[Position] = Numbers;
                }

            }
        }
        #endregion

        #region Getter & Setter
        public int GetNumber(string Name)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == Name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        } 

        public void SetNumber(string Name, int NewNumber)
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == Name)
                    {
                        numbers[i] = NewNumber;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Indexer

        public int this[string Name]
        {
            get
            {
                if (names is not null)
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == Name)
                            return numbers[i];
                return -1;
            }
            set
            {
                if (names is not null)
                    for (int i = 0; i < names.Length; i++)
                        if (names[i] == Name)
                        {
                            numbers[i] = value;
                            break;
                        }  
            }
        }

        public string this[int index]
        {
            get
            {
                return $"Person Number {index}, Name: {names[index]},Number : {numbers[index]}";
            }
        }

        #endregion
    }
}
