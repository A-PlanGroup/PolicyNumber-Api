using SuggestiveService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SuggestiveService.Interfaces
{
    /// <summary>
    /// Get the file containing prompts
    /// </summary>
    public interface IPolicyNumberRepository 
    {
        string GetUpdatePolicyNumber(string productname,string schema);
    }
}
