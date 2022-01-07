namespace NacktBank.AgencySystem.helpers
{
    public class extratorArgumentsByUrl
    {
        private readonly string _URL;
        private readonly string _arguments;
        public string Arguments { get { return _arguments; } }

        public extratorArgumentsByUrl(string URL)
        {
            if (string.IsNullOrEmpty(URL))
            {
                throw new ArgumentException($"'{nameof(URL)}' cannot be null or empty.", nameof(URL));
            }
            _URL = URL;
            _arguments = getArguments();
        }

        private string getArguments() {
            int separator = _URL.IndexOf('?') + 1;
            string arguments = _URL.Substring(separator);

            return arguments;
        }
    }
}