namespace _349_1._Utilities
{
    public class Class1
    {

    }
    public static class EnumerableExtensions
    {
        public static string AsString<T> (this IEnumerable<T> items)
        {
            return String.Join(Environment.NewLine, items);
        }
    }

    public class PublicClass
    {
        protected internal void ProtectedInternal() { }

        private protected void PrivateProtected() { }
    }
    public class UsingPublicClass : PublicClass 
    {
        void TestPrivateProtected()
        {
            PrivateProtected();
        }
    }


    internal class InternalClass
    {
        public static void CallingProtectedInternal()
        { 
            new PublicClass().ProtectedInternal();
        }
    }
    public class UsingInternalClass
    {
        private InternalClass _internalClass;
    }

    file class AccessibleOnlyInThisFile { }

}
