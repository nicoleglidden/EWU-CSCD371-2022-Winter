using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void ValidNode_ToString_Victory()
        {

            Node<string> node = new("Hello World");

            string? nodeString = node.ToString();

            Assert.AreEqual(nodeString, "Hello World");

            //Arrange
            //Act
            //Assert
        }

        [TestMethod]
        public void Node_ToString_NullStringValue()
        {
            Node<string?> node = new(null);
            string? errorString = node?.ToString();

            Assert.IsNull(errorString);

        }

        [TestMethod]
        public void ValidNode_Append_Victory()
        {
            Node<string> node = new("firstNode");
            node.Append("new node");

            Node<string> nextNode = node.Next;

            Assert.AreEqual<Node<string>>(nextNode, node.Next);



        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Duplicate Value not permitted")]
        public void Node_AppendDuplicate_Error()
        {
            string T = "firstNode";
            Node<string> nextNode = new(T);

            nextNode.Append(T);


        }

        [TestMethod]
        public void Node_Clear_Success()
        {
            Node<string> node = new("firstNode");
            node.Clear();

            Assert.AreEqual<Node<string>>(node, node.Next);
        }

        [TestMethod]
        public void Node_Exists_Success()
        {
            Node<string> node = new("firstNode");
            node.Append("secondNode");

            bool exists = node.Exists("secondNode");

            Assert.IsTrue(exists);
        }
    }

}