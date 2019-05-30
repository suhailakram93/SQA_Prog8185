using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1_SQA;
using NUnit.Framework;

namespace Assign_Test1
{

    [TestFixture]
    class Assign_Test1
    {
        [Test]
        public void GetLength_input()
        {
            //Arrange
            int l = 1;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, l);
        }
        [Test]
        public void SetLength_test()
        {
            //Arrange
            int l = 10;
            int w = 14;
            Rectangle Rectanglength_Test = new Rectangle(l, w);

            //Act
            int length = Rectanglength_Test.SetLength(18);

            //Assert
            Assert.AreEqual(length, 18);
        }
        [Test]
        public void GetWidth_test()
        {
            //Arrange
            int l = 3;
            int w = 4;
            Rectangle widRectangle_Test = new Rectangle(l, w);
            //Act
            int width = widRectangle_Test.GetWidth();
            //Assert
         
            Assert.AreEqual(width, w);
        }
        [Test]
        public void SetWidth_Test()
        {
            //Arrange
            int l = 5;
            int w = 8;
            Rectangle setwidth_Test = new Rectangle(l, w);
            //Act
            int width = setwidth_Test.SetWidth(9);
            //Assert

            Assert.AreEqual(width, 9);
        }
        [Test]
        public void GetPerimeter_Test()
        {
            //Arrange
            int l = 5;
            int w = 8;
            Rectangle getPerimeter_Test = new Rectangle(l, w);
            //Act
            int perimeter = getPerimeter_Test.GetPerimeter();
            //Assert

            Assert.AreEqual(perimeter, 26);
        }
        [Test]
        public void GetArea_Test()
        {
            //Arrange
            int l = 5;
            int w = 8;
            Rectangle getArea_Test = new Rectangle(l, w);
            //Act
            int area = getArea_Test.GetArea();
            //Assert

            Assert.AreEqual(area, 40);
        }
    }
}
