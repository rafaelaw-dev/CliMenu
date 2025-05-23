namespace CliMenu.Abstract
{
    public abstract class Fowarding<T>
    {
        protected readonly T inner;

        public Fowarding(T inner)
        {
            this.inner = inner;
        }
    }
}