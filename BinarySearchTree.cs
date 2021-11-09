using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
   
    class BinarySearchTree<T> where T: IComparable<T>
    {
        public static int leftCount = 0, rightCount=0;
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;   
        }

         
       
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        public void Display()
        {
            if(this.LeftTree != null)
            {
                leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.RightTree != null)
            {
                rightCount++;
                this.RightTree.Display();
                    
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }

    }
}
