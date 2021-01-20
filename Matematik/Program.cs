using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5, 6);

            dortIslem.Topla(5, 12);

            dortIslem.Topla(123123, 213);

            dortIslem.Carp(3, 2);

            dortIslem.Bol(4, 2);

        }
    }
}
