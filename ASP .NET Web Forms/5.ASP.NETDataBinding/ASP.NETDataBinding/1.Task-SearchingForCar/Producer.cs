using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDataBinding._1.Task_SearchingForCar
{
    public class Producer
    {
        private string name;
        private List<string> models;

        public Producer(string name,List<string> models)
        {
            this.Name = name;
            this.Models = models;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public List<string> Models
        {
            get
            {
                return this.models;
            }
            set
            {
                this.models = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}