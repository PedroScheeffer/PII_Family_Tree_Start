namespace Library
{
    public class MayorHijoVisitor : IVisitor
    {
        public Person mayorHijo;
        public Node node;
        public void visit(Node node)
        {
            this.node = node;
            menor(node);
        }
        public void menor(Node node)
        {
            if (mayorHijo == null)
            {
                mayorHijo = node.person;
            }
            else
            {
                if (this.node.person.age >= mayorHijo.age)
                {
                    mayorHijo = this.node.person;
                }
            }
            foreach (Node child in node.Children)
            {
                child.acceptVisitor(this);
            }
        }
        public new string ToString()
        {
            return mayorHijo.age.ToString();
        }
    }
}