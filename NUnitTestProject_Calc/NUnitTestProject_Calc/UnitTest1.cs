using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace NUnitTestProject_Calc
{
    public class MyTestClass
    {

        [Test, TestCaseSource("DivideCases")]       // Тесты на сложение
        public void TestAdd(int a, int b)
        {
            Calculator.Methods s = new Calculator.Methods();
            Assert.AreEqual((a+b), s.addition(a,b),"При слоожении {0} и {1} получили {2}", a, b, s.addition(a, b));
        }

        [Test, TestCaseSource("DivideCases")]       // Тесты на вычитание
        public void TestDiff(int a, int b)
        {
            Calculator.Methods s = new Calculator.Methods();
            Assert.AreEqual((a - b), s.difference(a, b), "При вычитании {1} из {0} получили {2}", a, b, s.division(a, b));
        }

        [Test, TestCaseSource("DivideCases")]       // Тесты на умножение
        public void TestMult(int a, int b)
        {
            Calculator.Methods s = new Calculator.Methods();
            Assert.AreEqual((a*b), s.multiplication(a, b), "При умножении {0} на {1} получили {2}", a, b, s.multiplication(a, b));
        }
        //[Ignore("Не реализовано округление")]
        [Test, TestCaseSource("DivideCases")]       // Тесты на деление
        public void TestDiv(int a, int b)
        {
            Calculator.Methods s = new Calculator.Methods();
            double res = Math.Round(a / b);// Math.Round((a/b), 5, MidpointRounding.ToZero);       //Не работает метод округления для double
            Assert.AreEqual(res, s.division(a,b), "При делении {0} на {1} получили {2}", a, b, s.division(a,b));
        }

        // Как красиво задать массив всех комбинаций чисел?
        static object[]                 //Задание входных чисел
            DivideCases =
                {new object[] {0, 0},   new object[] {0, 1},    new object[] {0, 2},   new object[] {0, 3},   new object[] {0, 4},
                 new object[] {0, 5},   new object[] {0, 6},    new object[] {0, 7},   new object[] {0, 8},   new object[] {0, 9},    
                 new object[] {0, 10},  new object[] {0, 11},   new object[] {0, 12},  new object[] {0, 13},  new object[] {0, 14}, 
                 new object[] {0, 15},  new object[] {0, 16},   new object[] {0, 17},  new object[] {0, 18},  new object[] {0, 19},
                 new object[] {0, 20},
                 new object[] {1, 0},   new object[] {1, 1},    new object[] {1, 2},   new object[] {1, 3},   new object[] {1, 4},
                 new object[] {1, 5},   new object[] {1, 6},    new object[] {1, 7},   new object[] {1, 8},   new object[] {1, 9},
                 new object[] {1, 10},  new object[] {1, 11},   new object[] {1, 12},  new object[] {1, 13},  new object[] {1, 14},
                 new object[] {1, 15},  new object[] {1, 16},   new object[] {1, 17},  new object[] {1, 18},  new object[] {1, 19},
                 new object[] {1, 20},
                 new object[] {2, 0},   new object[] {2, 1},    new object[] {2, 2},   new object[] {2, 3},   new object[] {2, 4},
                 new object[] {2, 5},   new object[] {2, 6},    new object[] {2, 7},   new object[] {2, 8},   new object[] {2, 9},
                 new object[] {2, 10},  new object[] {2, 11},   new object[] {2, 12},  new object[] {2, 13},  new object[] {2, 14},
                 new object[] {2, 15},  new object[] {2, 16},   new object[] {2, 17},  new object[] {2, 18},  new object[] {2, 19},
                 new object[] {2, 20},
                 new object[] {3, 0},   new object[] {3, 1},    new object[] {3, 2},   new object[] {3, 3},   new object[] {3, 4},
                 new object[] {3, 5},   new object[] {3, 6},    new object[] {3, 7},   new object[] {3, 8},   new object[] {3, 9},
                 new object[] {3, 10},  new object[] {3, 11},   new object[] {3, 12},  new object[] {3, 13},  new object[] {3, 14},
                 new object[] {3, 15},  new object[] {3, 16},   new object[] {3, 17},  new object[] {3, 18},  new object[] {3, 19},
                 new object[] {3, 20},
                 new object[] {4, 0},   new object[] {4, 1},    new object[] {4, 2},   new object[] {4, 3},   new object[] {4, 4},
                 new object[] {4, 5},   new object[] {4, 6},    new object[] {4, 7},   new object[] {4, 8},   new object[] {4, 9},
                 new object[] {4, 10},  new object[] {4, 11},   new object[] {4, 12},  new object[] {4, 13},  new object[] {4, 14},
                 new object[] {4, 15},  new object[] {4, 16},   new object[] {4, 17},  new object[] {4, 18},  new object[] {4, 19},
                 new object[] {4, 20},
                 new object[] {5, 0},   new object[] {5, 1},    new object[] {5, 2},   new object[] {5, 3},   new object[] {5, 4},
                 new object[] {5, 5},   new object[] {5, 6},    new object[] {5, 7},   new object[] {5, 8},   new object[] {5, 9},
                 new object[] {5, 10},  new object[] {5, 11},   new object[] {5, 12},  new object[] {5, 13},  new object[] {5, 14},
                 new object[] {5, 15},  new object[] {5, 16},   new object[] {5, 17},  new object[] {5, 18},  new object[] {5, 19},
                 new object[] {5, 20},
                 new object[] {6, 0},   new object[] {6, 1},    new object[] {6, 2},   new object[] {6, 3},   new object[] {6, 4},
                 new object[] {6, 5},   new object[] {6, 6},    new object[] {6, 7},   new object[] {6, 8},   new object[] {6, 9},
                 new object[] {6, 10},  new object[] {6, 11},   new object[] {6, 12},  new object[] {6, 13},  new object[] {6, 14},
                 new object[] {6, 15},  new object[] {6, 16},   new object[] {6, 17},  new object[] {6, 18},  new object[] {6, 19},
                 new object[] {6, 20},
                 new object[] {7, 0},   new object[] {7, 1},    new object[] {7, 2},   new object[] {7, 3},   new object[] {7, 4},
                 new object[] {7, 5},   new object[] {7, 6},    new object[] {7, 7},   new object[] {7, 8},   new object[] {7, 9},
                 new object[] {7, 10},  new object[] {7, 11},   new object[] {7, 12},  new object[] {7, 13},  new object[] {7, 14},
                 new object[] {7, 15},  new object[] {7, 16},   new object[] {7, 17},  new object[] {7, 18},  new object[] {7, 19},
                 new object[] {7, 20},
                 new object[] {8, 0},   new object[] {8, 1},    new object[] {8, 2},   new object[] {8, 3},   new object[] {8, 4},
                 new object[] {8, 5},   new object[] {8, 6},    new object[] {8, 7},   new object[] {8, 8},   new object[] {8, 9},
                 new object[] {8, 10},  new object[] {8, 11},   new object[] {8, 12},  new object[] {8, 13},  new object[] {8, 14},
                 new object[] {8, 15},  new object[] {8, 16},   new object[] {8, 17},  new object[] {8, 18},  new object[] {8, 19},
                 new object[] {8, 20},
                 new object[] {9, 0},   new object[] {9, 1},    new object[] {9, 2},   new object[] {9, 3},   new object[] {9, 4},
                 new object[] {9, 5},   new object[] {9, 6},    new object[] {9, 7},   new object[] {9, 8},   new object[] {9, 9},
                 new object[] {9, 10},  new object[] {9, 11},   new object[] {9, 12},  new object[] {9, 13},  new object[] {9, 14},
                 new object[] {9, 15},  new object[] {9, 16},   new object[] {9, 17},  new object[] {9, 18},  new object[] {9, 19},
                 new object[] {9, 20},

                 new object[] {10, 0},   new object[] {10, 1},    new object[] {10, 2},   new object[] {10, 3},   new object[] {10, 4},
                 new object[] {10, 5},   new object[] {10, 6},    new object[] {10, 7},   new object[] {10, 8},   new object[] {10, 9},
                 new object[] {10, 10},  new object[] {10, 11},   new object[] {10, 12},  new object[] {10, 13},  new object[] {10, 14},
                 new object[] {10, 15},  new object[] {10, 16},   new object[] {10, 17},  new object[] {10, 18},  new object[] {10, 19},
                 new object[] {10, 20},
                 new object[] {11, 0},   new object[] {11, 1},    new object[] {11, 2},   new object[] {11, 3},   new object[] {11, 4},
                 new object[] {11, 5},   new object[] {11, 6},    new object[] {11, 7},   new object[] {11, 8},   new object[] {11, 9},
                 new object[] {11, 10},  new object[] {11, 11},   new object[] {11, 12},  new object[] {11, 13},  new object[] {11, 14},
                 new object[] {11, 15},  new object[] {11, 16},   new object[] {11, 17},  new object[] {11, 18},  new object[] {11, 19},
                 new object[] {11, 20},
                 new object[] {12, 0},   new object[] {12, 1},    new object[] {12, 2},   new object[] {12, 3},   new object[] {12, 4},
                 new object[] {12, 5},   new object[] {12, 6},    new object[] {12, 7},   new object[] {12, 8},   new object[] {12, 9},
                 new object[] {12, 10},  new object[] {12, 11},   new object[] {12, 12},  new object[] {12, 13},  new object[] {12, 14},
                 new object[] {12, 15},  new object[] {12, 16},   new object[] {12, 17},  new object[] {12, 18},  new object[] {12, 19},
                 new object[] {12, 20},
                 new object[] {13, 0},   new object[] {13, 1},    new object[] {13, 2},   new object[] {13, 3},   new object[] {13, 4},
                 new object[] {13, 5},   new object[] {13, 6},    new object[] {13, 7},   new object[] {13, 8},   new object[] {13, 9},
                 new object[] {13, 10},  new object[] {13, 11},   new object[] {13, 12},  new object[] {13, 13},  new object[] {13, 14},
                 new object[] {13, 15},  new object[] {13, 16},   new object[] {13, 17},  new object[] {13, 18},  new object[] {13, 19},
                 new object[] {13, 20},
                 new object[] {14, 0},   new object[] {14, 1},    new object[] {14, 2},   new object[] {14, 3},   new object[] {14, 4},
                 new object[] {14, 5},   new object[] {14, 6},    new object[] {14, 7},   new object[] {14, 8},   new object[] {14, 9},
                 new object[] {14, 10},  new object[] {14, 11},   new object[] {14, 12},  new object[] {14, 13},  new object[] {14, 14},
                 new object[] {14, 15},  new object[] {14, 16},   new object[] {14, 17},  new object[] {14, 18},  new object[] {14, 19},
                 new object[] {14, 20},
                 new object[] {15, 0},   new object[] {15, 1},    new object[] {15, 2},   new object[] {15, 3},   new object[] {15, 4},
                 new object[] {15, 5},   new object[] {15, 6},    new object[] {15, 7},   new object[] {15, 8},   new object[] {15, 9},
                 new object[] {15, 10},  new object[] {15, 11},   new object[] {15, 12},  new object[] {15, 13},  new object[] {15, 14},
                 new object[] {15, 15},  new object[] {15, 16},   new object[] {15, 17},  new object[] {15, 18},  new object[] {15, 19},
                 new object[] {15, 20},
                 new object[] {16, 0},   new object[] {16, 1},    new object[] {16, 2},   new object[] {16, 3},   new object[] {16, 4},
                 new object[] {16, 5},   new object[] {16, 6},    new object[] {16, 7},   new object[] {16, 8},   new object[] {16, 9},
                 new object[] {16, 10},  new object[] {16, 11},   new object[] {16, 12},  new object[] {16, 13},  new object[] {16, 14},
                 new object[] {16, 15},  new object[] {16, 16},   new object[] {16, 17},  new object[] {16, 18},  new object[] {16, 19},
                 new object[] {16, 20},
                 new object[] {17, 0},   new object[] {17, 1},    new object[] {17, 2},   new object[] {17, 3},   new object[] {17, 4},
                 new object[] {17, 5},   new object[] {17, 6},    new object[] {17, 7},   new object[] {17, 8},   new object[] {17, 9},
                 new object[] {17, 10},  new object[] {17, 11},   new object[] {17, 12},  new object[] {17, 13},  new object[] {17, 14},
                 new object[] {17, 15},  new object[] {17, 16},   new object[] {17, 17},  new object[] {17, 18},  new object[] {17, 19},
                 new object[] {17, 20},
                 new object[] {18, 0},   new object[] {18, 1},    new object[] {18, 2},   new object[] {18, 3},   new object[] {18, 4},
                 new object[] {18, 5},   new object[] {18, 6},    new object[] {18, 7},   new object[] {18, 8},   new object[] {18, 9},
                 new object[] {18, 10},  new object[] {18, 11},   new object[] {18, 12},  new object[] {18, 13},  new object[] {18, 14},
                 new object[] {18, 15},  new object[] {18, 16},   new object[] {18, 17},  new object[] {18, 18},  new object[] {18, 19},
                 new object[] {18, 20},
                 new object[] {19, 0},   new object[] {19, 1},    new object[] {19, 2},   new object[] {19, 3},   new object[] {19, 4},
                 new object[] {19, 5},   new object[] {19, 6},    new object[] {19, 7},   new object[] {19, 8},   new object[] {19, 9},
                 new object[] {19, 10},  new object[] {19, 11},   new object[] {19, 12},  new object[] {19, 13},  new object[] {19, 14},
                 new object[] {19, 15},  new object[] {19, 16},   new object[] {19, 17},  new object[] {19, 18},  new object[] {19, 19},
                 new object[] {19, 20},
                 new object[] {20, 0},   new object[] {20, 1},    new object[] {20, 2},   new object[] {20, 3},   new object[] {20, 4},
                 new object[] {20, 5},   new object[] {20, 6},    new object[] {20, 7},   new object[] {20, 8},   new object[] {20, 9},
                 new object[] {20, 10},  new object[] {20, 11},   new object[] {20, 12},  new object[] {20, 13},  new object[] {20, 14},
                 new object[] {20, 15},  new object[] {20, 16},   new object[] {20, 17},  new object[] {20, 18},  new object[] {20, 19},
                 new object[] {20, 20},




                };
    } 
}