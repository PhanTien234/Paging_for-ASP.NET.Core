namespace razorweb2.Helpers
{
    public class PagingModel
    {
        public int currentPage { get; set; }
        public int countPages { get; set; }

        //delegate Func
        public Func<int?, string> generateUrl { get; set; }
    }
}