namespace MyDemo
{
    internal class Product
    {
        private object value1;
        private object value2;

        public Product(object value1, object value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }

        public string Name { get; internal set; }
    }
}