using BlazorInputFile;

namespace SubirPdfCliente.Service
{
    public class UploadFile : IUploadFile
    {
        private readonly IWebHostEnvironment _environment;

        public UploadFile(IWebHostEnvironment environment) {
            this._environment = environment;
        }

        public async Task uploadFile(IFileListEntry file)
        {
            var path = Path.Combine(_environment.ContentRootPath,"Upload", Guid.NewGuid()+file.Name);
            var memory = new MemoryStream();
            await file.Data.CopyToAsync(memory);
            using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write)) {
                memory.WriteTo(stream);
            }
        }
    }
}
