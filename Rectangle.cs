using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_SQA
{
    public class Rectangle
    {
        private int width;
        private int length;

        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        public Rectangle() {
            this.width = 1;
            this.length = 1;
        }

        public Rectangle(int length, int width)
        {
            this.width = width;
            this.length = length;
        }

        public int GetLength() {
            return Length;
        }

        public int SetLength(int length)
        {
            Length = length;
            return Length;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int SetWidth(int width)
        {
            Width = width;
            return Width;
        }

        public int GetPerimeter() {
            return 2 * (Length + Width);
        }

        public int GetArea() {
            return Length * Width;
        }
    }
}
