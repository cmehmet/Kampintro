using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        string Update(IFormFile file, string root, string filepath);
        void Delete(string filepath);
    }
}
