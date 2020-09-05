namespace BranchCoverage
{
    public class Config
    {
        private readonly Options _options;

        public Config(Options options)
        {
            _options = options;
        }

        public string ConnectionString => _options?.ConnectionString;
    }
}
