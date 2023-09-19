using System;
using System.Collections.Generic;

namespace Learning02
{


    public class Resume
      {

        public Resume()
        {
            _name = "";
        }
        public string _name;
        public List<Job> jobs = new List<Job>();

        public void add( Job props)
        {
            jobs.Add(props);
        }

        public void Display()
        {
            Console.WriteLine($"Name:{_name}");
            Console.WriteLine("Jobs:");
            foreach ( Job unit in jobs)
            {
                unit.Display();
            }

        }//--------------
    }//-- Resume
}//----------Learning02
