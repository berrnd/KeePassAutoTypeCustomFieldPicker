namespace AutoTypeCustomFieldPicker
{
    public class MyFieldObject
    {
        public MyFieldObject(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return this.Key;
        }
    }
}
