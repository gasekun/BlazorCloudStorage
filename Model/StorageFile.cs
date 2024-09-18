namespace BlazorCloudStorage.Model;

public class StorageFile
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public long Size { get; set; }
    public DateTime DateUpload { get; set; }
    public Guid Owner { get; set; }
}