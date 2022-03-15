
namespace Assignment
{
    public class Node<T>
    {
        public Node(T TValue)
        {
            this.Value = TValue;
            this.Next = this;

        }

        public T Value { get; set; }
        public Node<T> Next { get; private set; }

        public override string? ToString()
        {
            string? value = Value?.ToString();
            return value;
        }

        public void Append(T TValue)
        {

            if (this.Exists(TValue))
            {
                throw new ArgumentException($"Duplicate Value not permitted:{nameof(TValue)}");
            }

            Node<T> node = new(TValue);
            this.Next = node;


        }

        public void Clear()
        {
            var nextNode = this.Next;
            _ = this;

            while (nextNode != this)
            {
                Node<T>? currentNode = nextNode;
                nextNode = currentNode.Next;
                currentNode.Next = currentNode;
            }

            this.Next = this;
            // Given a circular list we don't need to worry about garbage collection, as we've made all Nodes past the current Node unreachable by having it refer back to itself. No doubley circular linked lists please :(
        }

        public bool Exists(T TValue)
        {
            _ = this.Next;
            Node<T> currentNode = this;
            bool endOfList = false;
            bool exists = false;

            while (!endOfList && !exists)
            {
                if (currentNode.Value?.Equals(TValue) == true)
                {
                    exists = true;
                }
                if (currentNode.Next == currentNode)
                {
                    endOfList = true;
                }

                currentNode = currentNode.Next;
                // not at end of list

            }


            return exists;
        }

        public IEnumerable<T> ChildItems(int maximum)
        {
            IEnumerable<T> children = new;
            T child = this;
            for (int i = 0; i < maximum; i++)
            {
                children.Add(child);
                child = child.Next;
            }
            return children;
        }
    }
}

