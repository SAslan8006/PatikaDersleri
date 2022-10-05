using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            //Fluent Validation
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz.");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            //RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==2); //Kategori id =2 olanlar en az 10 olabilir stokları

            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün ismi A ile başlamalıdır."; //başlangıç harfi a olanlar olmalı

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
