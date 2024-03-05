namespace HotChocolateIDict
{
    public class RootQuery
    {
        public async Task<PageVOAllergyIntolerance> GetPagedAllergyIntoleranceAsync()
        {
            return new PageVOAllergyIntolerance();
        }
    }
}