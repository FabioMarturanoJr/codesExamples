namespace NacktBank.AgencySystem.helpers
{
    public class extratorArgumentsByUrl
    {
        private readonly string _URL;
        private readonly string _arguments;
        public string Arguments { get { return _arguments; } }

        public extratorArgumentsByUrl(string URL)
        {
            if (string.IsNullOrEmpty(URL)) throw new ArgumentException($"'{nameof(URL)}' cannot be null or empty.", nameof(URL));

            _URL = URL.ToLower();
            _arguments = getArguments();
        }
        private string getArguments() {
            int separator = _URL.IndexOf('?') + 1;
            string arguments = _URL.Substring(separator);
            return arguments;
        }
        public string GetValue(string paramName) {
            string lowerParam = paramName.ToLower();

            if (!_arguments.Contains(lowerParam)) return $"{nameof(paramName)}: {paramName} not found";

            string term = lowerParam + "=";
            int indexTerm = _arguments.IndexOf(term);
            string arg = _arguments.Substring(indexTerm + term.Length);

            char nextArg = '&';
            if (!arg.Contains(nextArg)) return arg;

            int indexNextArq = arg.IndexOf(nextArg);
            return arg.Remove(indexNextArq);
        }
    }
}