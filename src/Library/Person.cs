using System.Collections.Generic;
namespace Library
{
    public class Person
    {
        public string name {get;set;}
        public int age {get;private set;}
        public Person (string name, int age){
            this.name = name;
            this.age = age;
        }
    }
}