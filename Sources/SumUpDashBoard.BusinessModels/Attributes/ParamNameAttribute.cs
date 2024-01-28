namespace SumUpDashBoard.BusinessModels.Attributes
{
    public class ParamNameAttribute : Attribute
    {
        public static readonly ParamNameAttribute Default;

        public ParamNameAttribute(string name)
        {
            Name = name;
        }

        public virtual string Name { get; }
        protected string NameValue { get; set; }
    }
}
