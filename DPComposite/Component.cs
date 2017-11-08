using System;

namespace DPComposite
{
    public class Component<T> : IComponent<T>
    {
        public T Name { get; set; }
        public Component(T name)
        {
            Name = name;
        }

        public void Add(IComponent<T> component)
        {
            System.Console.WriteLine($"Cannot add to an Item");
        }

        public string Display(int depth)
        {
            return $"{new string('-', depth)}{Name}{Environment.NewLine}";
        }

        public IComponent<T> Find(T item)
        {
            if (item.Equals(Name))
                return this;
            else
                return null;
        }

        public IComponent<T> Remove(T component)
        {
            System.Console.WriteLine($"Cannot add to an Item");
            return this;
        }
    }
}