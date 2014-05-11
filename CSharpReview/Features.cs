using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview
{
    public class Features
    {
        public void FeaturesList()
        {
            #region object initializer
            //c# 2.0
            MyClass c = new MyClass();
            c.Prop = "test";

            Record rec = new Record();
            rec.Id = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e");
            rec.Name = "Marc";
            rec.TypeId = null;

            //c# 3.0
            MyClass cc = new MyClass { Prop = "test" };

            var r = new Record() {Id = Guid.NewGuid(), Name = "Marc", TypeId = 3};
            #endregion

            #region Collection Initializers
            //c# 2.0
            List<string> list1 = new List<string>(2);
            list1.Add("test1");
            list1.Add("test2");

            //c# 3.0
            List<string> list2 = new List<string> { "test1", "test2" }; 

            #endregion

            #region Dictionary Initializers
            //c# 2.0
            IDictionary<string, string> dict1 = new Dictionary<string, string>(2);
            dict1.Add("test1", "test1");
            dict1.Add("test2", "test2");

            //c# 3.0
            Dictionary<string, string> dict2 = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
            #endregion

            #region Linq
            string[] list = new string[] { "csharp", "vb", "java" }; 
            //c# 2.0
            List<string> results = new List<string>();
            foreach (string str in list)
                if (str.StartsWith("t"))
                    results.Add(str);

            //c# 3.0
            IEnumerable<string> result = from x in list
                                         where x.StartsWith("t")
                                         select x;

            IEnumerable<string> result5 = list.Where(a => a.StartsWith("t")).Select(a => a);
            #endregion

        }
    }

    class MyClass
    {
        //c# 2.0
        private string prop;
        public string Prop
        {
            get { return prop; }
            set { prop = value; }
        }

        //c# 3.0
        private string Property { get; set; }
    }

    public class Record
    {
        public Guid Id;
        public string Name;
        public int? TypeId;
    }
}
