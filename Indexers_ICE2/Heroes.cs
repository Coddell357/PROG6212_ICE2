using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_ICE2
{
    public class Heroes
    {
        private int age;
        private string name, superPower, weakness, personality, background;

        public Heroes(string name, int age, string superPower, string weakness, string personality, string background)
        {
            this.name = name;
            this.age = age;
            this.superPower = superPower;
            this.weakness = weakness;
            this.personality = personality;
            this.background = background;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.age;
                else if (index == 2)
                    return this.superPower;
                else if (index == 3)
                    return this.weakness;
                else if (index == 4)
                    return this.personality;
                else if (index == 5)
                    return this.background;
                return null;
            }
            set
            {
                if (index == 0)
                    this.name = (string)value; //sets value based on index
                else if (index == 1)
                    this.age = (int)value;
                else if (index == 2)
                    this.superPower = (string)value;
                else if (index == 3)
                    this.weakness = (string)value;
                else if (index == 4)
                    this.personality = (string)value;
                else if (index == 5)
                    this.background = (string)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("name"))
                    return this.name;
                else if (attrName.ToLower().Equals("age"))
                    return this.age;
                else if (attrName.ToLower().Equals("superpower"))
                    return this.superPower;
                else if (attrName.ToLower().Equals("weakness"))
                    return this.weakness;
                else if (attrName.ToLower().Equals("personality"))
                    return this.personality;
                else if (attrName.ToLower().Equals("background"))
                    return this.background;
                return null;
                //looks at attribute name, converted to lower case and returns matching value
            }
            set
            {
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("age"))
                    this.age = (int)value;
                else if (attrName.ToLower().Equals("superpower"))
                    this.superPower = (string)value;
                else if (attrName.ToLower().Equals("weakness"))
                    this.weakness = (string)value;
                else if (attrName.ToLower().Equals("personality"))
                    this.personality = (string)value;
                else if (attrName.ToLower().Equals("background"))
                    this.background = (string)value;

            }
        }
    }
}
