using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FibesApp.Interfaces
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
