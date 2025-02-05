namespace {RootNamespace}.{ModuleName}.Configurations;

[Serializable]
public class {ModuleName}Exception : Exception
{
    public {ModuleName}Exception(string message) : base(message) { }
    public {ModuleName}Exception(string message, Exception innerException) : base(message, innerException) { }
}