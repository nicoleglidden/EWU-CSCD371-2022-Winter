namespace GenericsHomework
{
    public class Node<T> 
    {
        public Node(T TValue)
        {
            this.Value = TValue;
            this.Next = this;
            
        }

        public T Value { get; set;}

        public override string ToString()
        {
            return TValue.ToString();
        }

        public Node<T> Next { get; private set;}

        public void Append(T TValue)
        {
          
            Node<T> node = new Node<T> (TValue);
            this.Next = node; 

        }

        public void Clear()
        {
            this.Next = this; 

            // Given a circular list we don't need to worry about garbage collection, as we've made all Nodes past the current Node unreachable by having it refer back to itself. No doubley circular linked lists please :(
        }

        public bool Exists(T TValue)
        {
            var currentNode = this.Next;
            var previousNode = this;

            if (this.Value == TValue)
            {
                return true;
            }
            
            
            while (previousNode != currentNode.Next)
            {
                if (currentNode.Value == TValue)
                {
                    return true;
                }
                currentNode = previousNode.Next;
                // not at end of list

                
                



               
            }

            
           

            return false;
        }

    }
}