using System;

namespace HashTable
{
    class program
    {
        public static void Main(string[] args)
        {
            //MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");

            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value: " + hash5);
            //hash.Remove("2");
            //string hash2 = hash.Get("2");
            //Console.WriteLine("2nd index value:" + hash2);

            //MyMapNode1<string, string> node = new MyMapNode1<string, string>(18);

            //node.Add("0", "Paranoids");
            //node.Add("1", "are");
            //node.Add("2", "not");
            //node.Add("3", "Paranoid");
            //node.Add("4", "because");
            //node.Add("5", "they");
            //node.Add("6", "are");
            //node.Add("7", "paranoid");
            //node.Add("8", "but");
            //node.Add("9", "beacudse");
            //node.Add("10", "they");
            //node.Add("11", "keep");
            //node.Add("12", "putting");
            //node.Add("13", "themselves");
            //node.Add("14", "deliberately");
            //node.Add("15", "into");
            //node.Add("16", "paranoid");
            //node.Add("17", "avoidable");
            //node.Add("18", "situation");


            //string node0 = node.Get("0");
            //Console.WriteLine("0th index value: " + node0);
            //string node1 = node.Get("1");
            //Console.WriteLine("1st index value: " + node1);
            //string node2 = node.Get("2");
            //Console.WriteLine("2nd index value: " + node2);
            //string node3 = node.Get("3");
            //Console.WriteLine("3rd index value: " + node3);
            //string node4 = node.Get("4");
            //Console.WriteLine("4th index value: " + node4);
            //string node5 = node.Get("5");
            //Console.WriteLine("5th index value: " + node5);
            //string node6 = node.Get("6");
            //Console.WriteLine("6th index value: " + node6);
            //string node7 = node.Get("7");
            //Console.WriteLine("7th index value: " + node7);
            //string node8 = node.Get("8");
            //Console.WriteLine("8th index value: " + node8);
            //string node9 = node.Get("9");
            //Console.WriteLine("9th index value: " + node9);
            //string node10 = node.Get("10");
            //Console.WriteLine("10th index value: " + node10);
            //string node11= node.Get("11");
            //Console.WriteLine("11th index value: " + node11);
            //string node12= node.Get("12");
            //Console.WriteLine("12th index value: " + node12);
            //string node13= node.Get("13");
            //Console.WriteLine("13th index value: " + node13);
            //string node14= node.Get("14");
            //Console.WriteLine("14th index value: " + node14);
            //string node15 = node.Get("15");
            //Console.WriteLine("15th index value: " + node15);
            //string node16 = node.Get("16");
            //Console.WriteLine("16th index value: " + node16);
            //string node17 = node.Get("17");
            //Console.WriteLine("17th index value: " + node17);
            //string node18 = node.Get("18");
            //Console.WriteLine("18th index value: " + node18);
            
            MyMapNode2<string, string> list = new MyMapNode2<string, string>(18);
            list.Add("0", "Paranoids");
            list.Add("1", "are");
            list.Add("2", "not");
            list.Add("3", "Paranoid");
            list.Add("4", "because");
            list.Add("5", "they");
            list.Add("6", "are");
            list.Add("7", "paranoid");
            list.Add("8", "but");
            list.Add("9", "beacudse");
            list.Add("10", "they");
            list.Add("11", "keep");
            list.Add("12", "putting");
            list.Add("13", "themselves");
            list.Add("14", "deliberately");
            list.Add("15", "into");
            list.Add("16", "paranoid");
            list.Add("17", "avoidable");
            list.Add("18", "situation");

            string list0 = list.Get("0");
            Console.WriteLine("0th index value: " + list0);
            string list1 = list.Get("1");
            Console.WriteLine("1st index value: " + list1);
            string list2 = list.Get("2");
            Console.WriteLine("2nd index value: " + list2);
            string list3 = list.Get("3");
            Console.WriteLine("3rd index value: " + list3);
            string list4 = list.Get("4");
            Console.WriteLine("4th index value: " + list4);
            string list5 = list.Get("5");
            Console.WriteLine("5th index value: " + list5);
            string list6 = list.Get("6");
            Console.WriteLine("6th index value: " + list6);
            string list7 = list.Get("7");
            Console.WriteLine("7th index value: " + list7);
            string list8 = list.Get("8");
            Console.WriteLine("8th index value: " + list8);
            string list9 = list.Get("9");
            Console.WriteLine("9th index value: " + list9);
            string list10 = list.Get("10");
            Console.WriteLine("10th index value: " + list10);
            string list11 = list.Get("11");
            Console.WriteLine("11th index value: " + list11);
            string list12 = list.Get("12");
            Console.WriteLine("12th index value: " + list12);
            string list13 = list.Get("13");
            Console.WriteLine("13th index value: " + list13);
            string list14 = list.Get("14");
            Console.WriteLine("14th index value: " + list14);
            string list15 = list.Get("15");
            Console.WriteLine("15th index value: " + list15);
            string list16 = list.Get("16");
            Console.WriteLine("16th index value: " + list16);

            list.Remove("17");
            string list17 = list.Get("17");
            Console.WriteLine("17th index value: " + list17);
            string list18 = list.Get("18");
            Console.WriteLine("18th index value: " + list18);

            



        }
    }
}