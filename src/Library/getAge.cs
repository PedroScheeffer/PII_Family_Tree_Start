namespace Library
{
    public class getAge : IVisitor
    {
        public int age;
        public Node node;
        public void visit(Node node){
            this.node = node;
            calulateAge(node);
        }
        public void calulateAge(Node node){ 
            this.age = this.node.person.age + this.age;
            foreach (Node child in node.Children)
            {
                child.acceptVisitor(this);
            }
        }
        public new string ToString(){
            return age.ToString();
        }
    }
}