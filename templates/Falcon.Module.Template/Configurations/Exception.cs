namespace {RootNamespace}.{ModuleName}.Configurations;

[Serializable]
public class {ModuleName}Exception : Exception
{
    public {ModuleName}Exception(string message) : base(message) { }
    public {ModuleName}Exception(string message, Exception innerException) : base(message, innerException) { }
    protected {ModuleName}Exception(SerializationInfo info, StreamingContext context) : base(info, context) { }
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (info is null)
            throw new ArgumentNullException(nameof(info));
        
        base.GetObjectData(info, context);
    }
}