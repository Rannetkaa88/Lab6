using System;

namespace Lab6C_
{
    class Lion : IMeowable
    {
        public string name { get; set; }

        public Lion()
        {
            this.name = "Ñèìáà";
        }

        public void meow()
        {
            Console.WriteLine($"{name}: ìÿó!");
        }

        public override string ToString()
        {
            return "ëåâ: " + name;
        }

        public void meow(int c)
        {
            string s = $"{name}: ";
            for (int i = 0; i < c; i++)
            {
                if (i == 0) s += "ìÿó";
                else s += "-ìÿó";
            }
            s += "!";
            Console.WriteLine(s);
        }
    }
}