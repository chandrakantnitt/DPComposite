namespace DPComposite
{
    public interface IComponent<T>
    {
        void Add(IComponent<T> component);
        IComponent<T> Remove(T component);
        IComponent<T> Find(T v);
        string Display(int depth);
        T Name { get; set; }
        //T Item { get; set; }
    }
}