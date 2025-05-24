namespace CliMenu.Helpers
{
    /// <summary>
    /// A base class that holds a reference to an inner object of type T.
    /// Can be used for delegation or proxy behavior.
    /// </summary>
    /// <typeparam name="T">The type of the inner object.</typeparam>
    public class Forwarding<T>
    {
        /// <summary>
        /// The object being wrapped or forwarded to.
        /// </summary>
        protected readonly T inner;

        /// <summary>
        /// Initializes a new instance of the Forwarding class.
        /// </summary>
        /// <param name="inner">The object to wrap or forward to.</param>
        public Forwarding(T inner)
        {
            this.inner = inner;
        }
    }
}