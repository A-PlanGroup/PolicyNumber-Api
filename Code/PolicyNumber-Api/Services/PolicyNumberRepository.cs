using SuggestiveService.Interfaces;
using System;
using System.IO;
using SuggestiveService.Models;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;
using SuggestiveService.Models.AvailableData;
using System.Transactions;

namespace SuggestiveService.Services
{
    /// <summary>
    /// Local file service for reading the local file for prompts data.
    /// </summary>
    public class PolicyNumberRepository : IPolicyNumberRepository
    {
        private readonly MappingContext _context;
       // private readonly ICacheService _cacheService;
        public PolicyNumberRepository(MappingContext context)
        {
            _context = context;

            
        }


        public string GetUpdatePolicyNumber(string productname,string scheme)
        {
            try
            {
                PolicyNumber product=null;
                string nextPolicyNumber = "No Match Found";
                // var ss= _context.PolicyNumber.Select(s => s.Product).ToList();

                using(var scope = new TransactionScope(TransactionScopeOption.Required,new TransactionOptions { IsolationLevel = IsolationLevel.Snapshot }))
                {
                    //Lock the table during this transaction
                    _context.Database.ExecuteSqlCommand("SELECT TOP 1 ID FROM policynumber WITH (TABLOCKX, HOLDLOCK)");
                    if (!string.IsNullOrEmpty(productname) && !string.IsNullOrEmpty(scheme))
                        product = _context.PolicyNumber.FirstOrDefault(s => s.Product.Trim() == productname.Trim() && s.Scheme.Trim() == scheme.Trim());
                    else if (!string.IsNullOrEmpty(productname))
                        product = _context.PolicyNumber.FirstOrDefault(s => s.Product.Trim() == productname.Trim());
                    else if (!string.IsNullOrEmpty(scheme))
                        product = _context.PolicyNumber.FirstOrDefault(s => s.Scheme == scheme);

                    if (product != null)
                    {
                        product.CurrentNumber = product.CurrentNumber + 1;
                        nextPolicyNumber = product.Prefix + product.CurrentNumber.ToString("D5") + product.Suffix;
                        _context.SaveChanges();
                    }

                    scope.Complete();
                }


                return nextPolicyNumber;
            }
            catch (DbUpdateException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
       

        
    }

}

