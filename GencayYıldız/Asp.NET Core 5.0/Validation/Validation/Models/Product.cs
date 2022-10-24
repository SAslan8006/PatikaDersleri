using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Validation.Models.ModelMetaDataTypes;

namespace Validation.Models
  
{
    
    [ModelMetadataType(typeof(ProductMetaData))] // Metadata bilgilerinin nerede olduğunu işaret ettik
    public class Product
    {
        public string ProductName { get; set; }
        public string Quantity { get; set; }
        public string Email { get; set; }
    }
}
