namespace OriginalTestDataBuilders
{
    public class PostCode
    {
        private string postCodeDetails;

        public PostCode(string postCodeDetails)
        {
            this.postCodeDetails = postCodeDetails;
        }

        public string PostCodeDetails
        {
            get { return this.postCodeDetails; }
        }
    }
}