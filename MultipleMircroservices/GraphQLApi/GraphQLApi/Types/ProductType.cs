using GraphQLApi.Models;

namespace GraphQLApi.Types
{
    public class ProductType :ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Field(e => e.Productid).Type<NonNullType<IdType>>();
            descriptor.Field(e => e.Productname).Type<NonNullType<StringType>>();
            descriptor.Field(e => e.Category).Type<CategoryType>();
        }

    }
}
