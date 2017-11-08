using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPComposite
{
    class Composite<T> : IComponent<T>
    {
        List<IComponent<T>> list;
        public T Name { get; set; }

        public Composite(T name)
        {
            Name = name;
            list = new List<IComponent<T>>();
        }
        public void Add(IComponent<T> component)
        {
            list.Add(component);
        }

        public string Display(int depth)
        {
            StringBuilder s = new StringBuilder(new string('-', depth));
            s.AppendLine($"Set {Name}, Length :{list.Count}");
            foreach (var item in list)
            {
                s.Append(item.Display(depth + 2));
            }
            return s.ToString();
        }

        IComponent<T> holder = null;
        public IComponent<T> Find(T searchItem)
        {
            holder = this;
            if (Name.Equals(searchItem))
                return this;

            IComponent<T> foundComponent = null;

            foreach (var item in list)
            {
                foundComponent = item.Find(searchItem);
                if(item.Equals(searchItem))
                {
                    if(foundComponent != null)
                    {
                        break;
                    }                   
                }
            }
            return foundComponent;
        }

        public IComponent<T> Remove(T component)
        {
            holder = this;

            IComponent<T> foundComponent = holder.Find(component);
            if(holder != null)
            {
                (holder as Composite<T>).list.Remove(foundComponent);
                return holder;
            }
            else
            {
                return this;
            }
        }
    }
}
