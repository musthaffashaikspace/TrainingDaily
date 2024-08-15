using GraphQLApi.Models;

namespace GraphQLApi.Types
{
    public class CategoryType : ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            descriptor.Field(d=>d.Categoryid).Type<NonNullType<IdType>>();
            descriptor.Field(d=>d.CategoryName).Type<NonNullType<StringType>>();
            descriptor.Field(d => d.Products).Type<ListType<ProductType>>();
        }
    }
}
