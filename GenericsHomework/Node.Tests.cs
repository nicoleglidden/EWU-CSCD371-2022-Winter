using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;


namespace Node.Tests
{
	[TestClass]
	public class Class1
	{
		[TestMethod]
		public void ValidNode_ToString_Victory()
        {

            Node<string> node = new Node<string>("Hello World");

            string? nodeString = node.ToString();

			Assert.AreEqual(nodeString, "Hello World");	

			//Arrange
			//Act
			//Assert
        }

		[TestMethod]
		public void Node_ToString_NullStringValue()
        {
			Node<string?> node = new Node<string?>(null);
			string? errorString = node?.ToString();

			Assert.IsNull(errorString);
				
        }
		
		[TestMethod]
		public void ValidNode_Append_Victory()
        {
			Node<string> node = new Node<string>("firstNode");
			node.Append("new node");

			Node<string> nextNode = node.Next;

			Assert.AreEqual<Node<string>>(nextNode, node.Next);



        }

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "Duplicate Value not permitted")]
		public void Node_AppendDuplicate_Error()
        {
			string T = "firstNode";
			Node<string> nextNode = new Node<string>(T);

			nextNode.Append(T);


        }

	

		
	}
}
