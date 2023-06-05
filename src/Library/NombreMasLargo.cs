namespace Library
{
    public class NombreMasLargo : IVisitor
    {
        public string nombreMasLargo;
        public Node node;
        public void visit(Node node)
        {
            this.node = node;
            menor(node);
        }
        public void menor(Node node)
        {
            if (nombreMasLargo == null)
            {
                nombreMasLargo = node.person.name;
            }
            else
            {
                if (this.node.person.name.Length >= nombreMasLargo.Length)
                {
                    nombreMasLargo = this.node.person.name;
                }
            }
            foreach (Node child in node.Children)
            {
                child.acceptVisitor(this);
            }
        }
        public new string ToString()
        {
            return nombreMasLargo;
        }
    }
}