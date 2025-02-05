namespace {RootNamespace}.{ModuleName}.Configurations;

public class {ModuleName}Options
{
    public required string ApiPrefix { get; set; }
    
    public class Builder
    {
        private readonly {ModuleName}Options _options = new {ModuleName}Options(){ ApiPrefix = string.Empty };

        public Builder ApiPrefix(string apiPrefix)
        {
            _options.ApiPrefix = apiPrefix;
            return this;
        }

        public {ModuleName}Options Build()
        {
            return _options;
        }
    }
}
