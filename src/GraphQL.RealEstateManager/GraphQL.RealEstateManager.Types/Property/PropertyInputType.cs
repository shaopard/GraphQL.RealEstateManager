using GraphQL.Types;

namespace GraphQL.RealEstateManager.Types.Property
{
    public class PropertyInputType : InputObjectGraphType
    {
        public PropertyInputType()
        {
            Name = nameof(PropertyInputType);
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("city");
            Field<StringGraphType>("family");
            Field<StringGraphType>("street");
            Field<IntGraphType>("value");
        }
    }
}
