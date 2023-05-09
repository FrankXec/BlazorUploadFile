using BlazorInputFile;
namespace SubirPdfCliente.Service
{
    public interface IUploadFile
    {
        Task uploadFile(IFileListEntry file);
    }
}
