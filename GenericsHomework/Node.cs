
namespace GenericsHomework
{
    public class Node<T> where T : notnull 
    {
        public Node(T TValue)
        {
            this.Value = TValue;
            this.Next = this;
            
        }

        public T Value { get; set;}

        public override string ToString()
        {
            string? value = Value.ToString(); 
            return value;
        }

        public Node<T> Next { get; private set;}

        public void Append(T TValue)
        {
          
            if (this.Exists(TValue))
            {
                throw new ArgumentException($"Duplicate Value not permitted:{nameof(TValue)}");
            }

            Node<T> node = new Node<T> (TValue);
            this.Next = node; 


        }

        public void Clear()
        {
            var nextNode = this.Next;
            var currentNode = this;

            while (nextNode != this)
            {
               currentNode = nextNode;
               nextNode = currentNode.Next;
               currentNode.Next = currentNode;
            }

            this.Next = this; 
            // Given a circular list we don't need to worry about garbage collection, as we've made all Nodes past the current Node unreachable by having it refer back to itself. No doubley circular linked lists please :(
        }

        public bool Exists( T TValue)
        {
            var nextNode = this.Next;
            var currentNode = this;

            if (this.Value.Equals(TValue))
            {
                return true;
            }
            
            
            while (currentNode != nextNode.Next)
            {
                if (nextNode.Value.Equals(TValue))
                {
                    return true;
                }
                nextNode = currentNode.Next;
                // not at end of list

            }

            return false;
        }

    }
}

