using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jorge = new Person("jorge", 1);
            Person pablo = new Person("pablo", 1);
            Person arturo = new Person("arturo", 1);
            Person maria = new Person("maria", 1);

            Person aline = new Person("aline", 1);
            Person victoria = new Person("victoria", 10);
            Person ash = new Person("ash", 1);
            Person bob = new Person("bob", 1);
            Node n1 = new Node(1, jorge);
            Node n2 = new Node(2, pablo);
            Node n3 = new Node(3, arturo);
            Node n4 = new Node(4, maria);
            Node n5 = new Node(5, aline);
            Node n6 = new Node(6, victoria);
            Node n7 = new Node(7, ash);
            Node n8 = new Node(8, bob);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            getAge vistAge =  new getAge();
            n1.acceptVisitor(vistAge);
            System.Console.WriteLine(vistAge.ToString());

            MayorHijoVisitor vistorMayor = new MayorHijoVisitor();
            n1.acceptVisitor(vistorMayor);
            System.Console.WriteLine(vistorMayor.ToString());

            NombreMasLargo nombreLargo = new NombreMasLargo();
            n1.acceptVisitor(nombreLargo);
            System.Console.WriteLine(nombreLargo.ToString());
        }
    }
}
