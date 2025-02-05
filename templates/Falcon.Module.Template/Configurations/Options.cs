namespace {RootNamespace}.{ModuleName}.Configurations;

public class {ModuleName}Options
{
    public required string Property1 { get; set; }

    public class Builder
    {
        private readonly {ModuleName}Options _options = new {ModuleName}Options();

        public Builder Property1(string property1)
        {
            _options.Property1 = property1;
            return this;
        }

        public {ModuleName}Options Build()
        {
            return _options;
        }
    }
}
