using ETicaret.Application.ViewModels.Products;
using FluentValidation;

namespace ETicaret.Application.Validatiors.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150).MinimumLength(2).WithMessage("Lütfen ürün adını 2 ile 150 karekter arasında giriniz.");
            RuleFor(p => p.Stock).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                          .Must(s=> s>=0).WithMessage("Lütfen stok bilgisini 0 dan küçük olamaz.");
            RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                         .Must(s => s >= 0).WithMessage("Lütfen Fiyat bilgisini 0 dan küçük olamaz.");
        }
    }
}
